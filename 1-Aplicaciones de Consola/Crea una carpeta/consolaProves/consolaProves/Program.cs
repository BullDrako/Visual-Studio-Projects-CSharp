using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consolaProves
{
    class Program
    {
        static void Main(string[] args)
        {
            float pes;
            float alsada;
            Console.WriteLine("Dona'm el teu pes");
            pes = float.Parse(Console.ReadLine());
            Console.WriteLine("Dona'm la teva alçada");
            alsada = float.Parse(Console.ReadLine());
            
            float imc = calculIMC(pes, alsada);
            Console.WriteLine("El teu IMC és {0}",imc );
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
            string value="";
            if (i < 18.5) value = "Prim";
            if (i >= 18.5 && i < 24.99) value = "Estàs genial!";
            if (i >= 25) value = "Tens sobrepès";
            Console.WriteLine(value);
          
        }

    }
}
