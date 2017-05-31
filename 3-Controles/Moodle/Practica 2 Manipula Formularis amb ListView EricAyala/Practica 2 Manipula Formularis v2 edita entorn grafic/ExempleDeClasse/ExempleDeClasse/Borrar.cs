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
    public partial class Borrar : Form
    {
        List<Contacte> contactes = new List<Contacte>();
        Contacte contacte = null;
        public Borrar()
        {
            InitializeComponent();
        }

        


        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        internal void setContactes(List<Contacte> agenda)
        {
            contactes = agenda;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (contacte != null)
            {
                contactes.Remove(contacte);
            }

            textBox1.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            String telefon = textBox2.Text;
            //textBox3.Text = "";

            foreach (Contacte c in contactes)
            {

                if (telefon.Equals(c.getTelefon()))
                {
                    contacte = c;
                }
            }

            if (contacte == null)
            {
                //TODO enviar missatge de no trobat
            }
            else
            {
                textBox1.Text = contacte.getNom();
                textBox3.Text = contacte.getCognoms();
                textBox4.Text = contacte.getTelefon();
                textBox5.Text = contacte.getMovil();
                textBox6.Text = contacte.getEmail();
            }
        }
    }
}
