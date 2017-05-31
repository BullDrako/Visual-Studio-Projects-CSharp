using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercici2WindowsForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox2.Visible = false;
        }

        private void buttonCalcular_Click(object sender, EventArgs e)
        {
            char[] arrayCadena;
            char caracter;
            int contador = 0;


              arrayCadena = textBox1.Text.ToCharArray();
           
            for (int i = 0; i < arrayCadena.Length; i++)
            {
                caracter = arrayCadena[i];
                

                for (int j = 0; j < arrayCadena.Length; j++)
                {
                    if (arrayCadena[j] == caracter)
                    {
                        contador++;

                    }
                    
                }
                textBox2.Visible = true;
                textBox2.Text = arrayCadena[i] + " -> " + contador;
               
                contador = 0;
            }



            /*String introducir = Convert.ToString(textBox1.Text);
            char[] array1 = introducir.ToCharArray();
            // string s = new string(array1);
            textBox2.Visible = true;


            Dictionary<char, int> contador = new Dictionary<char, int>();

            foreach (char caracter in array1)
            {
                
                if (contador.ContainsKey(caracter))
                {
                    contador[caracter]++;
                }
                else {
                    contador.Add(caracter, 1);
                }
                    
                   
            }
            //string s = new string(array1);
            foreach (KeyValuePair<char, int> item in contador)
            {
                 textBox2.Text = string.Format("{0} = {1}", item.Key, item.Value);
                

            }
            */


            /* string s = new string(array1);

             textBox2.Text = s;*/


            /*
              String introducir = Convert.ToString(textBox1.Text);lo que haya en el textbox1 lo pongo en un string
              char[] array1 = introducir.ToCharArray(); //creo char array con lo del texbox1
              textBox2.Visible = true; //hacer visible el textbox2
              string s = new string(array1);//volver como estaba antes para imprimir
              textBox2.Text = s;
             
             */




          


        }
    }
}
