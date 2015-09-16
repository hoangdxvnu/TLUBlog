using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TLU.Blog.Helpers;
namespace TLU.Blog.AdminControllers
{
    public class AdminBaseController : Controller
    {
        private const string ACCOUNT_ADMIN = "AccountAdmin";
        // GET: AdminBase
        protected override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            if(HttpContext.Session[ACCOUNT_ADMIN]==null)
            {
                filterContext.Result = new RedirectToRouteResult(new System.Web.Routing.RouteValueDictionary((new { controller = "AdminLogIn", action = "logIn" })));
            }
            base.OnActionExecuting(filterContext);
        }
    }
}