using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conta
{
   public class Conta
    {
        private String Titular{ get; set; }
        public double Saldo;
        public int CodigoConta { get; set; }

        public String NomeAgencia { get; private set; }


        /*
        public String getTitular(){
            return this.titular;
            }

        public void setTitular(String nome) {
            this.titular = nome;
        }
        

        public String Titular {

            get {
                return this.titular;
            }

            set {
            }
        }
        */


        public double Sacar(double valor) {

            this.Saldo -= valor;
            return this.Saldo;

        }

       

    }
}
