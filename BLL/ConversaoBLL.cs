using BIT_DAL;
using BIT_MODEL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ConversaoBLL
    {
        public bool InserirConversao(ConversaoModel C)
        {
            bool salvou = false;
            new ConversaoDAL().InserirConversao(C);

            //Se o ID for maior que zero, indica que o dado foi salvo
            if (C.IdConversao > 0)
            {
                salvou = true;
            }

            return salvou;
        }
    }
}
