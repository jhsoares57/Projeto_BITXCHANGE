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
              "SignIn",
              "Login/SignIn",
              new { controller = "Login", action = "SignIn" }
            );

            routes.MapRoute(
              "Register",
              "Register/SignUp",
              new { controller = "Register", action = "SignUp" }
            );

            routes.MapRoute(
              "Login",
              "Login/Login",
              new { controller = "Login", action = "Login" }
            );

            routes.MapRoute(
             "principal",
             "principal/{id}",
             new { controller = "Home", action = "Index", id = UrlParameter.Optional }
           );

            routes.MapRoute(
             "transacoes",
             "transacoes/{id}",
             new { controller = "Transacoes", action = "Transacoes", id = UrlParameter.Optional }
           );

            routes.MapRoute(
            "Transferencia",
            "Transferencia/{id}",
            new { controller = "Transferencia", action = "Transferencia", id = UrlParameter.Optional }
          );
            routes.MapRoute(
            "Transferir",
            "Transferencia/{id}/Transferir",
            new { controller = "Transferencia", action = "Transferir", id = UrlParameter.Optional }
          );


            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Login", action = "SignIn", id = UrlParameter.Optional }
            );
        }
    }
}
