using BIT_CRIPTOGRAFIA;
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

        public ActionResult SignIn()
        {
            return View();
        }

        public ActionResult SignUp()
        {
            return View();
        }

        [HttpGet]
        [ValidateInput (false)]
        public void Login()
        {
            try
            {
                var login = new DadosLogin();
                var loginNeg = new LoginNeg();


                login.Email = Request["email"];
                login.Senha = Request["senha"];

                string senha = Criptografia.GerarMD5(login.Senha);

                if (loginNeg.FindByLogin(login.Email, senha).Tipo == 2)
                {
                  
                    Response.RedirectToRoute("principal");
                }
                else
                {
                    TempData["Erro"] = "Verifique seu usuário e senha!";
                    Response.Redirect("/Login");
                }
            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}