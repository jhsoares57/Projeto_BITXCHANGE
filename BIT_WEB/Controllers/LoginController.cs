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
        //[Authorize]
        public RedirectToRouteResult Login()
        {
            try
            {

                var loginNeg = new LoginNeg();


                var Email = Request["email"];
                var Senha = Request["senha"];

                string senha = Criptografia.GerarMD5(Senha);

                var result = loginNeg.FindByLogin(Email, senha);

                if(result.Tipo == 2)
                {
                    return RedirectToRoute("principal", new { id = result.Id });
                    
                }
                else
                {
                    TempData["erro"] = "Verifique seu usuário e senha!";
                    return RedirectToActionPermanent("");

                    // Login
                }

            }
            catch (Exception ex)
            {

                TempData["erro"] = "Erro: "+ex;
                return RedirectToRoute("");
            }

        }
    }
}