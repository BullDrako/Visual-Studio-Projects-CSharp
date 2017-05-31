using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculadora: ");
            Console.WriteLine(" ");
            Console.WriteLine("Introduce La operacion a realizar:");
            Console.WriteLine(" ");
            Console.WriteLine("1.Sumar ");
            Console.WriteLine("2.Restar ");
            Console.WriteLine("3.Multiplicar ");
            Console.WriteLine("4.Dividir ");
            Console.WriteLine(" ");

            int operacion;
            operacion = int.Parse(Console.ReadLine());

            Console.WriteLine("Has elegido la opción " + operacion + ".");
            Console.WriteLine(" ");

            float op1, op2;
           
            Console.WriteLine("Introduce el Operando 1:");
            op1 = float.Parse(Console.ReadLine());

            Console.WriteLine(" ");

            Console.WriteLine("Introduce el Operando 2:");
            op2 = float.Parse(Console.ReadLine());

            
            Calculadora c = new Calculadora(op1, op2);
            Console.WriteLine(" ");
            c.Operar(op1, op2, operacion);
            Console.WriteLine(" ");
            Console.WriteLine(c.ResultadoFinal());

        }
    }
}
