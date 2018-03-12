using System;

namespace ExemploPEssoas
{
    class PessoaFisica : Pessoa
    {
        public override void ValidarDocumento(String cpf){

            if(cpf.Length == 11){
                Console.WriteLine("Pessoa fisica");
            }else
            {
                Console.WriteLine(cpf.Length);
            }
        }
    }
}