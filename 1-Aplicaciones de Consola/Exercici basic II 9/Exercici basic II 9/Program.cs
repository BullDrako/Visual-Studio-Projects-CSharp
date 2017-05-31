using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercici_basic_II_9
{
    class Program
    {//9.- Desenvolupeu un programa que demani a l’usuari una frase i retorni la mateixa frase sense espais, 
     //donada la volta, sense accents i amb les vocals en majúscules i les consonants en minúscules.
     //A més a més ens retornarà el recompte de cadascuna de les vocals que hi conté.
        static void Main(string[] args)
        {
            Console.WriteLine("Pon una frase ");
            String frase = Console.ReadLine();

            //quita espacio
            frase = frase.Replace(" ", "");
           
 
            //quita acentos
            frase = frase.Replace("à", "a");
            frase = frase.Replace("á", "a");
            frase = frase.Replace("è", "e");
            frase = frase.Replace("é", "e");
            frase = frase.Replace("í", "i");
            frase = frase.Replace("ó", "o");
            frase = frase.Replace("ò", "o");
            frase = frase.Replace("ú", "u");

            frase = frase.ToLower();
            int cont = 0, conta =0, conte =0, conti =0, conto =0, contu=0;

            //cuenta vocales
            for (int i = 0; i < frase.Length; i++)
            {
                switch (frase[i].ToString())
                {                    
                    case "a":
                        frase = frase.Replace("a","A");
                        cont++;
                        conta++;
                        break;
                    case "e":
                        frase = frase.Replace("e", "E");
                        cont++;
                        conte++;
                        break;
                    case "i":
                        frase = frase.Replace("i", "I");
                        cont++;
                        conti++;
                        break;
                    case "o":
                        frase = frase.Replace("o", "O");
                        cont++;
                        conto++;
                        break;
                    case "u":
                        frase = frase.Replace("u", "U");
                        cont++;
                        contu++;
                        break;
                }   
            }

            char[] fras = frase.ToCharArray();
           
            Array.Reverse(fras);
            Console.WriteLine("Del revés: ");
            Console.WriteLine(fras);
            

            Console.WriteLine("Total Vocales: " + cont);
            Console.WriteLine("Vocales A: " + conta);
            Console.WriteLine("Vocales E: " + conte);
            Console.WriteLine("Vocales I: " + conti);
            Console.WriteLine("Vocales O: " + conto);
            Console.WriteLine("Vocales U: " + contu);

            Console.ReadLine();

        }
    }
}
