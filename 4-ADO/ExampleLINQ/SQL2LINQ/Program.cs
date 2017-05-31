using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL2LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            //string connectString = System.Configuration.conConnectionStrings["LinqToSQLDBConnectionString"].ToString();

            String DNI = "47181266D";
            String contrassenya = "dm.albareda@gmail.com";

            //agregar nuevo elemento --> clase de linq to sql-->  arrastrar las tablas
            linqDataContext db = new linqDataContext();


            int log = login(DNI, contrassenya, db);
            if (log == 1)
            {
                addPersonal("43212344Y", "Maite", "Ponts", "93372742", "mponts@gmail.com", db);
                modifyCorreuPersonal("43212344Y", "maite@xtec.cat", db);
                eliminarPersonal("21321312A", db);
            }
            Console.ReadLine();

        }
        static int login(String usuari, String contrassenya, linqDataContext db)
        {
            var list = (from a in db.Administradors
                        join p in db.Personal on a.DNI equals p.DNI
                        where p.DNI == usuari
                        select new
                        {
                            titol = a.titulacio,
                            password = p.mail,
                            dni = p.DNI //es = de a o de p
                        });
            foreach (var r in list)
            {
                Console.WriteLine(r);
                if (r.dni == usuari && r.password == contrassenya && r.titol == "super")
                {
                    Console.WriteLine("Usuari {0} , SuperAdministrador, S'ha identificat corrctament amb password {1}",
                                      r.titol, r.password);
                    return 1;
                }
                else if (r.dni == usuari && r.password == contrassenya)
                {
                    Console.WriteLine("Usuari {0} , Administrador, S'ha identificat corrctament amb password {1}",
                                      r.titol, r.password);
                    return 2;
                }
                else Console.WriteLine("Les dades introduïdes son incorrectes");





            }
            return 0;
        }
        static void addPersonal(String DNI, String nom, String cognom, String telefon, String correu, linqDataContext db)
        {
            Personal newUser = new Personal();
            newUser.DNI = DNI;
            newUser.nom = nom;
            newUser.cognom = cognom;
            newUser.telefon = telefon;
            newUser.mail = correu;

            db.Personal.InsertOnSubmit(newUser);
            db.SubmitChanges();

            Console.WriteLine("Usuari insertat");

        }
        static void modifyCorreuPersonal(String DNI, String correu, linqDataContext db)
        {
            var user = (from p in db.Personal
                        where p.DNI == DNI
                        select p).First();
            Console.WriteLine("antic correu {0} per a usuari {1}", user.mail, user.DNI);
            user.mail = correu;
            db.SubmitChanges();
            Console.WriteLine("nou correu {0} per a usuari {1}", user.mail, user.DNI);
        }
        static void eliminarPersonal(String DNI, linqDataContext db)
        {
            /*var adm = (from p in db.Administradors
                        where p.DNI == DNI
                        select p).First();
            var user = (from p in db.Personal
                        where p.DNI == DNI
                        select p).First();
            Console.WriteLine("eliminant usuari {0}", user.DNI);
            db.Administradors.DeleteOnSubmit(adm);
            db.Personal.DeleteOnSubmit(user);
            db.SubmitChanges();*/

            var user = (from p in db.Personal
                        where p.DNI == DNI
                        select p);
            var adm = (from a in db.Administradors
                       where a.DNI == DNI
                       select a);
            if (user.Any() && adm.Any())//la lista no esta vacia
            {
                Console.WriteLine("eliminant usuari {0}", user.First());
                db.Administradors.DeleteOnSubmit(adm.First());
                db.Personal.DeleteOnSubmit(user.First());
                db.SubmitChanges();
            }
            else
            {
                Console.WriteLine("Aprende a escribir");
            }
        }
    }
}
