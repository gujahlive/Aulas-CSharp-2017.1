using System;

namespace ExemploEscola
{
    class Diretor : Funcionario
    {   
        public Diretor() : base(){}
        public Diretor(String Nome) : base(Nome){}

        
        public String Usuario{get; set;}
        public int Senha{get; set;}

        public override void CalculaBonificacao(){
            //base.CalculaBonificacao()
            this.Salario *= 1.15;
        }
    }
}