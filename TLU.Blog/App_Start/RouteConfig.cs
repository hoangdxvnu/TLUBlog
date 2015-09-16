using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace TLU.Blog
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Admin",
                url: "Admin",
                defaults: new { controller = "AdminHome", action = "Home"}
            );

            routes.MapRoute(
                name: "Home",
                url: "{action}",
                defaults: new { controller = "Home", action = "Index" }
            );
            
            routes.MapRoute(
                name: "LogIn",
                url: "LogIn",
                defaults: new { controller = "AdminLogIn", action = "LogIn" }
            );
            

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );

        }
    }
}
