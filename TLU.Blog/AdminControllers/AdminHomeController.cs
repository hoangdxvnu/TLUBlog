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
        public ActionResult LogOut()
        {
            const string ACCOUNT_ADMIN = "AccountAdmin";
            HttpContext.Session.Remove(ACCOUNT_ADMIN);
            return RedirectToAction("LogIn", "AdminLogIn");
        }
    }
}