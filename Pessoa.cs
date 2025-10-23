using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroSimples
{
    internal class Pessoa
    {

        public string Nome { get; set; }
        public DateOnly DataNascimento { get; set; }
        public string Email { get; set; }
        public Pessoa(string nome, DateOnly dataNascimento, string email)
        {
            Nome = nome;
            DataNascimento = dataNascimento;
            Email = email;
        }

    }
}
