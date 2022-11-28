using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace SubhasmitaPortfolio
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );

            routes.MapRoute(
               name: "Education",
               url: "{controller}/{action}",
               defaults: new { controller = "Education", action = "Education" }
           );

            routes.MapRoute(
                name: "Skills",
                url: "{controller}/{action}",
                defaults: new { controller = "Skills", action = "Skills", id = UrlParameter.Optional }
            );

            routes.MapRoute(
               name: "Experience",
               url: "{controller}/{action}",
               defaults: new { controller = "Experience", action = "Experience", id = UrlParameter.Optional }
           );

            routes.MapRoute(
                name: "Hobbies",
                url: "{controller}/{action}",
                defaults: new { controller = "Hobbies", action = "Hobbies", id = UrlParameter.Optional }
            );
        }
    }
}
