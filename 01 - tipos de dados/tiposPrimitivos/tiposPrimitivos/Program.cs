using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tiposPrimitivos
{
    class Program
    {
        // Enum é tipo de dado numérico
        enum Dias { dom=100,seg,ter,quar,qui,sex,sab  };

        static void Main(string[] args)
        {
            //Variáveis tipadas
            int numero = 3;
            float numero2 = 2f;
            //bool  representado por true e false
            bool certidaoDeVivo = false;
            //Cast como fortalecimento de tipo e conversão explicita
            int resultado = numero + (int) numero2;
            //string é um tipo de dado válido
            string texto = "Ola Mundo";

            //Vetor Unidimensional

            int[] num = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int[] arr = new int[10];

            Console.WriteLine(num[5]);
            
            //Matriz
            int[,] mat = new int[5,5];
            mat[0, 1] = 1;
            mat[0, 2] = 2;

            Console.WriteLine("Valor da matriz na posição [0,1] :"+mat[0,1]);

            List<String> frutas = new List<String>();

            frutas.Add("pera");
            frutas.Add("Maça");
            frutas.Add("Banana");

            frutas.Remove("pera");

            List<int> sorteio = new List<int>();

            sorteio.Add(1);
            sorteio.Add(2);
            Console.WriteLine(sorteio[0]);

            Console.WriteLine(frutas[2]);




            Dias dia = Dias.seg;
            

            Console.WriteLine("A referencia numerica do dia : "+(int) dia);

       

            
            /*

        Console.WriteLine(numero);
            Console.WriteLine(texto);

            Console.WriteLine(texto+" Voce esta vivo? {0}", certidaoDeVivo);
            
    */

            Console.ReadLine();

            // Comentário em Cshar é escrito com // {tambem} 
            
        }
    }
}
