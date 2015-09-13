using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TLU.Blog.Helpers;

namespace TLU.Blog.Controllers
{
    public class HomeController : BaseController
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult ChangeLanguage(string Id)
        {
            // vi
            TLUResourceManager.SetLanguage(Id);

            BlogLang.SetLanguage(Id);

            return RedirectToAction("Index");

        }
    }
}