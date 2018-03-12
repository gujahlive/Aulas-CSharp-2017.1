using System;

namespace ExemploPEssoas
{
    class PessoaJuridica : Pessoa
    {
        public override void ValidarDocumento(String cnpj){

            if(cnpj.Length == 14){
                Console.WriteLine("Pessoa Juridica");
            }else
            {
                Console.WriteLine(cnpj.Length);
            }
        }
    }
}