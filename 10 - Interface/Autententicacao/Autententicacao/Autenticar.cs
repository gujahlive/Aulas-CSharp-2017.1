using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autententicacao
{
    class Autenticar
    {
        public void Logar(Iautentica i)
        {
            Console.WriteLine(i.Nome + " Logado com sucesso!");
        }
    }
}
