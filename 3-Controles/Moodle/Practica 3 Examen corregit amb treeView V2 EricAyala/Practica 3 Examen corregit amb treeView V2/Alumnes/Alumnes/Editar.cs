using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Alumnes
{
    public partial class Editar : Form
    {
        Alumne alumne = new Alumne();
        public Editar()
        {
            InitializeComponent();
        }


        public void actualitzarDades()
        {
            textBox1.Text = alumne.getNom();
            textBox3.Text = alumne.getCognoms();
            textBox4.Text = alumne.getMobil1();
            textBox5.Text = alumne.getMobil2();
            textBox6.Text = alumne.getTelefon();
            textBox2.Text = alumne.getEmail();
            textBox7.Text = alumne.getUf();
        }


        internal void setAlumne(Alumne a)
        {
            alumne = new Alumne(a);
            actualitzarDades();
        }

        internal Alumne getAlumne()
        {
            return this.alumne;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Canvia les dades de l'alumne
            alumne.setNom(textBox1.Text);
            alumne.setCognoms(textBox3.Text);
            alumne.setMobil1(textBox4.Text);
            alumne.setMobil2(textBox5.Text);
            alumne.setTelefon(textBox6.Text);
            alumne.setEmail(textBox2.Text);
            alumne.setUf(textBox7.Text);

            //Amaga la finestra perque es modifiquin les dades actuals
            this.Close();
        }
    }
}
