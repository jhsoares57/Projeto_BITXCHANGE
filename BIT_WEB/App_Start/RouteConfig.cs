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
              "Deposito",
              "Deposito/Deposito/{id}",
              new { controller = "Deposito", action = "Deposito", id = UrlParameter.Optional }
            );

            routes.MapRoute(
              "DepositoBoleto",
              "DepositoBoleto/{id}",
              new { controller = "Deposito", action = "DepositoBoleto", id = UrlParameter.Optional }
            );
            routes.MapRoute(
              "DepositoCartao",
              "DepositoCartao/{id}",
              new { controller = "Deposito", action = "DepositoCartao", id = UrlParameter.Optional }
            );

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
            "Cambio",
            "Cambio/{id}",
            new { controller = "Cambio", action = "Cambio", id = 1 }
          );

            routes.MapRoute(
           "Converter",
           "Cambio/{id}/Cambio",
           new { controller = "Cambio", action = "Converter", id = UrlParameter.Optional}
         );

            routes.MapRoute(
           "RecuperacaoSenha",
           "RecuperacaoSenha",
           new { controller = "Recuperacao", action = "RecuperacaoSenha" }
         );
            routes.MapRoute(
           "RecuperarSenha",
           "RecuperarSenha",
           new { controller = "Recuperacao", action = "alterarSenha" }
         );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Login", action = "SignIn", id = UrlParameter.Optional }
            );
        }
    }
}
