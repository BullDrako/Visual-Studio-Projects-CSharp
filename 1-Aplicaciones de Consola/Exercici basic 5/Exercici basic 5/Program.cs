using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//5. Escriu un programa que introduït un número positiu i inferior a 5000 escrit en xifres àrabs ens retorni el mateix número però escrit en xifres romanes,
//depenent del que ens doni. 

namespace Exercici_basic_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;

            do
            {
                Console.WriteLine("Introduce un número entre 1 y 5000: ");
                num = int.Parse(Console.ReadLine());

            } while (num < 1 || num > 5000);

            Console.WriteLine(num + " en numeros romanos es " + convertirARomanos(num));
            Console.ReadLine();
        }

        public static String convertirARomanos(int numero)
        {
            int mill, cent, decenas, unidades;
            String romano = "";

            mill = numero / 1000;
            cent = numero / 100 % 10;
            decenas = numero / 10 % 10;
            unidades = numero % 10;

            // mil
            for (int i = 1; i <= mill; i++)
            {
                romano = romano + "M";
            }

            //cien
            if (cent == 9)
            {
                romano = romano + "C";
            }
            else if (cent >= 5)
            {
                romano = romano + "D";
                for (int i = 6; i <= cent; i++)
                {
                    romano = romano + "C";
                }
            }
            else if (cent == 4)
            {
                romano = romano + "C";
            }
            else
            {
                for (int i = 1; i <= cent; i++)
                {
                    romano = romano + "C";
                }
            }

            if (decenas == 9)
            {
                romano = romano + "X";
            }
            else if (decenas >= 5)
            {
                romano = romano + "L";
                for (int i = 6; i <= decenas; i++)
                {
                    romano = romano + "X";
                }
            }
            else if (decenas == 4)
            {
                romano = romano + "X";
            }
            else
            {
                for (int i = 1; i <= decenas; i++)
                {
                    romano = romano + "X";
                }
            }

            //unidades
            if (unidades == 9)
            {
                romano = romano + "IX";
            }
            else if (unidades >= 5)
            {
                romano = romano + "V";
                for (int i = 6; i <= unidades; i++)
                {
                    romano = romano + "I";
                }
            }
            else if (unidades == 4)
            {
                romano = romano + "IV";
            }
            else
            {
                for (int i = 1; i <= unidades; i++)
                {
                    romano = romano + "I";
                }
            }
            return romano;


        }

    }
}