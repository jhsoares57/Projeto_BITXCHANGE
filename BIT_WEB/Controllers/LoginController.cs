using BIT_LOGIN.Model;
using BIT_LOGIN.Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BIT_WEB.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public void Login()
        {
            var login = new DadosLogin();
            var loginNeg = new LoginNeg();

            login.Email = Request["email"];
            login.Senha = Request["senha"];

            loginNeg.FindByLogin(login.Email, login.Senha);
            Response.Redirect("/SignUp");
        }
    }
}