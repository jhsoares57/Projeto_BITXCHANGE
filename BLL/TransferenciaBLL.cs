using BIT_DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class TransferenciaBLL
    {
        public DataTable ListarRelatorioTransacoes(DateTime DataInicial)
        {
            return new TransferenciaDAL().ListarRelatorioTransacoes(DataInicial);
        }

        public DataTable ListarRelatorioTransacoesMensal(DateTime DataInicial, DateTime DataFinal)
        {
            return new TransferenciaDAL().ListarRelatorioTransacoesMensal(DataInicial,DataFinal);
        }
    }
}
