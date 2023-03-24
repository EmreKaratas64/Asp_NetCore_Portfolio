using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
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
    [Authorize(Roles ="Admin")]
    public class AdminMessageController : Controller
    {
        WriterMessageManager writerMessageManager = new WriterMessageManager(new EfWriterMessageDal());

        private readonly UserManager<WriterUser> _userManger;

        public AdminMessageController(UserManager<WriterUser> userManger)
        {
            _userManger = userManger;
        }

        public IActionResult ReceiverMessageList()
        {
            string p = "admin@gmail.com";
            var values = writerMessageManager.GetListInBox(p);
            return View(values);
        }

        public IActionResult SenderMessageList()
        {
            string p = "admin@gmail.com";
            var values = writerMessageManager.GetListSendBox(p);
            return View(values);
        }

        public IActionResult DeleteAdminMessage(int id)
        {
            var value = writerMessageManager.TGetByID(id);
            writerMessageManager.TDelete(value);
            if (value.Sender == "admin@gmail.com")
            {
                return RedirectToAction("SenderMessageList");
            }
            else
            {
                return RedirectToAction("ReceiverMessageList");
            }
        }

        public IActionResult ShowReceiverMessage(int id)
        {
            var value = writerMessageManager.TGetByID(id);
            return View(value);
        }

        public IActionResult ShowSenderMessage(int id)
        {
            var value = writerMessageManager.TGetByID(id);
            return View(value);
        }

        [HttpGet]
        public IActionResult NewMessage()
        {
            return View();
        }

        [HttpPost]
        public IActionResult NewMessage(WriterMessage p)
        {
            Context c = new Context();
            var receiverName = c.Users.Where(u => u.Email == p.Receiver).Select(r => r.Name + " " + r.Surname).FirstOrDefault();
            p.ReceiverName = receiverName;
            p.Date = DateTime.Parse(DateTime.Now.ToShortDateString());
            p.Sender = "admin@gmail.com";
            p.SenderName = "Admin";
            writerMessageManager.TAdd(p);
            return RedirectToAction("SenderMessageList");
        }
    }
}
