using BIT_BLL;
using BIT_CRIPTOGRAFIA;
using BIT_MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BIT_WEB.Controllers
{
    public class RecuperacaoController : Controller
    {
        // GET: Recuperacao
        public ActionResult RecuperacaoSenha()
        {
            return View();
        }

        public void alterarSenha()
        {
            try
            {
                var usuarioBLL = new UsuarioBLL();
                var usuarioModel = new UsuarioModel();

                var email = Request["email"];
                var senha = Request["nova-senha"];
                var vfsenha = Request["conf-senha"];

                if (senha != vfsenha)
                {
                    TempData["UsuarioErro"] = "Senhas não conferem!";
                    Response.Redirect("/RecuperacaoSenha");
                }
                else
                {
                    string senhaCript = Criptografia.GerarMD5(senha);

                    usuarioModel.Email = email;
                    usuarioModel.Senha = senhaCript;

                    if (usuarioBLL.alterarSenha(usuarioModel) == true)
                    {
                        TempData["UsuarioAlterado"] = "Senha Alterada com sucesso";
                    }
                    else
                    {
                        TempData["UsuarioNaoAletarado"] = "Usuário não encontrato!";
                    }
                }
            }
            catch (Exception ex)
            {

                TempData["UsuarioErro"] = "erro: " + ex;
            }
            Response.Redirect("/Login/SignIn");
        }
    }
}