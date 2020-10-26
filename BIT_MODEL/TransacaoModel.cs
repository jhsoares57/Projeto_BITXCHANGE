using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIT_MODEL
{
    public class TransacaoModel
    {
        private DateTime dataTransacao;
        private string tipo;
        private decimal valor;
        private string moeda;
        private string protocolo;
        private int usuario;
        private string descricao;
        private int id;

        public DateTime DataTransacao { get => dataTransacao; set => dataTransacao = value; }
        public string Tipo { get => tipo; set => tipo = value; }
        public decimal Valor { get => valor; set => valor = value; }
        public string Moeda { get => moeda; set => moeda = value; }
        public string Protocolo { get => protocolo; set => protocolo = value; }
        public int Usuario { get => usuario; set => usuario = value; }
        public string Descricao { get => descricao; set => descricao = value; }
        public int Id { get => id; set => id = value; }
    }
}
