using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TLU.Blog.AdminControllers
{
    public class AdminAboutController : Controller
    {
        // GET: AdminAbout
        public ActionResult Index()
        {
            return View();
        }

        // GET: AdminAbout/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: AdminAbout/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AdminAbout/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: AdminAbout/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: AdminAbout/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: AdminAbout/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: AdminAbout/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
