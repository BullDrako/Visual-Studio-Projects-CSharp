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

                if (profile == 7) result = "Monitor";
                if (profile == 3) result = "Admin";
                if (profile == 1) result = "Super";
                    
                
                /*if (profile == 1) result = "Super";
                else result = "Basic";*/
                //profile p = new Profile(profile);
                //return p.findById();
            }
            return result;
        }
    }
}
