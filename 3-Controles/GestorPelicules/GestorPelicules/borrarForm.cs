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
    public partial class borrarForm : Form
    {
        Pelicula pelicula = new Pelicula();

        public borrarForm()
        {
            InitializeComponent();
        }

        public void actualitzarDades()
        {
            pelicula.getTitol();
            pelicula.getDirector();
            pelicula.getActorsPrincipals();
            pelicula.getPais();
            pelicula.getAny();
            pelicula.getDurada();

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

    }
}
