using System;

namespace ExemploPEssoas
{
    class Program
    {
        static void Main(string[] args)
        {
            

            PessoaFisica Pf1 = new PessoaFisica();
            PessoaJuridica Pj1 = new PessoaJuridica();
            Pf1.ValidarDocumento("11187076541");
            Pj1.ValidarDocumento("12345678987654");
        }
    }
}
