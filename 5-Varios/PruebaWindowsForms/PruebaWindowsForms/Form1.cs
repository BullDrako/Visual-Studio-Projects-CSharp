using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PruebaWindowsForms
{
    public partial class Form1 : Form //los 2 puntos son herencnia o interfaz
    {
        int numero1;
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hola", "Atenció", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            /*textBox1.Text += "7"; /* o textBox1.Text = textBox1.Text + "7"; */          
        }

        private void button12_Click(object sender, EventArgs e)
        {//todos los botones se muestran el textbox
            Button b = (Button)sender;
            textBox1.Text += b.Text;
        }

        private void button_suma_Click(object sender, EventArgs e)
        {
            numero1 = Convert.ToInt32(textBox1.Text); //o /* numero1 = int.Parse(textBox1.Text);*/
            textBox1.Text = "";
            // 1- calculadora sumi tots els numero que vulguis (cambiar programacion)
            // 2- Etiqueta (label) que ensenyi totes les operacions en format expressió: 1+2+3+1
                 //format readonly de label
                  //efecto calculadora windows
            //fer suma y resta

        }

        private void button_igual_Click(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString(numero1 + int.Parse(textBox1.Text));
        }
    }
}
