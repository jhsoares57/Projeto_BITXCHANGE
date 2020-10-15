using BIT_DAL;
using BIT_MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class CarteiraBLL
    {
        public CarteiraModel RetornaSaldoCartiraPorID(int id, int moeda)
        {
            return new CarteiraDAL().RetornaSaldoCartiraPorID(id,moeda);
        }
    }
}
