using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JuegoDados.Model
{
    class dado
    {

        private Random ran = new Random();
        private int numero;

        public dado()
        {
            this.numero = ran.Next(1, 7);        
        }

        public int getNumero()
        {
            this.numero = ran.Next(1, 7);
            return numero;   
        }

       public void setNumero()
        {
            this.numero = ran.Next(1,7);
        }

        public String toString()
        {
            String mensaje = numero.ToString();

            return mensaje;
        }
        

    }
}
