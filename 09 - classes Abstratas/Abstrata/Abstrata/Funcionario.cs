using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstrata
{
    abstract class Funcionario
    {
        public String Nome { get; set; }
        public int Matricula { get; set; }
        public double Salario { get; set; }

        public void RegistrarPonto() { }

        abstract public double BonificacaoSalarial();
         

    }
}
