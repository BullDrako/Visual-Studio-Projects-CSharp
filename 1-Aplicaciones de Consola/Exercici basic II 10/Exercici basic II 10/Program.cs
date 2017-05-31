using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercici_basic_II_10
{
    class Program
    {//10. Demanem un texte. Un cop introduït el programa ens hi deixarà fer diferentes accions a escollir 
     //en un menú:
     // - Buscar una paraula i ens dirà quantes vegades hi apareix.
     // - -Modificar una paraula i ens retornarà el texte de nou però amb totes les substitucions  fetes.
     // - Esborrar una paraula i ens retornarà el texte de nou però sense la paraula escollida.
        static void Main(string[] args)
        {
            String btexto, cadena;
            int cont = 0, marcar_espacios;

            Console.WriteLine("introduce texto: ");
            String texto = Console.ReadLine();
            btexto = texto;

            Console.WriteLine("Que quieres hacer? ");
            Console.WriteLine("1- Buscar una paraula i ens dirà quantes vegades hi apareix. ");
            Console.WriteLine("2- Modificar una paraula i ens retornarà el texte de nou però amb totes les substitucions 	fetes. ");
            Console.WriteLine("3- Esborrar una paraula i ens retornarà el texte de nou però sense la paraula escollida. ");

            int opcion = int.Parse(Console.ReadLine());

           
            switch (opcion)
            {
                case 1:
                    Console.WriteLine("Palabra a contar ");
                    String palabra = Console.ReadLine();

                    while (btexto.IndexOf(' ') != -1)
                    {
                        marcar_espacios = btexto.IndexOf(' ');
                        cadena = btexto.Substring(0, marcar_espacios);
                        btexto = btexto.Substring(marcar_espacios + 1);

                        if (palabra == cadena)
                        {
                            cont++;
                        }
                    }

                    if (btexto == palabra)
                    {
                        cont++; 
                    }

                    Console.Write(palabra + " está {0} veces ", cont);
                    Console.ReadLine();
                    break;

                case 2:
                    Console.WriteLine("Palabra a modificar ");
                    String pmodificar = Console.ReadLine();
                    Console.WriteLine("Palabra a por la que quieres substituir ");
                    String otra = Console.ReadLine();
                    texto = texto.Replace(pmodificar, otra);

                    Console.WriteLine(texto);
                    Console.ReadLine();
                    break;

                case 3:
                    Console.WriteLine("Palabra a eliminar ");
                    String peliminar = Console.ReadLine();
                    String peliminada = "";
                    texto = texto.Replace(peliminar, peliminada);

                    Console.WriteLine(texto);
                    Console.ReadLine();
                    break;
            }
        }
    }
}
