using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transferencia
{
    class Conta
    {
        //private String titular;
        //private double saldo;
       // private int numero;

        public int Numero { get; set; }
        public String Titular { get; set; }
        public double Saldo{ get; set;}

        public double Sacar(double valor) {
            Saldo -= valor;
            return Saldo;
            
        }

    }
}
