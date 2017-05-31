using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Collections;

namespace examen1_M7_DAM_Edgar_Cabeza
{
    public partial class Form1 : Form
    {
       
       
        public Form1()
        {
            InitializeComponent();


          /*  try
            {
                using (StreamReader sr = new StreamReader("Dam2.txt"))
                {
                    string line;
                    string line2;

                    while ((line = sr.ReadLine()) != null)
                    {
                        /*while ((line2 = sr.ReadLine()) != ":")
                        {
                            textBox1.Text = line2;
                            
                        }*/

                      /*  if ((line2 = sr.ReadLine()) != ":")
                        {
                            
                            textBox1.Text = line2.Substring(0, ':');
                        }

                       

                       //textBox7.Text = line;
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
        }

        private void button_Nou_Click(object sender, EventArgs e)
        {
             textBox1.Clear();
             textBox2.Clear();
             textBox3.Clear();
             textBox4.Clear();
             textBox5.Clear();
             textBox6.Clear();
             textBox7.Clear();

            textBox1.ReadOnly = false;
            textBox2.ReadOnly = false;
            textBox3.ReadOnly = false;
            textBox4.ReadOnly = false;
            textBox5.ReadOnly = false;
            textBox6.ReadOnly = false;
            textBox7.ReadOnly = false;

            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
        }

        private void button_Editar_Click(object sender, EventArgs e)
        {
            textBox1.ReadOnly = false;
            textBox2.ReadOnly = false;
            textBox3.ReadOnly = false;
            textBox4.ReadOnly = false;
            textBox5.ReadOnly = false;
            textBox6.ReadOnly = false;
            textBox7.ReadOnly = false;

            ArrayList alumnes = new ArrayList() { "", textBox1.Text + ":" + textBox2.Text + ":" + textBox3.Text + "," + textBox4.Text + "," + textBox5.Text + ":" + textBox6.Text + ":" + textBox7.Text + ":" };

            using (StreamWriter sw = new StreamWriter("Dam2.txt", true))
            {

                foreach (string s in alumnes)
                {
                    sw.WriteLine(s);
                }
            }
        }

        private void button_Guardar_Click(object sender, EventArgs e)
        {
            ArrayList alumnes = new ArrayList() {"", textBox1.Text + ":" + textBox2.Text + ":" + textBox3.Text + "," + textBox4.Text + "," + textBox5.Text + ":" + textBox6.Text + ":" + textBox7.Text + ":" };

            using (StreamWriter sw = new StreamWriter("Dam2.txt", true))
            {

                foreach (string s in alumnes)
                {
                    sw.WriteLine(s);
                }
            }

            textBox1.ReadOnly = true;
            textBox2.ReadOnly = true;
            textBox3.ReadOnly = true;
            textBox4.ReadOnly = true;
            textBox5.ReadOnly = true;
            textBox6.ReadOnly = true;
            textBox7.ReadOnly = true;

            button4.Visible = true;
            button5.Visible = true;
            button6.Visible = true;
            button7.Visible = true;
        }
    }
}
