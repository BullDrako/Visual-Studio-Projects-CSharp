using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMC_Clase
{
    class Index
    {
           //atributos

            private float pes;
            private float alsada;
            private float imc;

            //constructor 1 o mes
            public Index()
            {

            }

            public Index(float pes, float alsada)
            {
                this.pes = pes;
                this.alsada = alsada;
            }

            //getters setters
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

            public float getImc()
            {
                return this.imc;
            }

            public void setImc(float imc)
            {
                this.imc = imc;
            }

             //calcul
            public float Calcula()
            {
                this.imc = getPes() / (getAlsada() * getAlsada());
                return (this.imc);
            }
           
            //metode escriure com estas
            public String ComEstas()
            {
                String value = "";
            if (this.getImc() < 18.5) value = "Prim";
            if (this.getImc() >= 18.5 && this.getImc() < 24.99) value = "Normal";
            if (this.getImc() > 25) value = "Sobrepes";
            if (this.getImc() > 30) value = "Obesitat";

            return value;

            }
        }
    }



