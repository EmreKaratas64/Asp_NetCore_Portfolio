using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asp_Core_Proje.Controllers
{
    [AllowAnonymous]
    public class DefaultController : Controller
    {
        MessageManager messageManager = new MessageManager(new EfMessageDal());
        Context c = new Context();

        public IActionResult Index()
        {
            var refrences = c.Testimonials.ToList();
            bool exist = false;
            foreach(var item in refrences)
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
        public IActionResult SendMessage(Message m)
        {
            m.Date = DateTime.Now;
            m.Status = true;
            messageManager.TAdd(m);
            return RedirectToAction("Index", "Default");
        }
    }
}
