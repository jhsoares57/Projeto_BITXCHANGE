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
    }
}
