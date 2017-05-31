using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExempleDeClasse
{
    class Contacte
    {
        //Atributtes
        String nom;
        String cognoms;
        String telefon;
        String movil;
        String email;


        //Constructors
        public Contacte() { }

        public Contacte(Contacte c)
        {
            this.nom = c.nom;
            this.cognoms = c.cognoms;
            this.telefon = c.telefon;
            this.movil = c.movil;
            this.email = c.email;
        }

        public Contacte(String nom, String cognoms,  String telefon, String movil,  String email)
        {
            this.nom = nom;
            this.cognoms = cognoms;
            this.telefon = telefon;
            this.movil = movil;
            this.email = email;
        }

        //Getters and Setters
        public string getNom() { return nom; }
        public string getCognoms() { return cognoms; }
        public string getTelefon() { return telefon; }
        public string getMovil() { return movil; }
        public string getEmail() { return email; }

        public void setNom(String nouNom) {
            nom = nouNom;
        }

        public void setCognoms(String nouCognoms) {
            cognoms = nouCognoms;
        }

        public void setTelefon(String nouTelefon) {
            telefon = nouTelefon;
        }

        public void setMovil(String nouMovil) {
            movil = nouMovil;
        }

        public void setEmail(String nouEmail) {
             email = nouEmail;
        }


        //toString
        public String ToString()
        {
            return "Contacte - " + nom + " - " + cognoms + " - " + telefon + " - " + movil + " - " + email;
        }
    }
}
