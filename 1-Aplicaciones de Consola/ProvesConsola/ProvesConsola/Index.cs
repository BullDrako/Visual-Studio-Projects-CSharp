using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvesConsola
{
   public class Index
    {

        //atributos

        private float pes;
        private float alsada;
        
        //constructor 1 o mes
        public Index()
        {

        }

        public Index (float pes, float alsada)
        {
            this.pes = pes;
            this.alsada = alsada;
        }

        //   getter setters
        public float getPes()
        {
            return this.pes;
        }

        public void setPes(float pes)
        {
            this.pes = pes;
        }
        public float getAlsada()
        {
            return this.alsada;
        }

        public void setAlsada(float alsada)
        {
            this.alsada = alsada;
        }

        //  calcul
        // metode escriure com estas
    }
}
