using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asp_Core_Proje.ViewComponents.Dashboard
{
    public class FeatureStatistics:ViewComponent
    {
        Context c = new Context();

        public IViewComponentResult Invoke()
        {
            // proje sayısı
            // okunmamış mesaj sayısı
            ViewBag.proje_sayi = c.Portfolios.Count();
            ViewBag.okunmamis = c.Messages.Where(m => m.Status == true).Count();
            ViewBag.calisilan_firma = c.Experiences.Count();
            ViewBag.bilinen_diller = c.Skills.Count();
            return View();
        }
    }
}
