using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIT_MODEL
{
    public class CarteiraModel
    {
        private int idCart;
        private int idUsercart;
        private int moedaCart;
        private decimal saldoCart;

        public int IdCart { get => idCart; set => idCart = value; }
        public int IdUsercart { get => idUsercart; set => idUsercart = value; }
        public int MoedaCart { get => moedaCart; set => moedaCart = value; }
        public decimal SaldoCart { get => saldoCart; set => saldoCart = value; }
    }
}
