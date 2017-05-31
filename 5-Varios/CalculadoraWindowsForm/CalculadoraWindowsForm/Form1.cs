using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraWindowsForm
{
    public partial class Form1 : Form
    {
        int numero1;

        int numero2;
        int resultado;
        String operacion;


        
        public Form1()
        {
            InitializeComponent();
            label1.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void botonesNumero_Click(object sender, EventArgs e)
        {
            //todos los botones se muestran el textbox
            Button b = (Button)sender;
            textBox1.Text += b.Text;
          
        }

        private void button_suma_Click(object sender, EventArgs e)
        {
            // numero1 = Convert.ToInt32(textBox1.Text); //o /* numero1 = int.Parse(textBox1.Text);*/
            // textBox1.Text = "";

            // 1- calculadora sumi tots els numero que vulguis (cambiar programacion)
            // 2- Etiqueta (label) que ensenyi totes les operacions en format expressió: 1+2+3+1
            //format readonly de label
            //efecto calculadora windows
            //fer suma y resta

            operacion = "+";
            numero1 = Convert.ToInt32(textBox1.Text);
            textBox1.Text = "";          
            label1.Text = numero1.ToString() + operacion.ToString();


        }

        private void button_resta_Click(object sender, EventArgs e)
        {
            operacion = "-";
            numero1 = Convert.ToInt32(textBox1.Text);
            textBox1.Text = "";            
            label1.Text = numero1.ToString() + operacion.ToString();


        }

        private void button_multiplicacion_Cick(object sender, EventArgs e)
        {
            operacion = "*";
            numero1 = Convert.ToInt32(textBox1.Text);
            textBox1.Text = "";          
            label1.Text = numero1.ToString() + operacion.ToString();

        }

        private void button_division_Cick(object sender, EventArgs e)
        {
            operacion = "/";
            numero1 = Convert.ToInt32(textBox1.Text);
            textBox1.Text = "";
            label1.Text = numero1.ToString() + operacion.ToString();

        }

        private void button_CE_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            label1.Text = "";
           

        }


        private void button_igual_Click(object sender, EventArgs e)
        {
            //textBox1.Text = Convert.ToString(numero1 + int.Parse(textBox1.Text));


            numero2 = int.Parse(textBox1.Text);

            switch (operacion)
            {
                case "+":
                    resultado = numero1 + numero2;
                    textBox1.Text = resultado.ToString();
                    label1.Text = "";
                    break;

                case "-":
                    resultado = numero1 - numero2;
                    textBox1.Text = resultado.ToString();                   
                    label1.Text = "";
                    break;

                case "*":
                    resultado = numero1 * numero2;
                    textBox1.Text = resultado.ToString();                    
                    label1.Text = "";
                    break;

                case "/":
                    resultado = numero1 / numero2;
                    textBox1.Text = resultado.ToString();                    
                    label1.Text = "";
                    break;
            }
        }
    }
}
