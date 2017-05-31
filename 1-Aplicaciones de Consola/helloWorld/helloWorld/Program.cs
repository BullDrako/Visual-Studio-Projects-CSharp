using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace helloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
                        
            int minuto = 60;    //segundos por minuto
            int hora = minuto * 60;
            int dia = hora * 24;
            long anio = dia * 365;
            string name;

            Console.WriteLine("Dame tu nombre");
            name = Console.ReadLine();
            Console.WriteLine("Segundos en un dia: {0} y segundos en un año: {1}", dia, anio);
            Console.WriteLine("Tu nombre es: {0}", name);
            Console.Read();
        }
    }
}
