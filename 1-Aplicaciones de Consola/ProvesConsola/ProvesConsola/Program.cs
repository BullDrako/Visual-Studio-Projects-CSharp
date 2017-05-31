using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvesConsola
{
    class Program
    {
        static void Main(string[] args)
        {
            //constant
            //  const int segPorHora = 3600;
            //array
            //    String[] noms = new String[3];
            //   noms[0] = "Ana";
            //   noms[1] = "Victor";
            //   noms[2] = "Maria";
            /* O */
            /*String[] noms = { "Ana", "Victor", "Maria" };*/

            //   String miNombre = "Edgar";
            //o 3
            /* for (int i = 0; i < noms.Length ; i++)
             {
                 Console.WriteLine("el valor es {0} i {1}, {2} segons", noms[i], miNombre, segPorHora);
             }*/

            //   foreach (String elem in noms) // var en vez de string --> no le dices el tipo
            //    {
            //       Console.WriteLine(elem);
            //  }

            //   Console.Read();

            /*calcular index de massa corporal= pes/(alçada^2)
             sortir:fer calcul y dir com se está verbalment
             entrar: pes alçada*/


            /* float pes;
             float alsada;
             Console.WriteLine("Dona'm el teu pes");
             pes = float.Parse(Console.ReadLine());
             Console.WriteLine("Dona'm la teva alçada");
             alsada = float.Parse(Console.ReadLine());

             float imc = calculIMC(pes, alsada);
             Console.WriteLine("El teu IMC és {0}", imc);
             comEstas(imc);
             Console.Read();
         }
         static float calculIMC(float p, float a)
         {
             float imc;
             imc = p / (a * a);
             return imc;
         }
         static void comEstas(float i)
         {
             string value = "";
             if (i < 18.5) value = "Prim";
             if (i >= 18.5 && i < 24.99) value = "Estàs genial!";
             if (i >= 25) value = "Tens sobrepès";
             Console.WriteLine(value);
             */

            //proves array mida y tipus

            /*int[] numbers = { 4, 3, 8, 0, 5 };
            Array.Reverse(numbers);
            foreach (int i in numbers)
                Console.WriteLine(i);
            Console.ReadLine();*/

            //arraylist mida y tipus automatic
            /* ArrayList list = new ArrayList();
             //No es declara la mida
             list.Add("One");
             list.Add("2");
             list.Add("Tres");
             //Es pot barrejar diferents tipus de dades
             foreach (var i in list)
             {
                 Console.WriteLine(i);
             }*/

            //List tipus necesari, mida no
            List<int> list = new List<int>();
            list.Add(2);
            list.Add(3);
            list.Add(5);
            list.Add(7);

            foreach (var i in list)
            {
                Console.WriteLine(i);
            }

            Console.ReadLine();
        }

    }

 }
