using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstrata
{
    class Recepcionista : Funcionario
    {
        public int ramar { get; set; }

        public override double BonificacaoSalarial()
        {
            return this.Salario += (Salario + 150) * 1.20;
        }
    }
}
