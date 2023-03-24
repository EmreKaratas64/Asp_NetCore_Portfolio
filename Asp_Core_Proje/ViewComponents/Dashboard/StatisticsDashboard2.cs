using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asp_Core_Proje.ViewComponents.Dashboard
{
    public class StatisticsDashboard2:ViewComponent
    {
        Context c = new Context();

        public IViewComponentResult Invoke()
        {
            ViewBag.v1 = c.Messages.Count();
            ViewBag.v2 = c.Portfolios.Where(p => p.Status == true).Count();
            ViewBag.v3 = c.Testimonials.Count();
            return View();
        }
    }
}
