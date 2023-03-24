using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Asp_Core_Proje.Controllers
{
    [AllowAnonymous]
    public class DefaultController : Controller
    {
        MessageManager messageManager = new MessageManager(new EfMessageDal());
        Context c = new Context();
        IConfiguration _IConfig;

        public DefaultController(IConfiguration ıConfig)
        {
            _IConfig = ıConfig;
        }

        public async Task<bool> CheckCaptcha()
        {
            string SecretKey = _IConfig.GetValue<string>("HCaptcha:Secret");
            var postData = new List<KeyValuePair<string, string>>()
            {
                new KeyValuePair<string, string>("secret", SecretKey),
                new KeyValuePair<string,string>("response",HttpContext.Request.Form["h-captcha-response"])
            };

            var client = new HttpClient();
            var response = await client.PostAsync("https://hcaptcha.com/siteverify", new FormUrlEncodedContent(postData));

            var o = (JObject)JsonConvert.DeserializeObject(await response.Content.ReadAsStringAsync());
            return (bool)o["success"];
        }

        public IActionResult Index()
        {
            var refrences = c.Testimonials.ToList();
            bool exist = false;
            foreach (var item in refrences)
            {
                if (item.Active == true)
                {
                    exist = true;
                    break;
                }
                else
                {
                    exist = false;
                }

            }
            ViewBag.isActive = exist;
            return View();

        }

        public PartialViewResult HeaderPartial()
        {
            return PartialView();
        }

        public PartialViewResult NavbarPartial()
        {
            return PartialView();
        }

        [HttpGet]
        public PartialViewResult SendMessage()
        {
            return PartialView();
        }

        [HttpPost]
        public async Task<IActionResult> SendMessage(Message m)
        {
            var hCaptchaImage = HttpContext.Request.Form["h-captcha-response"];
            var verified = await CheckCaptcha();
            if (string.IsNullOrEmpty(hCaptchaImage))
            {
                TempData["botFail"] = "Lütfen bot olmadığınızı doğrulayınız";
                return RedirectToAction("Index");
            }

            else if (!verified)
            {
                TempData["botFail"] = "Bot olmadığınız doğrulanamadı !";
                return RedirectToAction("Index");
            }
            else
            {
                m.Date = DateTime.Now;
                m.Status = true;
                messageManager.TAdd(m);
                TempData["messageSuccess"] = "Mesajınız başarıyla gönderildi";
                return RedirectToAction("Index", "Default");
            }
        }
    }
}
