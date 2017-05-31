using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenFormsApp
{
    class User
    {
        private string nom, congoms, mobil1, mobil2, telefono, email, uf;
        public User(string nom, string congoms, string mobil1, string mobil2, string telefono, string email, string uf)
        {
            this.nom = nom;
            this.congoms = congoms;
            this.mobil1 = mobil1;
            this.mobil2 = mobil2;
            this.telefono = telefono;
            this.email = email;
            this.uf = uf;
        }
        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }
        public string Congoms
        {
            get { return congoms; }
            set { congoms = value; }
        }
        public string Mobil1
        {
            get { return mobil1; }
            set { mobil1 = value; }
        }
        public string Mobil2
        {
            get { return mobil2; }
            set { mobil2 = value; }
        }
        public string Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public string Uf
        {
            get { return uf; }
            set { uf = value; }
        }

    }
}
