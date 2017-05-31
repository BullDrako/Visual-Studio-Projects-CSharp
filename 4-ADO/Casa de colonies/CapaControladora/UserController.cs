using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaModel;
using System.Data;


namespace CapaControladora
{
   public class UserController
    {
        public String checkTypeOfUser(string nickname, string password)
        {
            String result = "";
            User u = new User(nickname, password); //crear el usuario (llamando al constructor).
            UserADO helper = new UserADO(); //llamo a la clase que tiene el método.
            int profile = helper.checkUser(u);
            if (profile == -2)
            {
                result = "Unable to connect database.";
            }
            else if (profile == -1)
            {
                result = "User does not exist";
  
            }
            else
            {
                if (profile == 1) result = "Super";
                else result = "Basic";
                //profile p = new Profile(profile);
                //return p.findById();
            }
            return result;
        }


        public static DataSet getAll()
        {
            UserADO helper = new UserADO();
            return helper.getAll();
        }




        public static String newAdmin(String dni, String nombre, String apellidos, String telefono, String email/*, String num_ss, String titulacion*/)
        {
            String message = "";
            int result;
            UserADO helper = new UserADO();
            User userAdmin = new User(dni, nombre, apellidos, telefono, email/*, num_ss, titulacion*/);
            result = helper.insertAdmin(userAdmin);
            if (result == 1)
            {
                message = "Admin successfully added";
            }
            else if (result == 0)
            {
                message = "Admin not added.";
            }
            else if (result == -1)
            {
                message = "Admin not added error.";
            }
            return message;
        }

    }
}
