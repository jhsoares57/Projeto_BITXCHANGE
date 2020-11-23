using BIT_DAL;
using BIT_MODEL;
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
        private string nome;
        private string obs;

        public DateTime DataTransacao { get => dataTransacao; set => dataTransacao = value; }
        public string Tipo { get => tipo; set => tipo = value; }
        public decimal Valor { get => valor; set => valor = value; }
        public string Moeda { get => moeda; set => moeda = value; }
        public string Protocolo { get => protocolo; set => protocolo = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Obs { get => obs; set => obs = value; }

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

        public List<TransacaoBLL> ListaTodasTransacoes(int id)
        {

            var list = new List<TransacaoBLL>();
            var Trans = new BIT_DAL.TransacaoDAL();

            foreach (DataRow row in Trans.ListaTodasTransacoes(id).Rows)
            {
                var transacaoMdel = new TransacaoBLL();
                transacaoMdel.DataTransacao = Convert.ToDateTime(row["DATA"]);
                transacaoMdel.Protocolo = row["PROTOCOLO"].ToString();
                transacaoMdel.Tipo = row["TIPO"].ToString();
                transacaoMdel.Valor = Convert.ToDecimal(row["VALOR"]);
                transacaoMdel.Moeda = row["MOEDA"].ToString();
                transacaoMdel.Nome = row["NOME"].ToString();
                transacaoMdel.Obs = row["OBSERVACAO"].ToString();

                list.Add(transacaoMdel);

            }
            return list;
        }

        public bool InserirTransaferencia(TransacaoModel T)
        {
            bool salvou = false;
            new TransacaoDAL().InserirTransaferencia(T);

            //Se o ID for maior que zero, indica que o dado foi salvo
            if (T.Id > 0)
            {
                salvou = true;
            }

            return salvou;
        }
    }
}
