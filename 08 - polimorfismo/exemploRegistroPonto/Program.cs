using System;

namespace exemploRegistroPonto
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

                Gerente G1 = new Gerente();
                G1.Matricula = 1234;

                Telefonista T1 = new Telefonista();
                T1.Matricula = 4321;

                ControleDePonto cp1 = new ControleDePonto();

                cp1.RegistraEntrada(G1);
                cp1.RegistraEntrada(T1);

                cp1.RegistraSaida(G1);
                cp1.RegistraSaida(T1);




                
                
        }
    }
}
