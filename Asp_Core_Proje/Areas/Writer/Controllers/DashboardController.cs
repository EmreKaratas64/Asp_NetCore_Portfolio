using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Asp_Core_Proje.Areas.Writer.Controllers
{
    [Area("Writer")]
    [Route("Writer/[controller]/[action]")]
    public class DashboardController : Controller
    {
        private readonly UserManager<WriterUser> _userManager;

        public DashboardController(UserManager<WriterUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IActionResult> Index()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            ViewBag.Namee = values.Name + " " + values.Surname;
            //weather api
            string api = "a0de910daf94ec99c3ecec304ff15539";
            string connection = "https://api.openweathermap.org/data/2.5/weather?q=U%C5%9Fak&mode=xml&lang=&tr&units=metric&appid=" + api;
            XDocument document = XDocument.Load(connection);
            ViewBag.havaDurumu = document.Descendants("temperature").ElementAt(0).Attribute("value").Value;

            //statistics
            Context c = new Context();
            ViewBag.GelenMesaj = c.WriterMessages.Where(w => w.Receiver == values.Email).Count();
            ViewBag.DuyuruSayisi = c.Announcements.Count();
            ViewBag.KullaniciSayisi = c.Users.Count();
            ViewBag.GonderilenMesaj = c.WriterMessages.Where(w => w.Sender == values.Email).Count();
            return View();
        }
    }
}
/* 
https://api.openweathermap.org/data/2.5/weather?q=U%C5%9Fak&mode=xml&lang=&tr&units=metric&appid=a0de910daf94ec99c3ecec304ff15539
 */