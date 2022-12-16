using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asp_Core_Proje.Areas.Writer.Controllers
{
    [Area("Writer")]
    [Route("Writer/Message")]
    public class MessageController : Controller
    {
        WriterMessageManager _writerMessageManager = new WriterMessageManager(new EfWriterMessageDal());

        private readonly UserManager<WriterUser> _userManger;

        public MessageController(UserManager<WriterUser> userManger)
        {
            _userManger = userManger;
        }

        [Route("")]
        [Route("Index")]
        public async Task<IActionResult> Index(string p)
        {
            var user = await _userManger.FindByNameAsync(User.Identity.Name);
            p = user.Email;
            var InBox = _writerMessageManager.GetListInBox(p);
            return View(InBox);
        }

        [Route("")]
        [Route("SendBox")]
        public async Task<IActionResult> SendBox(string p)
        {
            var user = await _userManger.FindByNameAsync(User.Identity.Name);
            p = user.Email;
            var SendBox = _writerMessageManager.GetListSendBox(p);
            return View(SendBox);
        }

        [HttpGet]
        [Route("")]
        [Route("SendMessage")]
        public IActionResult SendMessage()
        {
            return View();
        }

        [HttpPost]
        [Route("")]
        [Route("SendMessage")]
        public async Task<IActionResult> SendMessage(WriterMessage m)
        {
            var user = await _userManger.FindByNameAsync(User.Identity.Name);
            m.Sender = user.Email;
            m.SenderName = user.Name + " " + user.Surname;
            m.Date = DateTime.Now;
            Context c = new Context();
            var receiverName = c.Users.Where(u => u.Email == m.Receiver).Select(r => r.Name + " " + r.Surname).FirstOrDefault();
            m.ReceiverName = receiverName;
            _writerMessageManager.TAdd(m);
            return RedirectToAction("SendBox");
        }
        [Route("MessageDetails/{id}")]
        public IActionResult MessageDetails(int id)
        {
            var value = _writerMessageManager.TGetByID(id);
            return View(value);
        }
        [Route("MessageDetailsSendBox/{id}")]
        public IActionResult MessageDetailsSendBox(int id)
        {
            var value = _writerMessageManager.TGetByID(id);
            return View(value);
        }

    }
}
