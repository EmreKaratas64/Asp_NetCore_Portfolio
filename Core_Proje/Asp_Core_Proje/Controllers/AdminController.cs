using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asp_Core_Proje.Controllers
{
    public class AdminController : Controller
    {
        public PartialViewResult NewNavigationPartial()
        {
            return PartialView();
        }
    }
}
