using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjEx01
{
    internal class Pessoa 
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Telefone1 { get; set; }
        public string Telefone2 { get; set; }
        public string Cep { get; set; }
        public int Nonce { get; set; }

        public Pessoa(string nome, string telefone1, string telefone2, string email, string cep, int nonce)
        {
            Nome = nome;
            Telefone1 = telefone1;
            Telefone2 = telefone2;
            Email = email;
            Cep = cep;
            Nonce = nonce;
        }
        public override string ToString()
        {
            return (Nome + " - " + Telefone1 + " - " + Telefone2 + " - " + Email + " - " + Cep + " - " + Nonce);
        }

    }
}
