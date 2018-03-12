using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioHeranca
{
    class ContaCorrente : Conta
    {
        public override void Sacar(double valor)
        {
            base.Sacar(valor + 0.10);
        }
    }
}
