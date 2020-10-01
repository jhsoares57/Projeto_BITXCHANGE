using BIT_ACESSABANCO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIT_BACKUP
{
    public class RetornaDatabase
    {
        ConnectionFactory con = new ConnectionFactory();
        public string RetornaBaseConnectiomString()
        {
            string database = con.Conexao.Database.ToString();
            return database;
        }
    }
}
