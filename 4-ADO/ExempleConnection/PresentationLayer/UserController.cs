using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataLayer;

using System.Data;

namespace ControllerLayer
{
    public class UserController
    {
        public String checkTypeOfUser(string nickname, string password) {
            String result = "";
            User u = new User(nickname, password); //crear el usuario (llamando al constructor).
            UserADO helper = new UserADO(); //llamo a la clase que tiene el método.
            int profile = helper.checkUser(u);
            if (profile == -2) {
                result = "Unable to connect database.";
            } else if(profile == -1) {
                result = "User does not exist";
            } else {
                if(profile == 1) result = "Admin";
                else result = "Basic";
                //profile p = new Profile(profile);
                //return p.findById();
            }
            return result;
        }
    }
}
