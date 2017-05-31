using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegoDados.Model
{
    class player
    {
        private String nombre;
        private int puntaje;
            

       

        public player(string nombre, int puntaje)
        {
            this.nombre = nombre;
            this.puntaje = puntaje;
        }
        
        public string getNombre()
        {
             return nombre;            
        }
        public void setNombre(String nombre)
        {
           this.nombre = nombre;
        }

        public int getPuntaje()
        {
            return puntaje;
        }
        public void setPuntaje(int puntaje)
        {
            if (puntaje == 0)
            {
                this.puntaje = puntaje;
            }
            else
            {
                this.puntaje = this.puntaje + puntaje;
            }
            
        }
        
        public String toString()
        {
            String mensaje = "El jugador "+ this.nombre + " tiene " + this.puntaje + " puntos" ;

            return mensaje;
        }


        


    }
}
