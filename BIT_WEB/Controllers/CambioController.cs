using BLL;
using BIT_LOGIN.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BIT_MODEL;
using BIT_PROTOCOLO;
using BIT_BLL;

namespace BIT_WEB.Controllers
{
    //[System.Web.Mvc.Authorize]
    public class CambioController : Controller
    {
        // GET: Cambio
        public ActionResult Cambio(int ID)
        {
            var User = new UsuarioBLL();
            var home = User.SelecionarPorID(ID);
            ViewBag.Home = home;
            //Cotação
            var cotacao = new CotacaoBLL();
            var CotDolar = cotacao.LevantarCotacao(1);
            var CotETH = cotacao.LevantarCotacao(3);
            var CotBit = cotacao.LevantarCotacao(4);
            ViewBag.CotDolar = CotDolar;
            ViewBag.CotETH = CotETH;
            ViewBag.CotBit = CotBit;

            return View();
        }

        [HttpPost]
        public void Converter(int ID)
        {
            try
            {

                var prot = new GerarProtocolo();
                var moedaInicial = Request["type-coin"];
                var valorInicial = Request["value"];
                var ValorFinal = Request["fvalue"];

                int moedain = 0;


                if (moedaInicial == "ethereum")
                {
                    moedain = 3;
                }
                else if (moedaInicial == "real")
                {
                    moedain = 2;
                }
                else if (moedaInicial == "dolar")
                {
                    moedain = 4;
                }
                else
                {
                    moedain = 1;
                }

                var conversaoModel = new ConversaoModel();
                var conversalBLL = new ConversaoBLL();
                DateTime data = DateTime.Today;

                if (Request["type-fcoin"] == "dolar")
                {

                    conversaoModel.IdUsurio = 1;
                    conversaoModel.MoedaOrigem = moedain;
                    conversaoModel.ValorInicio = Convert.ToDecimal(valorInicial);
                    conversaoModel.MoedaFim = 4;
                    conversaoModel.ValorFinal = Convert.ToDecimal(ValorFinal);
                    conversaoModel.Protocolo = prot.Protocolo();
                    conversaoModel.Data = data;



                    conversalBLL.InserirConversao(conversaoModel);

                }
                else if (Request["type-fcoin"] == "real")
                {
                    conversaoModel.IdUsurio = 1;
                    conversaoModel.MoedaOrigem = moedain;
                    conversaoModel.ValorInicio = Convert.ToDecimal(valorInicial);
                    conversaoModel.MoedaFim = 2;
                    conversaoModel.ValorFinal = Convert.ToDecimal(ValorFinal);
                    conversaoModel.Protocolo = prot.Protocolo();
                    conversaoModel.Data = data;

                    conversalBLL.InserirConversao(conversaoModel);


                }
                else if (Request["type-fcoin"] == "ethereum")
                {
                    conversaoModel.IdUsurio = 1;
                    conversaoModel.MoedaOrigem = moedain;
                    conversaoModel.ValorInicio = Convert.ToDecimal(valorInicial);
                    conversaoModel.MoedaFim = 4;
                    conversaoModel.ValorFinal = Convert.ToDecimal(ValorFinal);
                    conversaoModel.Protocolo = prot.Protocolo();
                    conversaoModel.Data = data;

                    conversalBLL.InserirConversao(conversaoModel);


                }
                else
                {
                    conversaoModel.IdUsurio = ID;
                    conversaoModel.MoedaOrigem = moedain;
                    conversaoModel.ValorInicio = Convert.ToDecimal(valorInicial);
                    conversaoModel.MoedaFim = 1;
                    conversaoModel.ValorFinal = Convert.ToDecimal(ValorFinal);
                    conversaoModel.Protocolo = prot.Protocolo();
                    conversaoModel.Data = data;

                    conversalBLL.InserirConversao(conversaoModel);

                }

                TempData["Sucesss"] = "Protocolo gerado: " + conversaoModel.Protocolo;

            }
            catch (Exception)
            {

                TempData["err"] = "Erro ao gerar conversão";
            }
            Response.Redirect("/Cambio/" + ID);
        }
    }
}