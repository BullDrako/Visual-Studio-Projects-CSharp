using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen2M7
{
    class Product
    {

        private String codi, descripcio, id, unitats, preu ;
        //string ID = int.Parse(id);
        /*  codi del producte;descripció;identificador de la categoria a la qual hi pertany;unitats disponibles en magatzem;preu per unitat de producte;  */

        public Product()
        {

        }

        public Product(string codi, string descripcio, string id, string unitats, string preu)
        {
            this.codi = codi;
            this.descripcio = descripcio;
            this.id = id;
            this.unitats = unitats;
            this.preu = preu;
        }

        public Product(Product p)
        {
            
            this.codi = p.getCodi();
            this.descripcio = p.getDescripcio();
            this.id = p.getId();
            this.unitats = p.getUnitats();
            this.preu = p.getPreu();
        }

        //Getters and setters

        //codi
        public String getCodi() { return codi; }
        public void setCodi(String value) { codi = value; }

        //descripcio
        public String getDescripcio() { return descripcio; }
        public void setDescripcio(String value) { descripcio = value; }

        //id
        public string getId() { return id; }
        public void setId(string value) { id = value; }

        //unitats
        public String getUnitats() { return unitats; }
        public void setUnitats(String value) { unitats = value; }

        //Preu
        public String getPreu() { return preu; }
        public void setPreu(String value) { preu = value; }

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


            Product other = (Product)obj;

            if (!other.getCodi().Equals(this.codi))
            {
                return false;
            }

            if (!other.getDescripcio().Equals(this.descripcio))
            {
                return false;
            }

            if (!other.getId().Equals(this.id))
            {
                return false;
            }

            if (!other.getUnitats().Equals(this.unitats))
            {
                return false;
            }

            if (!other.getPreu().Equals(this.preu))
            {
                return false;
            }

            return true;
        }


        //Mètode toString
        public String ToString()
        {
            return codi + " - " + descripcio + " - " + id + " - " + unitats + " - " + preu;
        }

    }
}
