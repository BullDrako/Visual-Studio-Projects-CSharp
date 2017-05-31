using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercici3WindowsForm
{
    public partial class Form1 : Form
    {
        String[] Palabras;
        char[] Alfabeto;
        char[] PalabraSeleccionada;
        char[] PalabrasAdivinadas;
        int Oportunidades;
        

        public void iniciar_juego()
        {
            int oportunidades = 10;
            label1.Text = "Oportunidades: " + Convert.ToString(oportunidades).ToString();

            Palabras = new String[] { "casa", "perro", "consola", "gato" };
            Alfabeto = "ABCDEFGHIJKLMNÑOPQRSTUVWXYZ".ToCharArray();
            Random random = new Random();
            int IndicePalabraSeleccionada = random.Next(0, Palabras.Length);

            PalabraSeleccionada = Palabras[IndicePalabraSeleccionada].ToUpper().ToCharArray();
            PalabrasAdivinadas = PalabraSeleccionada;
            List<TextBox> textboxes = new List<TextBox>();

            for (int IndiceValorLetra = 0; IndiceValorLetra < PalabraSeleccionada.Length; IndiceValorLetra++ )
            {
                /* Button Letra = new Button();
                 Letra.Tag = PalabraSeleccionada[IndiceValorLetra].ToString();
                 Letra.Width = 45;
                 Letra.Height = 80;
                 Letra.ForeColor = Color.Black;
                 Letra.Text = "-";
                 Letra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                 Letra.Name = "Adivinado " + IndiceValorLetra.ToString();
                 flowLayoutPanel1.Controls.Add(Letra);*/

                TextBox tb = new TextBox();
                tb.Tag = PalabraSeleccionada[IndiceValorLetra].ToString();
                tb.Width = 45;
                tb.Height = 80;
                tb.ForeColor = Color.Black;
                
                tb.Text = PalabraSeleccionada[IndiceValorLetra].ToString();
               // tb.Text = "";
                tb.ReadOnly = true;
                tb.Name = "Adivinado " + IndiceValorLetra.ToString();
                flowLayoutPanel1.Controls.Add(tb);
                textboxes.Add(tb);
                

            }


            
         

        }

        private void Compara(/*object sender, EventArgs e*/)
        {
            
            bool encontrado = false;

          //  Button btn = (Button)sender;

            for (int indiceRevisar = 0; indiceRevisar < PalabrasAdivinadas.Length; indiceRevisar++)
            {
                if (PalabrasAdivinadas[indiceRevisar] != Char.Parse(textBox1.Text))
                {
                    PalabrasAdivinadas[indiceRevisar] = ' ';
                    encontrado = true;
                }
            }

            bool ganaste = true;

            for (int indiceAnalizadorGanador = 0; indiceAnalizadorGanador < PalabrasAdivinadas.Length; indiceAnalizadorGanador++)
            {
                   if(PalabrasAdivinadas[indiceAnalizadorGanador] != ' ')
                {
                    ganaste = false;
                }
            }

            if (ganaste)
            {
                MessageBox.Show("has ganado", "has ganado",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
            }

            if (encontrado)
            {
                Oportunidades = Oportunidades - 1 ;

                if (Oportunidades == 0)
                {
                    MessageBox.Show("no puedes mas", "no puedes mas",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
                }
            }
        }


        public Form1()
        {
            InitializeComponent();
            
        }


       private void Form1_Load(object sender, EventArgs e)
        {
            iniciar_juego();
        }
            
        


        private void button1_Click(object sender, EventArgs e)
        {
            Compara();
        }
    }
}
