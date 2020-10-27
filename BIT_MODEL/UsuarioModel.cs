using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace BIT_MODEL
{
    public class UsuarioModel
    {
        private int id;
        private string nome;
        private string email;
        private string cpf;
        private DateTime dataNascimento;
        private int sexo;
        private string senha;
        private int status;
        private int tipo;
        private DateTime dataCadastro;
        
        public int Id { get => id; set => id = value; }

        [Required(ErrorMessage = "Campo 'Nome e Sobrenome' é obrigatório")]
        public string Nome { get => nome; set => nome = value; }

        [Required(ErrorMessage = "Campo 'E-mail' é obrigatório")]
        [EmailAddress(ErrorMessage = "Informe um E-mail válido")]
        public string Email { get => email; set => email = value; }

        [Required(ErrorMessage = "Campo 'Cpf' é obrigatório")]
        public string Cpf { get => cpf; set => cpf = value; }

        [Required(ErrorMessage = "Campo 'Data de Nascimento' é obrigatório")]
        public DateTime DataNascimento { get => dataNascimento; set => dataNascimento = value; }

        [Required(ErrorMessage = "Campo 'Sexo' é obrigatório")]
        public int Sexo { get => sexo; set => sexo = value; }

        [Required(ErrorMessage = "Campo 'Senha' é obrigatório")]
        public string Senha { get => senha; set => senha = value; }
        public int Status { get => status; set => status = value; }
        public int Tipo { get => tipo; set => tipo = value; }
        public DateTime DataCadastro { get => dataCadastro; set => dataCadastro = value; }
    }
}
