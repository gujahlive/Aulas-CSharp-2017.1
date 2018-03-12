using System;

namespace exemploRegistroPonto
{
        class ControleDePonto
        {
            
            public void RegistraEntrada(Funcionario F)
            {

                DateTime agora  = DateTime.Now;
                String Horario = String.Format("{0: d/M/yyyy HH:mm:ss}", agora);
                Console.WriteLine("HORARIO DE ENTRADA : "+Horario);
                Console.WriteLine("CODIGO DE MATRICULA : "+F.Matricula);
            }

            public void RegistraSaida(Funcionario F)
            {

                DateTime agora  = DateTime.Now;
                String Horario = String.Format("{0: d/M/yyyy HH:mm:ss}", agora);
                Console.WriteLine("HORARIO DE SAIDA : "+Horario);
                Console.WriteLine("CODIGO DE MATRICULA : "+F.Matricula);
            }
             
        }
}
