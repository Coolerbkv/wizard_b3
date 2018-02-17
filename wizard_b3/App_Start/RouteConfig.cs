using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Routing;
using System.Web.Http;
using System.Web.Mvc;

namespace wizard_b3.App_Start
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Application",
                url: "{*url}",
                defaults: new { controller = "Home", action = "Index" },
                namespaces: new[] { "wizard_b3.API.Controllers" }
            );
        }
    }
}