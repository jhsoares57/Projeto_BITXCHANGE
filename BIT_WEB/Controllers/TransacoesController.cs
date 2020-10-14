using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BIT_WEB.Controllers
{
    public class TransacoesController : Controller
    {
        public void Cotacao()
        {
            var cotacao = new CotacaoBLL();
            var CotDolar = cotacao.LevantarCotacao(1);
            var CotReal = cotacao.LevantarCotacao(2);
            var CotETH = cotacao.LevantarCotacao(3);
            var CotBit = cotacao.LevantarCotacao(4);

            ViewBag.CotDolar = CotDolar;
            ViewBag.Cotreal = CotReal;
            ViewBag.CotETH = CotETH;
            ViewBag.CotBit = CotBit;
        }

        public ActionResult Transacoes()
        {
            return View();
        }
    }
}
