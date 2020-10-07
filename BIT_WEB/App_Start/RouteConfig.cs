using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace BIT_WEB
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            
            routes.MapRoute(
              "Login",
              "Login/Login",
              new { controller = "Login", action = "Login" }
            );

            routes.MapRoute(
             "principal",
             "principal",
             new { controller = "Home", action = "Index", id = UrlParameter.Optional }
           );


            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Login", action = "SignIn", id = UrlParameter.Optional }
            );
        }
    }
}
