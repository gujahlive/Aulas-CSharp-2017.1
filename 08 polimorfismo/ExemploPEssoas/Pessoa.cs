using System;

namespace ExemploPEssoas
{
    class Pessoa
    {
        public String Nome{get; set;}
        public String Documento{get; set;}

        public virtual void ValidarDocumento(String doc){
            Console.WriteLine(doc.Length);
        }
    }
}
