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
        public void SignUp(UsuarioModel U)
        {
            try
            {
                var email = Request["email"];
                var cpf = Request["number-doc"];

                if (repository.ExisteCpf(cpf) == true)
                {
                    TempData["alerta"] = "CPF já cadastrado!";
                    Response.Redirect("/Register/SignUp");
                }
                else
                if (repository.ExisteEmail(email) == true)
                {
                    TempData["alerta"] = "E-mail já cadastrado!";
                    Response.Redirect("/Register/SignUp");
                }
                else
                if(Request["password"] != Request["vf-password"])
                {
                    TempData["alerta"] = "Senhas não conferem!";
                    Response.Redirect("/Register/SignUp");
                }
                else
                {
                //if (Request["password"] == Request["vf-password"])
               // {
                    U.Senha = Criptografia.GerarMD5(Request["password"]);
                    U.Nome = Request["name"] + " " + Request["last-name"];
                    U.Email = Request["email"];
                    U.Cpf = Request["number-doc"];
                    U.DataNascimento = Convert.ToDateTime(Request["birth"]);
                    U.Status = 1;
                    U.Tipo = 2;
                    U.DataCadastro = DateTime.Now;

                    if (Request["gender"] == "m")
                    {
                        U.Sexo = 1;
                    }
                    else
                    if (Request["gender"] == "f")
                    {
                        U.Sexo = 2;
                    }
                    else
                    {
                        U.Sexo = 3;
                    }

                    repository.Insert(U);
                    Response.Redirect("/Login/SignIn");
                }
            }
            catch (Exception ex)
            {
                TempData["erro"] = "Erro: " + ex;
            }

        }

    }

}
