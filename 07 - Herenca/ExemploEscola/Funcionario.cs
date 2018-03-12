using System;

namespace ExemploEscola
{
    class Funcionario
    {
         public Funcionario(){}
        public Funcionario(String Nome){
            this.Nome = Nome;
        }

        public String Nome{ get; set;}
        public double Salario{get; set;}

        public virtual void CalculaBonificacao(){
            this.Salario *=  1.10;
        }
    }
}