﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BIT_LOGIN.Model
{
    public class DadosLogin
    {
        private string email;
        private string senha;

        public string Email { get => email; set => email = value; }
        public string Senha { get => senha; set => senha = value; }
    }
}