using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionarPelicules
{
    public partial class AfegirForm : Form
    {
        Pelicula pelicula = new Pelicula();

        public AfegirForm()
        {
            InitializeComponent();
        }

        public void actualitzarDades()
        {
            textBox1.Text = pelicula.getTitol();
            textBox2.Text = pelicula.getDirector();
            textBox3.Text = pelicula.getActorsPrincipals();
            textBox4.Text = pelicula.getPais();
            textBox5.Text = pelicula.getAny();
            textBox6.Text = pelicula.getDurada();


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

            //Canvia les dades de l'alumne
            pelicula.setTitol(textBox1.Text);
            pelicula.setDirector(textBox2.Text);
            pelicula.setActorsPrincipals(textBox3.Text);
            pelicula.setPais(textBox4.Text);
            pelicula.setAny(textBox5.Text);
            pelicula.setDurada(textBox6.Text);


            //Amaga la finestra perque es modifiquin les dades actuals
            this.Close();

        }
    }
}
