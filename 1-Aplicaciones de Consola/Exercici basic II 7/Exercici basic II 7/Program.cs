using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercici_basic_II_7
{
    class Program
    {//7.- Aplicació que deixa escriure tantes temperatures com vulguem i en clicar el número 100, 
     //ens retorna la mitja, la que té més freqüència, la màxima i la mínima d'entre totes elles
        static void Main(string[] args)
        {
            int num;

            Console.Write("¿Cuantas temperaturas vas a introducir? ");
            num = int.Parse(Console.ReadLine());


            double[] temperaturas = new double[num]; 
            double media = 0;

          
            for (int i = 0; i < num; i++) //temperaturas.length
            {
                Console.Write("Temperatura {0}: ", i);
                temperaturas[i] = double.Parse(Console.ReadLine());
            }

            Console.WriteLine("Introducidos las {0} temperaturas", num);
            Console.WriteLine("Pulsa INTRO para listarlas");

            Console.ReadLine();

            for (int i = 0; i < temperaturas.Length; i++)
            {
                Console.WriteLine("Temperatura {0}: {1}" + " °C", i, temperaturas[i]);
                media = media + temperaturas[i];   
            }

            int cont = 0;
            int repetidas = 0; 

            for (int i = 1; i < temperaturas.Length; i++)
            {
                int numActual = Convert.ToInt32(temperaturas[i]);
                for (int j = 0; j < i; j++)
                {
                    if (numActual == temperaturas[j])
                    {
                        repetidas = numActual;
                        cont++;
                        break;  
                    }
                }
            }
          


            media = media / temperaturas.Length;
            
            Console.WriteLine("la media es " + media + " °C");
            Array.Sort(temperaturas);
            Array.Reverse(temperaturas);
            Console.WriteLine("La maxima es " + temperaturas[0]);

            Array.Sort(temperaturas);
            Console.WriteLine("La minima es " + temperaturas[0]);

            Console.WriteLine("Temperatura mas repetida: " + repetidas + "°C " + cont + " veces sin contar la primera");


            

            Console.ReadLine();
        }
    }
}


