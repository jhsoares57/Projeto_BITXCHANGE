using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;
using BIT_ACESSABANCO;
using BIT_MODEL;
using BIT_DAL;

namespace BIT_BLL
{
    public class UsuarioBLL
    {
        public bool Insert(UsuarioModel U)
        {
            bool salvou = false;
            new UsuarioDAL().cadastrarUsuario(U);

            //Se o ID for maior que zero, indica que o dado foi salvo
            if (U.Id > 0)
            {
                salvou = true;
            }
            return salvou;
        }

        public bool AlterarUsuario(UsuarioModel U)
        {
            bool alterou = false;
            new UsuarioDAL().alterarUsuario(U);

            //Se o ID for maior que zero, indica que o dado foi salvo
            if (U.Id > 0)
            {
                alterou = true;
            }
            return alterou;
        }

        public DataTable SelecionarUsuario()
        {
            return new UsuarioDAL().ListarUsuario();
        }
        public UsuarioModel SelecionarPorID(int id)
        {
            return new UsuarioDAL().SelecionarPorID(id);
        }
    }
}
