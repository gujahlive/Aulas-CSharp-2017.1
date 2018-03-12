using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioHeranca
{
    class Conta
    {
        public int Numero { get; protected set; }
        public double Saldo { get; protected set; }

        public Conta() { }
        public Conta(int numero, double saldo) {
            this.Numero = numero;
            this.Saldo = saldo;
        }

        public void DefinirNumero(int numero)
        {
            this.Numero = numero;
        }

        public virtual void Depositar(double valor) {
            this.Saldo += valor;
        }

        public virtual void Sacar(double valor) {
            if(this.Saldo > valor)
            {
                this.Saldo -= valor;
            }
        }
    }
}
