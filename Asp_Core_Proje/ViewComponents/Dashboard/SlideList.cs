using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asp_Core_Proje.ViewComponents.Dashboard
{
    public class SlideList : ViewComponent
    {
        PortfolioManager portfolioManager = new PortfolioManager(new EfPortfolioDal());
        FeatureManager featureManager = new FeatureManager(new EfFeatureDal());

        private readonly UserManager<WriterUser> _userManger;

        public SlideList(UserManager<WriterUser> userManger)
        {
            _userManger = userManger;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var values = portfolioManager.TGetList();
            var user = await _userManger.FindByNameAsync(User.Identity.Name);
            var meslek = featureManager.TGetByID(1);
            ViewBag.Image = user.ImageUrl;
            ViewBag.Meslek = meslek.Title;
            ViewBag.Name = meslek.Name;
            return View(values);
        }
    }
}
