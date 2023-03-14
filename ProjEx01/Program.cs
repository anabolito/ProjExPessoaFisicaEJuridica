using ProjEx01;

internal class Program
{
    private static void Main(string[] args)
    {
        //faça um prog que permita criar dois objetos, uma pessoa física e uma jurídica,
        //ambos devem conter nome, nome fantasia, cpf/cnpj, endereço, email, 2 telefones 

        Pessoa pessoa = new Pessoa("Ana", "997640022", "999037183", "anac.ggb@gmail.com", "14806-733", 710);
        Juridica juridica = new Juridica(pessoa, "123456789", "MileyCyrus");
        Fisica fisica = new Fisica(pessoa, "48081083804" );

        Console.WriteLine(fisica.ToString());
        Console.WriteLine(juridica.ToString());






    }
}