using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIT_LOGIN.Model
{
    public class DadosLogin
    {
        private int id;
        private string email;
        private string senha;
        private int tipo;
        private string nome;

        public string Email { get => email; set => email = value; }
        public string Senha { get => senha; set => senha = value; }
        public int Tipo { get => tipo; set => tipo = value; }
        public string Nome { get => nome; set => nome = value; }
        public int Id { get => id; set => id = value; }
    }
}
