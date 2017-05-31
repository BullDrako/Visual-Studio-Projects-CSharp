using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppRepasoExamen
{
    public partial class Agregar : Form
    {
        public Agregar()
        {
            InitializeComponent();
            Agenda agenda = Agenda.getInstance();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Agenda agenda = Agenda.getInstance();
            if (agenda != null)
            {
                bool verificar = true;
                Pelicula newPelicula = new Pelicula();
                newPelicula.Nombre = this.textBox1.Text;
                verificar = (this.textBox1.Text.Equals("")) ? false : true;
                if (this.textBox1.Text.Equals(""))
                {
                    this.errorProvider1.SetError(this.textBox1, "Ha de tenir valor.");
                }
                newPelicula.Director = this.textBox2.Text;
                verificar = (this.textBox2.Text.Equals("")) ? false : true;
                if (this.textBox2.Text.Equals(""))
                {
                    this.errorProvider1.SetError(this.textBox2, "Ha de tenir valor.");
                }
                newPelicula.Reparto = this.textBox3.Text;
                verificar = (this.textBox3.Text.Equals("")) ? false : true;
                if (this.textBox3.Text.Equals(""))
                {
                    this.errorProvider1.SetError(this.textBox3, "Ha de tenir valor.");
                }
                newPelicula.Pais = this.textBox4.Text;
                verificar = (this.textBox4.Text.Equals("")) ? false : true;
                if (this.textBox4.Text.Equals(""))
                {
                    this.errorProvider1.SetError(this.textBox4, "Ha de tenir valor.");
                }
                newPelicula.Año = this.dateTimePicker1.Value.ToString("yyyy");
                newPelicula.Duracion = this.numericUpDown1.Value.ToString();
                if (verificar)
                {
                    agenda.nuevaPelicula(newPelicula);
                    this.textBox1.Text = "";
                    this.textBox2.Text = "";
                    this.textBox3.Text = "";
                    this.textBox4.Text = "";
                }
            }
            this.Close();
        }

        private void keyPressString(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && !(char.IsSeparator(e.KeyChar)))
            {
                e.Handled = true;
            }
            else
            {
                errorProvider1.Clear();
            }
        }

        
    }
}
