using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asp_Core_Proje.Areas.Writer.ViewComponents
{
    public class Navbar:ViewComponent
    {
        private readonly UserManager<WriterUser> _userManger;

        public Navbar(UserManager<WriterUser> userManger)
        {
            _userManger = userManger;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var user =await _userManger.FindByNameAsync(User.Identity.Name);
            ViewBag.Image = user.ImageUrl;
            return View();
        }
    }
}
