using BIT_DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class TransacaoBLL
    {
        private DateTime dataTransacao;
        private string tipo;
        private decimal valor;
        private string moeda;
        private string protocolo;

        public DateTime DataTransacao { get => dataTransacao; set => dataTransacao = value; }
        public string Tipo { get => tipo; set => tipo = value; }
        public decimal Valor { get => valor; set => valor = value; }
        public string Moeda { get => moeda; set => moeda = value; }
        public string Protocolo { get => protocolo; set => protocolo = value; }


        public DataTable ListarRelatorioTransacoes(DateTime DataInicial)
        {
            return new TransacaoDAL().ListarRelatorioTransacoes(DataInicial);
        }

        public DataTable ListarRelatorioTransacoesMensal(DateTime DataInicial, DateTime DataFinal)
        {
            return new TransacaoDAL().ListarRelatorioTransacoesMensal(DataInicial,DataFinal);
        }

        public DataTable ListarUltimasTransacoes()
        {
            return new TransacaoDAL().ListarUltimasTransacoesMensal();
        }

        public DataTable ListarExtratoUserBLL(int id)
        {
            return new TransacaoDAL().ListarExtratouserDAL(id);
        }

        public List<TransacaoBLL> Lista(int id)
        {

            var lista = new List<TransacaoBLL>();
            var TransaBD = new BIT_DAL.TransacaoDAL();

            foreach (DataRow row in TransaBD.Lista(id).Rows)
            {
                var transacaoMdel = new TransacaoBLL();
                transacaoMdel.DataTransacao = Convert.ToDateTime(row["DATA"]);
                transacaoMdel.Protocolo = row["PROTOCOLO"].ToString();
                transacaoMdel.Tipo = row["TIPO"].ToString();
                transacaoMdel.Valor = Convert.ToDecimal(row["VALOR"]);
                transacaoMdel.Moeda = row["MOEDA"].ToString();

                lista.Add(transacaoMdel);

            }
            return lista;
        }

    }
}
