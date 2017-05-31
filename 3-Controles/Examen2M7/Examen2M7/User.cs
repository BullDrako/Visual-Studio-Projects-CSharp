using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen2M7
{
    class User
    {
        private String userName, password, role;

        public User()
        {

        }

        public User(string userName, string password, string role)
        {
            this.userName = userName;
            this.password = password;
            this.role = role;
        }

        public User(User u)
        {
            this.userName = u.getUserName();
            this.password = u.getPassword();
            this.role = u.getRole();
        }

        //Getters and setters

        //userName
        public String getUserName() { return userName; }
        public void setUserName(String value) { userName = value; }

        //password
        public String getPassword() { return password; }
        public void setPassword(String value) { password = value; }

        //role
        public String getRole() { return role; }
        public void setRole(String value) { role = value; }


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


            User other = (User)obj;

            if (!other.getUserName().Equals(this.userName))
            {
                return false;
            }

            if (!other.getPassword().Equals(this.password))
            {
                return false;
            }

            if (!other.getRole().Equals(this.role))
            {
                return false;
            }

            return true;
        }


        //Mètode toString
        public String ToString()
        {
            return userName + " - " + password + " - " + role;
        }


    }


   
}
