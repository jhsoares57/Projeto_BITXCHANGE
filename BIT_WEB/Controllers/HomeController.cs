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

        public ActionResult Index(int ID)
        {
            //Buscando dados do UsuarioBLLrio logado
            //int ID = 1;
            var User = new UsuarioBLL();
            var home = User.SelecionarPorID(ID);
            ViewBag.Home = home;

            //Levantando o valor da cotação para cada moeda
            var cotacao = new CotacaoBLL();
            var CotDolar = cotacao.LevantarCotacao(1);
            var CotReal = cotacao.LevantarCotacao(2);
            var CotETH = cotacao.LevantarCotacao(3);
            var CotBit = cotacao.LevantarCotacao(4);

            //atribuindo o valor retornada da cotaçã
            ViewBag.CotDolar = CotDolar;
            ViewBag.Cotreal = CotReal;
            ViewBag.CotETH = CotETH;
            ViewBag.CotBit = CotBit;

            
            //Listando as ultimas transações do usuário
            ViewBag.Transacoes = new TransacaoBLL().Lista(ID);

            //Buscando o saldo da carteira do usuario

            var saldoUser = new CarteiraBLL();

            ViewBag.SaldoBit = saldoUser.RetornaSaldoCartiraPorID(ID, 1);
            ViewBag.SaldoReal = saldoUser.RetornaSaldoCartiraPorID(ID, 2);
            ViewBag.SaldoEth = saldoUser.RetornaSaldoCartiraPorID(ID, 3);
            ViewBag.SaldoDolar = saldoUser.RetornaSaldoCartiraPorID(ID, 4);

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