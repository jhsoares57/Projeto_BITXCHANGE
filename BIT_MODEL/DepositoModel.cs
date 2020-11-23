using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIT_MODEL
{
    public class DepositoModel
    {
        private int id;
        private int tipo;
        private string titular;
        private DateTime dataVencimento;
        private string numCartao;
        private string cvv;
        private DateTime dataPagamento;
        private decimal valor;
        private string status;
        private int carteira;
        private string protocolo;

        public int Id { get => id; set => id = value; }
        public int Tipo { get => tipo; set => tipo = value; }
        public string Titular { get => titular; set => titular = value; }
        public DateTime DataVencimento { get => dataVencimento; set => dataVencimento = value; }
        public string NumCartao { get => numCartao; set => numCartao = value; }
        public string Cvv { get => cvv; set => cvv = value; }
        public DateTime DataPagamento { get => dataPagamento; set => dataPagamento = value; }
        public decimal Valor { get => valor; set => valor = value; }
        public string Status { get => status; set => status = value; }
        public int Carteira { get => carteira; set => carteira = value; }
        public string Protocolo { get => protocolo; set => protocolo = value; }
    }
}
