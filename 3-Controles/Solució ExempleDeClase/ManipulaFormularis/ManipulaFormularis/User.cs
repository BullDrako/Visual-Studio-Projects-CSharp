
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManipulaFormularis
{
    public class User
    {
        #region My properties

        private String username;
        private String lastnames;
        private int phone;
        private int mobile;
        private String address;
        private String city;
        private String email;
        #endregion
        #region My constructors


        public User()
        {

        }
        public User(String username, String lastnames, int phone, int mobile, String address, String city, String email)
        {
            this.username = username;
            this.lastnames = lastnames;
            this.phone = phone;
            this.mobile = mobile;
            this.address = address;
            this.city = city;
            this.email = email;


        }
        #endregion
        #region Accessors


        public String Username
        {
            get { return username; }
            set { username = value; }

        }
        public String Lastnames
        {
            get { return lastnames; }
            set { lastnames = value; }

        }

        public int Phone
        {
            get { return phone; }
            set { phone = value; }
        }

        public int Mobile
        {
            get { return mobile; }
            set { mobile = value; }
        }

        public String Address
        {
            get { return address; }
            set { address = value; }

        }

        public String City
        {
            get { return city; }
            set { city = value; }

        }

        public String Email
        {
            get { return email; }
            set { email = value; }

        }

        

        #endregion
        
        public String toString()
        {
            return this.Username + " " + this.Lastnames + " " + this.Phone + " " + this.Mobile + " " + this.Address + " " + this.City + " " + this.Email+"\r\n";

        }
    }
}

