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
    [Authorize(Roles = "Admin")]
    public class ServiceController : Controller
    {
        ServiceManager serviceManager = new ServiceManager(new EfServiceDal());

        public IActionResult Index()
        {
            var values = serviceManager.TGetList();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddService()
        {
            return View();
        }


        [HttpPost]
        public IActionResult AddService(Service s)
        {
            ServiceValidator validations = new ServiceValidator();
            ValidationResult results = validations.Validate(s);
            if (results.IsValid)
            {
                serviceManager.TAdd(s);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
                return View();
            }
        }

        public IActionResult DeleteService(int id)
        {
            var value = serviceManager.TGetByID(id);
            serviceManager.TDelete(value);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateService(int id)
        {
            var values = serviceManager.TGetByID(id);
            return View(values);
        }

        [HttpPost]
        public IActionResult UpdateService(Service s)
        {
            ServiceValidator serviceValidator = new ServiceValidator();
            ValidationResult results = serviceValidator.Validate(s);
            if (results.IsValid)
            {
                serviceManager.TUpdate(s);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in results.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
                return View();
            }
        }

    }
}
