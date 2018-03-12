using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autententicacao
{
    class Program
    {
        static void Main(string[] args)
        {
            Gerente G1 = new Gerente();
            Empresa E1 = new Empresa();
            E1.Nome = "Lava Jata ULTDA";
            E1.Senha = 12345;
            E1.ExibirSenha();
            G1.Nome = "Gelton";
            G1.Senha = 1234;
            G1.ExibirSenha();

            Autenticar auth = new Autenticar();
            auth.Logar(G1);
            auth.Logar(E1);

            Console.ReadLine();
           
        }
    }
}
