using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppRepasoExamen
{
    class Pelicula
    {
        private String nombre, director, reparto, pais, año, duracion;

        public Pelicula()
        {

        }

        public String Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public String Director
        {
            get { return director; }
            set { director = value; }
        }

        public String Reparto
        {
            get { return reparto; }
            set { reparto = value; }
        }

        public String Pais
        {
            get { return pais; }
            set { pais = value; }
        }

        public String Año
        {
            get { return año; }
            set { año = value; }
        }

        public String Duracion
        {
            get { return duracion; }
            set { duracion = value; }
        }

        public String toString() {
            return this.nombre + ":" + this.director + ":" + this.reparto + ":" + this.pais + ":" + this.año + ":" + this.duracion;
        }
    }
}
