using BIT_PROTOCOLO;
using BIT_LOGIN.Model;
using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BIT_MODEL;
using BIT_BLL;

namespace BIT_WEB.Controllers
{
    //[System.Web.Mvc.Authorize]
    public class TransferenciaController : Controller
    {
        // GET: Transferencia
        public ActionResult Transferencia(int ID)
        {

            var saldoUser = new CarteiraBLL();
            var User = new UsuarioBLL();
            var home = User.SelecionarPorID(ID);
            ViewBag.Home = home;

            ViewBag.SaldoBit = saldoUser.RetornaSaldoCartiraPorID(ID, 1);
            ViewBag.SaldoReal = saldoUser.RetornaSaldoCartiraPorID(ID, 2);
            ViewBag.SaldoEth = saldoUser.RetornaSaldoCartiraPorID(ID, 3);
            ViewBag.SaldoDolar = saldoUser.RetornaSaldoCartiraPorID(ID, 4);

            return View();
        }

        [HttpPost]
        public void Transferir(int ID)
        {
            try
            {
                var transferenciaModel = new TransacaoModel();
                DateTime data = DateTime.Today;

                var prot = new GerarProtocolo();
                //var idUser = Request[""];
                var NomeDestinatario = Request["name-receiver"];
                var DocumentoDestinatario = Request["document-receiver"];
                var DescricaoTransaferencia = Request["description"];
                var DescricaoConcatenada = "CPF destinatario: " + DocumentoDestinatario + "\nNome Destinatario: " + NomeDestinatario + "\nObservação: " + DescricaoTransaferencia;

                decimal valorc = Convert.ToDecimal(Request["Value-end"]);
                transferenciaModel.Valor = valorc;
                transferenciaModel.Moeda = Request["type-coin"];
                transferenciaModel.Protocolo = prot.Protocolo();
                transferenciaModel.Usuario = ID;
                transferenciaModel.DataTransacao = data;
                transferenciaModel.Descricao = DescricaoConcatenada;
                var ValorFinalTransferencia = Request["Value-end"];

                var transacaoBLL = new TransacaoBLL();

                transacaoBLL.InserirTransaferencia(transferenciaModel);

                TempData["Sucesso_"] = "Protocolo gerado: "+ transferenciaModel.Protocolo;
                

            }
            catch (Exception ex)
            {

                TempData["erro_"] = "Erro: " + ex;
            }

            Response.Redirect("/Transferencia/" + ID);

        }

        // GET: Transferencia/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Transferencia/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Transferencia/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Transferencia/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Transferencia/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Transferencia/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
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
