using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using TLU.Blog.Data;
using TLU.Blog.Helpers;

namespace TLU.Blog.Controllers
{
    public class BaseController : Controller
    {

        public ThangLongEntities _db = new ThangLongEntities();

        protected override void Initialize(System.Web.Routing.RequestContext requestContext)
        {
            ViewBag.Navigation = _db.Navigations.Where(x=>x.LangId==Blog.Helpers.BlogLang.CurrentLang).OrderBy(x => x.OrderDisplay).ToList();

            ViewBag.Sologan = _db.Configs.Where(x=>x.LangId==BlogLang.CurrentLang).Where(x => x.Code == "Banner").ToList();
         
            base.Initialize(requestContext);
        }


        public string GetCurrentAction
        {
            get
            {
                var currenController = ControllerContext.RouteData;

                var stringBulder = new StringBuilder();

                stringBulder.AppendLine(string.Format("{0}/{1}", currenController.GetRequiredString("controller"), currenController.GetRequiredString("action")));

                return stringBulder.ToString();
            }

            set
            {
                GetCurrentAction = value;
            }
        }
	}
}