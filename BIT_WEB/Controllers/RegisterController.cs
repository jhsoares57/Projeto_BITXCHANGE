using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BIT_MODEL;
using BIT_BLL;
using BIT_CRIPTOGRAFIA;


namespace BIT_WEB.Controllers
{
    //[System.Web.Mvc.Authorize]
    public class RegisterController : Controller
    {
        private UsuarioBLL repository = new UsuarioBLL();

        public ActionResult SignUp()
        {
            return View();
        }

        [HttpPost]
        public ActionResult SignUp(UsuarioModel U)
        {
            try
            {

                U.Nome = Request["name"] + " " + Request["last-name"];
                U.Email = Request["email"];
                U.Cpf = Request["number-doc"];
                U.DataNascimento = Convert.ToDateTime(Request["birth"]);
                //U.Sexo = Convert.ToInt32(Request["gender"]);
                
                if(Request["password"] == Request["vf-password"])
                {
                    U.Senha = Criptografia.GerarMD5(Request["password"]);
                }
                else
                {
                    TempData["alerta"] = "Senhas não conferem!";
                    return RedirectToRoute("Register");
                }
                
                U.Status = 1;
                U.Tipo = 2;
                U.DataCadastro = DateTime.Now;

                if (Request["gender"] == "masculino")
                {
                    U.Sexo = 1;
                }
                if (Request["gender"] == "feminino")
                {
                    U.Sexo = 2;
                }
                else
                {
                    U.Sexo = 3;
                }

                if (ModelState.IsValid)
                {
                    repository.Insert(U);
                    return RedirectToRoute("SignIn");
                }
                else
                {
                    return RedirectToRoute("Register");
                }

            }
            catch (Exception)
            {

                throw;
            }

        }

    }

}
