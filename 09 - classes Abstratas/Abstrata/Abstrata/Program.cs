using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstrata
{
    class Program
    {
        static void Main(string[] args)
        {
            Gerente G1 = new Gerente();
            Recepcionista R1 = new Recepcionista();

            Funcionario F1 = new Gerente();
            //Funcionario F2 = new Funcionario();

            G1.Nome = "Gelton Cruz";
            G1.Salario = 5000;
            G1.BonificacaoSalarial();
            Console.WriteLine(G1.Salario);
            Console.ReadLine();

        }
    }
}
