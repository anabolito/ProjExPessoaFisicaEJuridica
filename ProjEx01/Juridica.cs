using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjEx01
{
    internal class Juridica : Pessoa
    {

        public string Cnpj { get; set; }
        public string NomeFantasia { get; set; }
        
        public Juridica(Pessoa pessoa, string cnpj, string nomeFantasia) : base(pessoa.Nome, pessoa.Telefone1, pessoa.Telefone2, pessoa.Email, pessoa.Cep, pessoa.Nonce)
        {
            Cnpj = cnpj;
            NomeFantasia = nomeFantasia;
        }
        public override string ToString()
        {
            return base.ToString() + " - "+ Cnpj + " - "+ NomeFantasia;
        }
    }
}
