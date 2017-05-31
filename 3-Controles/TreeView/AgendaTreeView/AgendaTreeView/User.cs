using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaTreeView
{
    public class User
    {
        #region My properties

        private string nom, congoms,  telefono, email, uf;
        private int mobil1, mobil2;

        #endregion

        #region My constructors

        public User()
        {

        }
        public User(string nom, string congoms, int mobil1, int mobil2, string telefono, string email, string uf)
        {
            this.nom = nom;
            this.congoms = congoms;
            this.mobil1 = mobil1;
            this.mobil2 = mobil2;
            this.telefono = telefono;
            this.email = email;
            this.uf = uf;
        }

        #endregion
        #region Accessors

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
        public int Mobil1
        {
            get { return mobil1; }
            set { mobil1 = value; }
        }
        public int Mobil2
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

        #endregion

        public String toString()
        {
            return this.nom + " " + this.congoms + " " + this.mobil1 + " " + this.mobil2 + " " + this.telefono + " " + this.email + " " + this.uf + "\r\n";

        }

    }
}
