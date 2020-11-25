using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BIT_MODEL;
using BIT_BLL;
using BIT_CRIPTOGRAFIA;
using BLL;
using BIT_PROTOCOLO;

namespace BIT_WEB.Controllers
{
    public class DepositoController : Controller
    {
        private DepositoBLL repository = new DepositoBLL();
        // GET: Deposito
        public ActionResult Deposito(int ID)
        {
            var User = new UsuarioBLL();
            var home = User.SelecionarPorID(ID);
            ViewBag.Home = home;
            return View();
        }

        [HttpPost]
        public void DepositoCartao(int ID)
        {
            try
            {
                var D = new DepositoModel();
                var prot = new GerarProtocolo();
                var userId = ID;
                decimal valorDeposito = Convert.ToDecimal(Request["value-deposit"]);

                D.Titular = Request["cardholder-name"];
                D.NumCartao = Request["card-number"];
                D.Valor = valorDeposito;
                D.Cvv = Request["cvv"];
                D.DataVencimento = Convert.ToDateTime(Request["expiration-date"]);
                D.DataPagamento = DateTime.Today;
                D.Tipo = 2;
                D.Status = "F";
                D.Protocolo = prot.Protocolo();
                D.Id = userId;

                repository.depositoCartao(D);
                TempData["Sucesso1"] = "Protocolo gerado: " + D.Protocolo;

            }
            catch (Exception ex)
            {
                TempData["erro"] = "Erro: " + ex;
            }
            Response.Redirect("/Deposito/Deposito/"+ID);
        }

        [HttpPost]
        public void DepositoBoleto(int ID)
        {
            try
            {
                var D = new DepositoModel();
                var prot = new GerarProtocolo();
                var userId = ID;
                decimal valorDeposito = Convert.ToDecimal(Request["value-deposit"]);
                DateTime pag = Convert.ToDateTime(Request["date-payment"]);

                D.Titular = Request["fullname"];
                D.Valor = valorDeposito;
                D.DataVencimento = pag.AddDays(1);
                D.DataPagamento = pag;
                D.Tipo = 1;
                D.Status = "F";
                D.Protocolo = prot.Protocolo();
                D.NumBoleto = prot.Boleto();
                D.Id = userId;

                repository.depositoBoleto(D);
                TempData["Sucesso1"] = "Protocolo gerado: " + D.Protocolo;
                TempData["Sucesso2"] = "Código de barras do boleto: " + D.NumBoleto;

            }
            catch (Exception ex)
            {
                TempData["erro"] = "Erro: " + ex;
            }
            Response.Redirect("/Deposito/Deposito/" + ID);
        }

    }
}
