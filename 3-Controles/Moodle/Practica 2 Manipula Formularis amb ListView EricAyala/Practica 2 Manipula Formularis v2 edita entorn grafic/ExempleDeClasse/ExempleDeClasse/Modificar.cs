using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExempleDeClasse
{
    public partial class Modificar : Form
    {
        Contacte contacte = new Contacte();
        public Modificar()
        {
            InitializeComponent();
            //actualitzarDades();
        }

        public void actualitzarDades()
        {
            textBox1.Text = contacte.getNom();
            textBox3.Text = contacte.getCognoms();
            textBox4.Text = contacte.getTelefon();
            textBox5.Text = contacte.getMovil();
            textBox6.Text = contacte.getEmail();
        }

        internal void setContacte(Contacte c)
        {
            contacte = new Contacte(c);
            actualitzarDades();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            contacte.setNom(textBox1.Text);
            contacte.setCognoms(textBox3.Text);
            contacte.setTelefon(textBox4.Text);
            contacte.setMovil(textBox5.Text);
            contacte.setEmail(textBox6.Text);

            //Amaga la finestra perque es modifiquin les dades actuals
            this.Close();
        }

        internal Contacte getContacte()
        {
            return this.contacte;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
