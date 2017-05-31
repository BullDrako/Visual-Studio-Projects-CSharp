using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace LecturaFicheros
{
    class Program
    {
        static void Main(string[] args)
        {
            //lectura
            /*try
            {
                // Create an instance of StreamReader to read from a file.
                // The using statement also closes the StreamReader.
                using (StreamReader sr = new StreamReader("Lectura.txt"))//poner en bin/debug
                {
                    string line;

                    // Read and display lines from the file until 
                    // the end of the file is reached. 
                    while ((line = sr.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }
                }
            }
            catch (FileNotFoundException er1)
            {
                Console.WriteLine("No s'ha trobar fitxer:");
                Console.WriteLine(er1.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error general:");
                Console.WriteLine(e.Message);
            }*/
            //fi lectura

            //Escritura
            string[] names = new string[] { "Zara Ali", "Nuha Ali" };
            using (StreamWriter sw = new StreamWriter("names.txt")) //si le pones true añade pe: lectura.txt
            {

                foreach (string s in names)
                {
                    sw.WriteLine(s);
                }
            }

            // Read and show each line from the file.
            string line = "";
            using (StreamReader sr = new StreamReader("names.txt"))
            {
                while ((line = sr.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
            //fi escritura

            

            Console.ReadKey();
        }
    }
}
