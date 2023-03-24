using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asp_Core_Proje.Controllers
{
    [Authorize(Roles ="Admin")]
    public class AboutController : Controller
    {
        AboutManager aboutManager = new AboutManager(new EfAboutDal());

        [HttpGet]
        public IActionResult Index()
        {
            var value = aboutManager.TGetByID(1);
            return View(value);
        }

        [HttpPost]
        public IActionResult Index(About a)
        {
            AboutValidator featureValidator = new AboutValidator();
            ValidationResult results = featureValidator.Validate(a);
            if (results.IsValid)
            {
                aboutManager.TUpdate(a);
                return RedirectToAction("Index", "Default");
            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }

            }
            return View();

        }
    }
}
