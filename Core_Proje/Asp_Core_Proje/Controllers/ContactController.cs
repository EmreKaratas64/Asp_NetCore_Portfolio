using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asp_Core_Proje.Controllers
{
    [Authorize(Roles = "Admin")]
    public class ContactController : Controller
    {
        MessageManager messageManager = new MessageManager(new EfMessageDal());

        public IActionResult Index()
        {
            var values = messageManager.TGetList();
            return View(values);
        }

        public IActionResult DeleteContactMessage(int id)
        {
            var contactmessage = messageManager.TGetByID(id);
            messageManager.TDelete(contactmessage);
            return RedirectToAction("Index");
        }

        public IActionResult ShowContactMessage(int id)
        {
            var contactmessage = messageManager.TGetByID(id);
            return View(contactmessage);
        }
    }
}
