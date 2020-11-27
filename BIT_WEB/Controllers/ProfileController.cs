using BIT_BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BIT_MODEL;
using BIT_CRIPTOGRAFIA;

namespace BIT_WEB.Controllers
{
    public class ProfileController : Controller
    {
        private UsuarioBLL repository = new UsuarioBLL();

        // GET: Profile
        public ActionResult Perfil(int ID)
        {
            //Buscando dados do UsuarioBLLrio logado
            //int ID = 1;
            var User = new UsuarioBLL();
            var home = User.SelecionarPorID(ID);
            ViewBag.Home = home;

            var perfilUser = new UsuarioBLL();

            ViewBag.perfil = perfilUser.SelecionarPorID(ID);
            
            return View();
        }

        [HttpPost]
        public void Perfil(int ID, UsuarioModel usuModel)
        {

            var nome = Request["new-name"];
            var email = Request["new-email"];
            var senha = Request["new-pass"];
            var vfsenha = Request["vf-pass"];
            var genero = Request["new-gender"];

            var perfilUser = new UsuarioBLL();
            ViewBag.perfil = perfilUser.SelecionarPorID(ID);
            BIT_MODEL.UsuarioModel perfilDados = ViewBag.Perfil;

            if (nome == "" && email == "" && senha == "" && vfsenha == "" && genero == null) 
            {
                TempData["erro"] = "Erro: Nenhum campo foi preenchido!";
                Response.Redirect("/Profile/Perfil/" + ID);
            }
            else
            if(senha != vfsenha)
            {
                TempData["erro"] = "Erro: Senhas não conferem!";
                Response.Redirect("/Profile/Perfil/" + ID);
            }
            else
            {
                try
                {
                    usuModel.Id = ID;
                    usuModel.DataCadastro = perfilDados.DataCadastro;
                    usuModel.Status = perfilDados.Status;
                    usuModel.Tipo = perfilDados.Tipo;
                    usuModel.Cpf = perfilDados.Cpf;
                    usuModel.DataNascimento = perfilDados.DataNascimento;


                    if (nome != "")
                    {
                        usuModel.Nome = nome;
                    }
                    else
                    {
                        usuModel.Nome = perfilDados.Nome;
                    }

                    if (email != "")
                    {
                        usuModel.Email = email;
                    }
                    else
                    {
                        usuModel.Email = perfilDados.Email;
                    }

                    if (senha != "" && vfsenha != "" && vfsenha == senha)
                    {
                        usuModel.Senha = Criptografia.GerarMD5(senha);
                    }
                    else
                    {
                        usuModel.Senha = perfilDados.Senha;
                    }

                    if(genero != null)
                    {
                        if (genero == "m")
                        {
                            usuModel.Sexo = 1;
                        }
                        else
                        if (genero == "f")
                        {
                            usuModel.Sexo = 2;
                        }
                        else
                        {
                            usuModel.Sexo = 3;
                        }
                    }
                    else
                    {
                        usuModel.Sexo = perfilDados.Sexo;
                    }

                    

                    repository.AlterarUsuario(usuModel);
                    TempData["Sucesso1"] = "Perfil atualizado com sucesso!";
                    

                }
                catch (Exception ex)
                {
                    TempData["erro"] = "Erro: " + ex;
                }
                Response.Redirect("/Profile/Perfil/" + ID);
            }
        }

       
        // POST: Profile/Delete/5
        [HttpPost]
        public ActionResult Delete(int ID)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
