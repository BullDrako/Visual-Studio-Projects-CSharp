using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//6. Creeu un programa tal que introduït dos números en binari sigui capaç de mostrar-nos la seva suma en decimal. 

namespace Exercici_basic_6
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Escribe un numero1 binario: ");
            String binario = Console.ReadLine();
            int deci = ConvertirAdecimal(binario);
            Console.WriteLine("El numero binario " + binario + " en decimal es " + deci);

            Console.WriteLine("Escribe un numero2 binario: ");
            String binario2 = Console.ReadLine();
            int deci2 = ConvertirAdecimal(binario2);
            Console.WriteLine("El numero binario "+ binario2 + " en decimal es " + deci2);

            int suma = SumaDecimal(deci, deci2);

            Console.WriteLine("La suma de los binarios " + binario + " (" + deci + ")" + " i " + binario2 + " (" + deci2 +  ") " + " en decimal es " + suma);
            Console.Read();
        }


        static int ConvertirAdecimal(String bin)
        {
            int n1 = 0;
            bool v = true;
           
            for (int x = bin.Length - 1, y = 0; x >= 0; x--, y++)
            {
                if (bin[x] == '0' || bin[x] == '1')
                    n1 += (int)(int.Parse(bin[x].ToString()) * Math.Pow(2, y));
                else
                {
                    Console.WriteLine("El numero no es binario");
                    v = false;
                    break;
                }

            }

            if (v)
            {
                return n1;
            }
            else
            {
                return '.';
            }
            
        }

        static int SumaDecimal(int n1, int n2)
        {
            int resultado = n1 + n2;

            return resultado;

        }


   }
}
    

