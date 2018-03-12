using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstrata
{
    class Gerente : Funcionario
    {
        public int senha { get; set; }

        public override double BonificacaoSalarial()
        {
            return this.Salario += (Salario + 300)*1.20;
        }
    }
}
