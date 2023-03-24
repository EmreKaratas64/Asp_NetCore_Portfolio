using Asp_Core_Proje.Areas.Writer.Models;
using Asp_Core_Proje.Models;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asp_Core_Proje.Controllers
{
    [AllowAnonymous]
    public class AdminForgetPasswordController : Controller
    {
        private readonly UserManager<WriterUser> _userManager;

        public AdminForgetPasswordController(UserManager<WriterUser> userManager)
        {
            _userManager = userManager;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(UserForgetPasswordViewModel u)
        {
            ValidatePass v = new ValidatePass();
            var user = await _userManager.FindByEmailAsync(u.Email);
            if (user == null)
            {
                ViewBag.ErrorMessage = "Kullanıcı bulunamadı lütfen geçerli bir mail adresi giriniz !";
                return View();
            }
            else
            {
                if (user.Name == u.Name && user.Surname == u.Surname && user.UserName == u.UserName)
                {
                    if (u.Password == u.ConfirmPassword && v.IsValidPassword(u.Password))
                    {
                        user.PasswordHash = _userManager.PasswordHasher.HashPassword(user, u.Password);
                        var result = await _userManager.UpdateAsync(user);
                        if (result.Succeeded)
                        {
                            return RedirectToAction("Index", "AdminLogin");
                        }
                        else
                        {
                            foreach (var item in result.Errors)
                            {
                                ModelState.AddModelError("", item.Description);
                            }
                            return View();
                        }
                    }
                    else
                    {
                        ViewBag.ErrorMessage3 = "Şifreniz: En az bir rakam, en az bir küçük harf, en az bir büyük harf ve en az bir tane özel karakter içermelidir";
                        return View();

                    }
                }
                else
                {
                    ViewBag.ErrorMessage2 = "Girdiğiniz bilgiler hatalıdır lütfen kontrol edip tekrar deneyiniz!";
                    return View();
                }
            }
        }
    }
}
