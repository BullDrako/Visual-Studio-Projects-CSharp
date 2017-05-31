using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMC_Clase
{
    class Program
    {
        static void Main(string[] args)
        {
            float p, a;
            Console.WriteLine("Dona el teu pes");
            p = float.Parse(Console.ReadLine());

            Console.WriteLine("Dona la teva alçada");
            a = float.Parse(Console.ReadLine());

            Index imc = new Index(p, a);
            Console.WriteLine(imc.Calcula());
            Console.WriteLine(imc.ComEstas());

            //hacer caculadora con consola
            //que donant 2 nueros con coma faci totes operacions
            //con clase
        }
    }
}
