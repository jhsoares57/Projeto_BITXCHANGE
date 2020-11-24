using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BIT_MODEL;
using BIT_DAL;
using System.Data;

namespace BLL
{
    public class DepositoBLL
    {
        public bool depositoCartao(DepositoModel D)
        {
            bool salvou = false;
            new DepositoDAL().inserirDepositoCartao(D);

            //Se o ID for maior que zero, indica que o dado foi salvo
            if (D.Id > 0)
            {
                salvou = true;
            }
            return salvou;
        }

        public bool depositoBoleto(DepositoModel D)
        {
            bool salvou = false;
            new DepositoDAL().inserirDepositoBoleto(D);

            //Se o ID for maior que zero, indica que o dado foi salvo
            if (D.Id > 0)
            {
                salvou = true;
            }
            return salvou;
        }
    }
}
