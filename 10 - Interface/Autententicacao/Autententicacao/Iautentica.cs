using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autententicacao
{
    interface Iautentica
    {
        String Nome { get; set; }
        int Senha { get; set; }

        void ExibirSenha();

    }
}
