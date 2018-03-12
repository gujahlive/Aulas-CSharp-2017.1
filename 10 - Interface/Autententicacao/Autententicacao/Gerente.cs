using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autententicacao
{
    class Gerente : Iautentica
    {
        public String Nome { get; set; }
        public int Senha { get; set; }
        public void ExibirSenha()
        {
            Console.WriteLine(this.Senha);
        }
    }
}
