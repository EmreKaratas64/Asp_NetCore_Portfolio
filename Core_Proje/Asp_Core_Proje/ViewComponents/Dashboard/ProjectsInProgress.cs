using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asp_Core_Proje.ViewComponents.Dashboard
{
    public class ProjectsInProgress : ViewComponent
    {
        //PortfolioManager portfolioManager = new PortfolioManager(new EfPortfolioDal());
        Context c = new Context();

        public IViewComponentResult Invoke()
        {
            var aktif_projeler = c.Portfolios.Where(p => p.Status == false).ToList();
            return View(aktif_projeler);
        }
    }
}
