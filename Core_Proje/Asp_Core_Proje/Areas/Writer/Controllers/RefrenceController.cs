using Asp_Core_Proje.Areas.Writer.Models;
using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Asp_Core_Proje.Areas.Writer.Controllers
{
    [Area("Writer")]
    public class RefrenceController : Controller
    {
        TestimonialManager tm = new TestimonialManager(new EfTestimonialDal());

        [HttpGet]
        public IActionResult RefrenceAdd()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> RefrenceAdd(AddRefrence p)
        {
            if (ModelState.IsValid)
            {
                Testimonial refrence = new Testimonial();

                if (p.Image != null)
                {
                    var resource = Directory.GetCurrentDirectory();
                    var extention = Path.GetExtension(p.Image.FileName);
                    var imagename = Guid.NewGuid() + extention;
                    var savelocation = resource + "/wwwroot/refrencephotos/" + imagename;
                    var stream = new FileStream(savelocation, FileMode.Create);
                    await p.Image.CopyToAsync(stream);
                    refrence.ImageUrll = imagename;
                }

                refrence.ClientName = p.NameSurname;
                refrence.Company = p.company;
                refrence.Comment = p.comment;
                refrence.Active = false;
                tm.TAdd(refrence);
                TempData["refrencesuccess"] = "İşlem başarılı. Referansınız onaylandığında anasayfa'da görebilirsiniz.";
                return RedirectToAction("Index", "Dashboard");
            }

            return View(p);
            
        }
    }
}
