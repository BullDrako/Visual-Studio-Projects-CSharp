using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//4.- Donat un número de segons, fes un programa que calculi a quantes hores, minuts i segons hi corresponen.

namespace Exercici_basic_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int dies, hores, minuts, segons;
            int n, minutstot, horestot;

            Console.WriteLine("Introduce un numero de segundos ");

            n = int.Parse(Console.ReadLine());

            Console.WriteLine(n + " segons son: ");

            segons = n % 60;
            minutstot = n / 60;

            minuts = minutstot % 60;
            horestot = minutstot / 60;

            hores = horestot % 24;
            dies = horestot / 24;

            Console.WriteLine(dies + "  dies");
            Console.WriteLine(hores + "  hores");
            Console.WriteLine(minuts + "  minuts");
            Console.WriteLine(segons + "  segons");

           
            

           

        }
    }
}
