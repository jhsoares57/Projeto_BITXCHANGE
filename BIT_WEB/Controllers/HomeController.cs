using BIT_BLL;
using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BIT_WEB.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            int ID = 1;
            var User = new UsuarioBLL();
            var home = User.SelecionarPorID(ID);
            var cotacao = new CotacaoBLL();
            var CotDolar = cotacao.LevantarCotacao(1);
            var CotReal = cotacao.LevantarCotacao(2);
            var CotETH = cotacao.LevantarCotacao(3);
            var CotBit = cotacao.LevantarCotacao(4);

            ViewBag.CotDolar = CotDolar;
            ViewBag.Cotreal = CotReal;
            ViewBag.CotETH = CotETH;
            ViewBag.CotBit = CotBit;

            ViewBag.Home = home;

            ViewBag.Transacoes = new TransacaoBLL().Lista(ID);

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


        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}