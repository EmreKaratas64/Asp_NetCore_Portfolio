using Asp_Core_Proje.Areas.Writer.Models;
using Asp_Core_Proje.Models;
using BusinessLayer.Concrete;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Asp_Core_Proje.Areas.Writer.Controllers
{
    [Area("Writer")]
    [Route("Writer/[controller]/[action]")]
    public class ProfileController : Controller
    {
        private readonly UserManager<WriterUser> _userManager;
        private readonly SignInManager<WriterUser> _signInManager;

        public ProfileController(UserManager<WriterUser> userManager, SignInManager<WriterUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            UserEditViewModel model = new UserEditViewModel();
            model.Name = values.Name;
            model.Surname = values.Surname;
            model.PictureUrl = values.ImageUrl;
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Index(UserEditViewModel u)
        {
            ValidatePass v = new ValidatePass();
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            if (u.Picture != null && v.IsValidPassword(u.Password))
            {
                var resource = Directory.GetCurrentDirectory();
                var extention = Path.GetExtension(u.Picture.FileName);
                var imagename = Guid.NewGuid() + extention;
                var savelocation = resource + "/wwwroot/userimage/" + imagename;
                var stream = new FileStream(savelocation, FileMode.Create);
                await u.Picture.CopyToAsync(stream);
                user.ImageUrl = imagename;
            }

            if (u.Password == u.PasswordConfirm && u.Name.ToLower() != "admin" && v.IsValidPassword(u.Password))
            {
                user.Name = u.Name;
                user.Surname = u.Surname;
                user.PasswordHash = _userManager.PasswordHasher.HashPassword(user, u.Password);
                var result = await _userManager.UpdateAsync(user);
                if (result.Succeeded)
                {
                    await _signInManager.SignOutAsync();
                    return RedirectToAction("Index", "Login");
                }
                else
                {
                    foreach (var item in result.Errors)
                    {
                        ModelState.AddModelError("", item.Description);
                    }
                }
            }
            return View();
        }
    }
}