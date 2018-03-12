using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioHeranca
{
    class ContaPoupanca : Conta
    {
        public ContaPoupanca() : base() { }
        public ContaPoupanca(int numero, double valor) : base(numero, valor) { }

        public override void Depositar(double valor) {
            //this.Saldo += (valor+ 0.20);
            base.Depositar(valor + 0.20);
        }
    }
}
