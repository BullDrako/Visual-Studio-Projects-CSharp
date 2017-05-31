using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace AppRepasoExamen
{
    public partial class Actualizar : Form
    {
        public Actualizar()
        {
            InitializeComponent();
            Agenda agenda = Agenda.getInstance();
            Pelicula pelicula = agenda.Select;
            if (agenda.Select != null)
            {
                this.textBox1.Text = pelicula.Nombre;
                this.textBox2.Text = pelicula.Director;
                this.textBox3.Text = pelicula.Reparto;
                this.textBox4.Text = pelicula.Pais;
                this.dateTimePicker1.Value = DateTime.ParseExact(pelicula.Año, "yyyy", CultureInfo.InvariantCulture);
                this.numericUpDown1.Value = Int32.Parse(pelicula.Duracion);
            }
        }

        private void actualizar(object sender, EventArgs e)
        {
            Agenda agenda = Agenda.getInstance();
            if (agenda.Select != null)
            {
                bool verificar = true;
                Pelicula newPelicula = new Pelicula();
                Pelicula oldPelicula = agenda.Select;
                newPelicula.Nombre = this.textBox1.Text;
                verificar = (this.textBox1.Text.Equals("")) ? false : true;
                if (this.textBox1.Text.Equals(""))
                {
                    this.errorProvider1.SetError(this.textBox1, "Ha de tenir valor.");
                }
                newPelicula.Director = this.textBox2.Text;
                verificar = (this.textBox2.Text.Equals(""))? false : true;
                if (this.textBox2.Text.Equals("")) {
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
                    agenda.actualizarPeliculas(oldPelicula, newPelicula);
                    agenda.Select = newPelicula;
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
