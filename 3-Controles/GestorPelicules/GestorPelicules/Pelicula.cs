using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorPelicules
{
    class Pelicula
    {
        private string titol, director, actorsPrincipals, pais, any, durada;

        public Pelicula()
        {

        }

        public Pelicula(string titol, string director, string actorsPrincipals, string pais, string any, string durada)
        {
            this.titol = titol;
            this.director = director;
            this.actorsPrincipals = actorsPrincipals;
            this.pais = pais;
            this.any = any;
            this.durada = durada;
        }

        public Pelicula(Pelicula p)
        {
            this.titol = p.getTitol();
            this.director = p.getDirector();
            this.actorsPrincipals = p.getActorsPrincipals();
            this.pais = p.getPais();
            this.any = p.getAny();
            this.durada = p.getDurada();
            
        }

        //Getters and setters

        //Titol
        public String getTitol() { return titol; }
        public void setTitol(String value) { titol = value; }

        //Director
        public String getDirector() { return director; }
        public void setDirector(String value) { director = value; }

        //ActorsPrincipals
        public String getActorsPrincipals() { return actorsPrincipals; }
        public void setActorsPrincipals(String value) { actorsPrincipals = value; }

        //Pais
        public String getPais() { return pais; }
        public void setPais(String value) { pais = value; }

        //Any
        public String getAny() { return any; }
        public void setAny(String value) { any = value; }

        //Durada
        public String getDurada() { return durada; }
        public void setDurada(String value) { durada = value; }


        //Sobrecarguem el mètode equals
        public Boolean Equals(Object obj)
        {
            if (this == obj)
            {
                return true;
            }

            if (obj == null)
            {
                return false;
            }


            Pelicula other = (Pelicula)obj;

            if (!other.getTitol().Equals(this.titol))
            {
                return false;
            }

            if (!other.getDirector().Equals(this.director))
            {
                return false;
            }

            if (!other.getActorsPrincipals().Equals(this.actorsPrincipals))
            {
                return false;
            }

            if (!other.getPais().Equals(this.pais))
            {
                return false;
            }

            if (!other.getAny().Equals(this.any))
            {
                return false;
            }

            if (!other.getDurada().Equals(this.durada))
            {
                return false;
            }

            return true;
        }


        //Mètode toString
        public String ToString()
        {
            return titol + " - " + director + " - " + actorsPrincipals + " - " + pais + " - " + any + " - " + durada;
        }
    }
}
