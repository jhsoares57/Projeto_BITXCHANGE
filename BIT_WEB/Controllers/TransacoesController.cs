using BIT_BLL;
using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BIT_WEB.Controllers
{
    //[System.Web.Mvc.Authorize]
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

        public ActionResult Transacoes(int ID)
        {
         
            //Listando as ultimas transações do usuário
            ViewBag.Transacoes = new TransacaoBLL().ListaTodasTransacoes(ID);
            var User = new UsuarioBLL();
            var home = User.SelecionarPorID(ID);
            ViewBag.Home = home;

            return View();
        }
    }
}
