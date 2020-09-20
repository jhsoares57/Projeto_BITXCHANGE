using BIT_DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class CotacaoBLL
    {
        public DataTable ListarCotacaoMoedaBLL()
        {
            return new CotacaoDAL().ListarCotacaoMoeda();
        }
    }
}
