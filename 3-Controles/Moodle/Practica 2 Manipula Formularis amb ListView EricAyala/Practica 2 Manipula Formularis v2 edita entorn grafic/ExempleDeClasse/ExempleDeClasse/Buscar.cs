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
    public partial class Buscar : Form
    {
        List<Contacte> contactes = new List<Contacte>();
        public Buscar()
        {
            InitializeComponent();
        }

        /*public Buscar(List<Contacte> contactes)
        {
            this.contactes = contactes;
            InitializeComponent();
        }*/

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String nom = textBox1.Text;
            textBox3.Text = "";

            foreach (Contacte c in contactes)
            {
                if(nom.Equals(c.getNom()))
                {
                    textBox3.Text += c.ToString() + "\r\n";
                }
            }

            if (textBox3.Text.Equals(""))
            {
                textBox3.Text = "Contacte no trobat";
            }
        }

        internal void setContactes(List<Contacte> agenda)
        {
            contactes = agenda;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            String telefon = textBox2.Text;
            textBox3.Text = "";

            foreach (Contacte c in contactes)
            {
                if (telefon.Equals(c.getTelefon()))
                {
                    textBox3.Text += c.ToString() + "\r\n";
                }
            }

            if(textBox3.Text.Equals(""))
            {
                textBox3.Text = "Contacte no trobat";
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
