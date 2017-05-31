using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestorPelicules
{
    public partial class ActualitzarForm : Form
    {

        Pelicula pelicula = new Pelicula();

        public ActualitzarForm()
        {
            InitializeComponent();
        }

        public void actualitzarDades()
        {
            textBox1.Text = pelicula.getTitol();
            textBox2.Text = pelicula.getDirector();
            textBox3.Text = pelicula.getActorsPrincipals();
            textBox4.Text = pelicula.getPais();
            //nomes es guardi l'any del datepicker
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "yyyy";
            dateTimePicker1.ShowUpDown = true;
            //dateTimePicker1.Text = pelicula.getAny();
            numericUpDown1.Text = pelicula.getDurada();

        }


        internal void setPelicula(Pelicula p)
        {
            pelicula = new Pelicula(p);
            actualitzarDades();
        }

        internal Pelicula getPelicula()
        {
            return this.pelicula;
        }

        private void button1_Click(object sender, EventArgs e)
        {
           // if (textBox1.Text != "" || textBox2.Text != "" || textBox3.Text != "" || textBox4.Text != "")
           // {
                //Canvia les dades de l'alumne
                pelicula.setTitol(textBox1.Text);
                pelicula.setDirector(textBox2.Text);
                pelicula.setActorsPrincipals(textBox3.Text);
                pelicula.setPais(textBox4.Text);
                //nomes es guardi l'any del datepicker
                dateTimePicker1.Format = DateTimePickerFormat.Custom;
                dateTimePicker1.CustomFormat = "yyyy";
                dateTimePicker1.ShowUpDown = true;
                pelicula.setAny(dateTimePicker1.Text);
                pelicula.setDurada(numericUpDown1.Text);

                //Amaga la finestra perque es modifiquin les dades actuals
                this.Close();
           // }
            //else
           // {
             //   AlertaForm alertafromu = new AlertaForm();
              //  alertafromu.ShowDialog();
           // }
        }

        
    }
}
