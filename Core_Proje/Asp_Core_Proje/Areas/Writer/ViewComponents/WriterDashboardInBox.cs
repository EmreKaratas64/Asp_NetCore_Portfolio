using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asp_Core_Proje.Areas.Writer.ViewComponents
{
    public class WriterDashboardInBox : ViewComponent
    {
        WriterMessageManager writerMessageManager = new WriterMessageManager(new EfWriterMessageDal());

        private readonly UserManager<WriterUser> _userManger;

        public WriterDashboardInBox(UserManager<WriterUser> userManger)
        {
            _userManger = userManger;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var user = await _userManger.FindByNameAsync(User.Identity.Name);
            string p = user.Email;
            var InBox = writerMessageManager.GetListInBox(p).OrderByDescending(m => m.WriterMessageID).Take(7).ToList();
            return View(InBox);
        }
    }
}
