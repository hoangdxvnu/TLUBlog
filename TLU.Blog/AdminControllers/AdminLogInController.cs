using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TLU.Blog.AdminControllers
{
    public class AdminLogInController : Controller
    {
        // GET: AdminLogIn
        public ActionResult logIn()
        {
            return View();
        }
        // POST
        [HttpPost]
        public ActionResult logIn(string UserName,string Password)
        {
            const string ACCOUNT_ADMIN = "AccountAdmin";
            if (UserName=="admin"&&Password=="123")
            {
                Helpers.BlogCookies.AddCookie("Nguyen Van Kinh", ACCOUNT_ADMIN);
                return RedirectToAction("Home", "AdminHome");
            }
            return View();
        }
    }
}