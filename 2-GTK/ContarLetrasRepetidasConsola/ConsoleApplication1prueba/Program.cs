using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1prueba
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] arrayCadena;
            char caracter;
            int contador = 0;
            Console.WriteLine("Escribe una frase");
            arrayCadena = Console.ReadLine().ToCharArray();

            for (int i = 0; i < arrayCadena.Length; i++)
            {
                caracter = arrayCadena[i];

                for (int j = 0; j < arrayCadena.Length; j++)
                {
                    if (arrayCadena[j] == caracter)
                    {
                        contador++;
                    }
                }
                
                Console.WriteLine( arrayCadena[i] + " -> " + contador);
                contador = 0;
            }
            Console.ReadKey();

        }
    }
}
