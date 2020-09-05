using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIT_MODEL
{
    public class UsuarioModel
    {
        private int id;
        private string nome;
        private string email;
        private string cpf;
        private DateTime dataNascimento;
        private string sexo;
        private string senha;
        private string status;
        private string tipo;
        private DateTime dataCadastro;

        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Email { get => email; set => email = value; }
        public string Cpf { get => cpf; set => cpf = value; }
        public DateTime DataNascimento { get => dataNascimento; set => dataNascimento = value; }
        public string Sexo { get => sexo; set => sexo = value; }
        public string Senha { get => senha; set => senha = value; }
        public string Status { get => status; set => status = value; }
        public string Tipo { get => tipo; set => tipo = value; }
        public DateTime DataCadastro { get => dataCadastro; set => dataCadastro = value; }
    }
}
