using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TLU.Blog.AdminControllers
{
    public class AdminHomeController : AdminBaseController
    {
        // GET: AdminHome
        public ActionResult Home()
        {
            return View();
        }
    }
}