using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjEx01
{
    internal class Fisica : Pessoa
    {
        public string Cpf { get; set; }

        public Fisica(Pessoa pessoa, string cpf) : base(pessoa.Nome, pessoa.Telefone1 ,pessoa.Telefone2, pessoa.Email, pessoa.Cep, pessoa.Nonce)      
        {
            Cpf = cpf;
        }
        public override string ToString()
        {
            return base.ToString() + " - " + Cpf;
        }
    }
}
