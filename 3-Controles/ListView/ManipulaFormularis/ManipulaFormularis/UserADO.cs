using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManipulaFormularis
{
    public class UserADO
    {

        /// <summary>
        /// Retorna tots els contactes del fitxer. Ha de ser de tipus static perquè se'n recordi cada cop que entro aqui
        /// </summary>
        /// <returns></returns>
        private static Users allUsers;
        /// <summary>
        /// Emmagatzema el nom del fitxer. Ha de ser de tipus static perquè se'n recordi cada cop que entro aqui
        /// </summary>
        /// <returns></returns>
        private static string fileName;

       /* public Users getAllUsers()
        {
            return allUsers;
        }*/
        public string FileName
        {
            get { return fileName; }
            set { fileName = value; }
        }
        public Users AllUsers
        {
            get { return allUsers; }
           
        }
        public UserADO()
        {


        }
        public UserADO(String nameFile)
        {
           FileName = nameFile;

        }

        public Users allFile()
        {
           allUsers = new Users();
           String line = "";
            try
            {
                StreamReader sr = new StreamReader(FileName);

                while ((line = sr.ReadLine()) != null)
                {
                   
                        String[] pieces = line.Split(':');
                        if (!pieces[0].Equals(""))
                        {
                            User oneUser = new User(pieces[0], pieces[1], Convert.ToInt32(pieces[2]), Convert.ToInt32(pieces[3]), pieces[4], pieces[5], pieces[6]);
                            allUsers.Add(oneUser);
                        }
                    
                }
                sr.Close();
            }
            catch (IOException errorIO)
            {
                allUsers = null;
            }
            return allUsers;

        }

        public Users searchField(String field)
        {
            int mobil=-1;
            string name="";
            Users searchedUsers = new Users();
            try
            {
                mobil=Convert.ToInt32(field);
            }catch(Exception){
                name = field;
            }
           
            foreach (User user in AllUsers)
            {
                if (user.Mobile == Convert.ToInt32(mobil) ||  user.Username.Equals(field))
                    searchedUsers.Add(user);
               
            }
            
            
            
            return searchedUsers;


        }
        public Users deleteUser(Users searchedUsers)
        {
            Users newUsers = new Users();
            
            foreach (User user in AllUsers)
            {
                foreach (User searched in searchedUsers)
                {
                    if (user.Mobile != searched.Mobile) newUsers.Add(user);
                    
                }
                

            }
           
            allUsers = newUsers;
            return allUsers;


        }
        public int saveAllFile()
        {

            int counter = 0;

            try
            {
                StreamWriter sw = new StreamWriter(FileName, false);

                foreach (User user in AllUsers)
                {
                        counter++;
                        sw.WriteLine(user.Username + ":" + user.Lastnames + ":" + user.Phone + ":" + user.Mobile + ":" + user.Address + ":" + user.City + ":" + user.Email);
                }

                sw.Close();
            }
            catch (Exception error)
            {
                counter = -1;
            }
            return counter;
        }
       
    }
}

