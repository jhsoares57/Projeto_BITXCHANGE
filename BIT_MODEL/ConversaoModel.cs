using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIT_MODEL
{
    public class ConversaoModel
    {
        private int idConversao;
        private int idUsurio;
        private int moedaOrigem;
        private int moedaFim;
        private decimal valorInicio;
        private decimal valorFinal;
        private string protocolo;
        private DateTime data;

        public int IdConversao { get => idConversao; set => idConversao = value; }
        public int IdUsurio { get => idUsurio; set => idUsurio = value; }
        public int MoedaOrigem { get => moedaOrigem; set => moedaOrigem = value; }
        public int MoedaFim { get => moedaFim; set => moedaFim = value; }
        public decimal ValorInicio { get => valorInicio; set => valorInicio = value; }
        public decimal ValorFinal { get => valorFinal; set => valorFinal = value; }
        public string Protocolo { get => protocolo; set => protocolo = value; }
        public DateTime Data { get => data; set => data = value; }
    }
}
