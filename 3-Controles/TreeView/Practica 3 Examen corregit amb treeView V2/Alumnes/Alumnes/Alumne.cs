using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alumnes
{
    class Alumne
    {
        private string nom, cognoms, mobil1, mobil2, telefono, email, uf;

        public Alumne() { }

        public Alumne(string nom, string cognoms, string mobil1, string mobil2, string telefono, string email, string uf)
        {
            this.nom = nom;
            this.cognoms = cognoms;
            this.mobil1 = mobil1;
            this.mobil2 = mobil2;
            this.telefono = telefono;
            this.email = email;
            this.uf = uf;
        }

        public Alumne(Alumne a)
        {
            this.nom = a.getNom();
            this.cognoms = a.getCognoms();
            this.mobil1 = a.getMobil1();
            this.mobil2 = a.getMobil2();
            this.telefono = a.getTelefon();
            this.email = a.getEmail();
            this.uf = a.getUf();
        }

        //Getters and setters

        //Nom
        public String getNom() { return nom; }
        public void setNom(String value) { nom = value; }

        //Cognoms
        public String getCognoms() { return cognoms; }
        public void setCognoms(String value) { cognoms = value; }

        //Mobil1
        public String getMobil1() { return mobil1; }
        public void setMobil1(String value) { mobil1 = value; }

        //Mobil2 
        public String getMobil2() { return mobil2; }
        public void setMobil2(String value) { mobil2 = value; }

        //Telefon
        public String getTelefon() { return telefono; }
        public void setTelefon(String value) { telefono = value; }

        //Email
        public String getEmail() { return email; }
        public void setEmail(String value) { email = value; }

        //Uf 
        public String getUf() { return uf; }
        public void setUf(String value) { uf = value; }


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


            Alumne other = (Alumne)obj;

            if (!other.getNom().Equals(this.nom))
            {
                return false;
            }

            if (!other.getCognoms().Equals(this.cognoms))
            {
                return false;
            }

            if (!other.getMobil1().Equals(this.mobil1))
            {
                return false;
            }

            if (!other.getMobil2().Equals(this.mobil2))
            {
                return false;
            }

            if (!other.getTelefon().Equals(this.telefono))
            {
                return false;
            }

            if (!other.getEmail().Equals(this.email))
            {
                return false;
            }

            if (!other.getUf().Equals(this.uf))
            {
                return false;
            }

            return true;
        }

        //Mètode toString
        public String ToString()
        {
            return nom + " - " + cognoms + " - " + mobil1 + " - "  + mobil2 + " - " + telefono + " - " + email + " - " + uf;
        }

    }
}
