using BIT_LOGIN.AcessoBanco;
using BIT_LOGIN.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIT_LOGIN.Negocio
{
     public class LoginNeg
    {
        public DadosLogin FindByLogin(string nmUsuario, string senhaUsuario, int tipo)
        {
            Login uDAL = new Login();
            return uDAL.FindByLogin(nmUsuario, senhaUsuario,tipo);
        }
    }
}
