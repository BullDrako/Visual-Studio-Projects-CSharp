using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ahorcado
{
    public partial class Form1 : Form
    {
        String[] Palabras;
        char[] Abecedario;
        char[] PalabraSeleccionada;
        char[] PalabrasAdivinadas;
        int oportunidades = 10;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            iniciar_juego();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            iniciar_juego();
        }

        public void iniciar_juego()
        {
            pictureBox1.Visible = false;
            button1.Visible = false;
            flowLayoutPanel1.Controls.Clear();
            flowLayoutPanel1.Enabled = true;
            oportunidades = 10;
            
            label1.Text = "oportunidades: " + oportunidades;
            Palabras = new String[] { "casa", "perro", "consola", "gato" };
            Abecedario = "ABCDEFGHIJKLMNÑOPQRSTUVWXYZ".ToCharArray();

            //Palabra aleatoria
            Random random = new Random();
            int IndicePalabraSeleccionada = random.Next(0, Palabras.Length);

            PalabraSeleccionada = Palabras[IndicePalabraSeleccionada].ToUpper().ToCharArray();
            PalabrasAdivinadas = PalabraSeleccionada;

            //Crear letras abecedario

            foreach(char letraAlfabeto in Abecedario)
            {
                Button botonLetra = new Button();
                botonLetra.Tag = "";
                botonLetra.Text = letraAlfabeto.ToString();
                botonLetra.Width = 60;
                botonLetra.Height = 40;
                botonLetra.Click += Compara;
                botonLetra.ForeColor = Color.White;
                botonLetra.Font = new Font(botonLetra.Font.Name, 15, FontStyle.Bold);
                botonLetra.BackColor = Color.Black;
                botonLetra.Name = letraAlfabeto.ToString();
                flowLayoutPanel1.Controls.Add(botonLetra);
            }

            flowLayoutPanel2.Controls.Clear();

            for (int IndiceValorLetra = 0; IndiceValorLetra < PalabraSeleccionada.Length; IndiceValorLetra++)
            {
                 TextBox tb = new TextBox();
                 tb.Tag = PalabraSeleccionada[IndiceValorLetra].ToString();
                 tb.Width = 15;
                 tb.Height = 80;
                 tb.ForeColor = Color.Black;
                 tb.Text = "";
                 tb.ReadOnly = true;
                 tb.Name = "Adivinado " + IndiceValorLetra.ToString();
                 flowLayoutPanel2.Controls.Add(tb);
            }
        }

        void Compara(object sender, EventArgs e)
        {
            bool acertado = false;
            Button btn = (Button)sender;
            btn.BackColor = Color.White;
            btn.ForeColor = Color.Black;
            btn.Enabled = false;


            for (int indiceRevisar = 0; indiceRevisar < PalabrasAdivinadas.Length; indiceRevisar++)
            {
                if (PalabrasAdivinadas[indiceRevisar] == Char.Parse(btn.Text))
                {
                    //si existe la letra actualiza la palabra agregando el valor correspondiente

                    TextBox tbx = this.Controls.Find("Adivinado " + indiceRevisar, true).FirstOrDefault() as TextBox;
                    tbx.Text = PalabrasAdivinadas[indiceRevisar].ToString();
                    PalabrasAdivinadas[indiceRevisar] = '-';
                    acertado = true;
                }
            }

            //verifica si todas las letras de la palabra estan destapadas
            bool ganaste = false;

            for (int indiceAnalizadorGanador = 0; indiceAnalizadorGanador < PalabrasAdivinadas.Length; indiceAnalizadorGanador++)
            {
                if (PalabrasAdivinadas[indiceAnalizadorGanador] != '-')
                {
                    ganaste = true;

                }
            }

            if (!ganaste)
            {
                MessageBox.Show("has ganado", "has ganado",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
                button1.Visible = true;
                pictureBox1.Visible = false;
                pictureBox1.Image = Image.FromFile("ganador1.png");
                pictureBox1.Visible = true;
            }
            
            if (!acertado)
            {
                oportunidades--;
                
                label1.Text = "Oportunidades: " + Convert.ToString(oportunidades).ToString();
                if (oportunidades == 0)
                {
                    flowLayoutPanel1.Enabled = false;
                    button1.Visible = true;

                    MessageBox.Show("has perdido", "has perdido",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
                    button1.Visible = true;
                    pictureBox2.Visible = false;
                    pictureBox2.Image = Image.FromFile("perdedor.jpg");
                    pictureBox2.Visible = true;
                }
            }
        }
    }
}
