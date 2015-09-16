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

        public ActionResult New()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Awnser()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult ChangeLanguage(string Id)
        {
            // vi
            TLUResourceManager.SetLanguage(Id);

            BlogLang.SetLanguage(Id);

            return RedirectToAction("Index");

        }
        public ActionResult NewPost()
        {
            return View();
        }

        public ActionResult Post()
        {

            return View();
        }

        public ActionResult ViewLike()
        {
            ViewBag.Votes = true;
            ViewBag.Like = 15;
            return View();
        }

        public ActionResult ViewComment(string pContent, int pId)
        {

            return View();
        }
    }
}