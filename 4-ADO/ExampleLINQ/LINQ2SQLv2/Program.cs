using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ2SQLv2
{
    class Program
    {
        static void Main(string[] args)
        {

        }


      /*  static int login(String usuari, String contrassenya, linqDataContext db)
        {
            var list = (from a in db.Administradors
                        join p in db.Personal on a.DNI equals p.DNI
                        where p.DNI == usuari && p.mail == contrassenya
                        select new
                        {
                            titol = a.titulacio,

                        });

            if (!user.Any())
            {

                Console.WriteLine("dades incorrectes");
                return 0;
            }
            else if (user.First().titulacio == "super") //super
            {
                Console.WriteLine("Usuari {0} connectat com a super");
                return 1;
            }
            else if ()
            {

            }
        }*/
    }
}



/* var list = (from a in db.Administradors
                        join p in db.Personal on a.DNI equals p.DNI
                        where p.DNI == usuari
                        select new
                        {
                            titol = a.titulacio,
                            password = p.mail,
                            dni = p.DNI
                        });
            foreach (var r in list)
                if (r.dni == usuari && r.password == contrassenya && r.titol == "super")
            
    Personal newUser = new Personal();
            newUser.DNI = DNI;
            newUser.nom = nom;...
            db.Personal.InsertOnSubmit(newUser);
            db.SubmitChanges();
var user = (from p in db.Personal
                        where p.DNI == DNI
                        select p).First();
            user.mail = correu;
            db.SubmitChanges();
*/