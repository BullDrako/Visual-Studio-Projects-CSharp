using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppRepasoExamen
{
    class Agenda
    {
        private static Agenda instance = null;

        private ArrayList agenda = null;
        private Pelicula select = null;
        private String name = "";

        protected Agenda()
        {
            agenda = new ArrayList();
        }

        public static Agenda getInstance()
        {
            if (instance == null)
            {
                instance = new Agenda();
            }
            return instance;
        }

        public Pelicula Select
        {
            get { return select; }
            set { select = value; }
        }

        public String Name
        {
            get { return name; }
            set { name = value; }
        }

        public void nuevaPelicula(Pelicula pelicula) {
            this.agenda.Add(pelicula);
        }

        internal void borrarPelicula(Pelicula select)
        {
            agenda.Remove(select);
        }

        public int posicionPelicula(Pelicula pelicula) {
            for (int i = 0; i < agenda.Count; i++)
            {
                Pelicula cache = (Pelicula) agenda[i];
                if(pelicula.Nombre.Equals(cache.Nombre)) {
                    return i;
                }
            }
            return -1;
        }

        internal void actualizarPeliculas(Pelicula oldPelicula, Pelicula newPelicula)
        {
            this.agenda[posicionPelicula(oldPelicula)] = newPelicula;
        }

        public Pelicula buscarPeliculaIndexOf(int i) {
            return (Pelicula) this.agenda[i];

        }

        public int contarPeliculas() {
            return agenda.Count;
        }

        internal Pelicula buscarPeliculaPorNombre(string text)
        {
            for (int i = 0; i < agenda.Count; i++)
            {
                if (text.Equals(buscarPeliculaIndexOf(i).Nombre)) {
                    return buscarPeliculaIndexOf(i);
                }

            }
            return null;
        }

        
    }
}