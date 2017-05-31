using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MySql.Data.MySqlClient;
using System.Data;

namespace CapaModel
{
    public class UserADO
    {
        private static DBConnection dataSource;

        public UserADO()
        {
            dataSource = DBConnection.getInstance();//crido a la connexió
        }



        public int checkUser(User u)
        {
            MySqlConnection connection = null;
            MySqlCommand mysqlCmd = null;
            MySqlDataReader mysqlReader = null;

            MySqlConnection connection2 = null;
            MySqlCommand mysqlCmd2 = null;
            MySqlDataReader mysqlReader2 = null;

            //Unable to connect database.
            int profile = -2;

            string titulacion = "super";

            // string sql = "SELECT * FROM personal, administrador where dni='" + u.Nickname + "' and email='" + u.Password + "';";

            //select personal.dni, personal.email, administrador.titulacion from personal, administrador where personal.dni = "33333333C" and personal.email = "pfernandez@gmail.com"

            //string sql = "SELECT * FROM personal where `dni`='" + u.Nickname+"' and `email`='" + u.Password + "'";

            //  string sql = "SELECT * FROM personal p, administrador a where `p.dni`='" + u.Nickname + "' and `a.dni`='" + u.Nickname + "' and `email`='" + u.Password + "'";

            // string sql = "SELECT * FROM `personal` p, `administrador` a WHERE p.dni = '" + u.Nickname + "' and a.dni = '" + u.Nickname + "' and p.email ='" + u.Password + "' and a.titulacion = '" + titulacion + "'";

            //string sql = "SELECT * FROM `personal` p, `administrador` a WHERE p.dni = '" + u.Nickname + "' and a.dni = '" + u.Nickname + "' and p.email ='" + u.Password + "'";



            //string sql = "SELECT * FROM `personal` p, `administrador` a WHERE p.dni = '" + u.Nickname + "' and a.dni = '" + u.Nickname + "' and p.email ='" + u.Password + "'";

            string sql = "SELECT * FROM personal where `dni`='" + u.Nickname + "' and `email`='" + u.Password + "'";

            try
            {
                connection = dataSource.getConnection(); //Establecer la cadena de conexión.
                connection.Open(); //Open connection.

                //User does not exist.
                profile = -1;

                mysqlCmd = new MySqlCommand(sql, connection); //It makes the query
                mysqlReader = mysqlCmd.ExecuteReader(); //Executes query and get result.


                while (mysqlReader.Read())
                {
                    //if profile = 0 is an admin user else is a basic user.
                    //profile = mysqlReader.GetInt32("is_admin");
                    /*string titulacio = mysqlReader.GetString("titulacion");
                    //profile = 1; //aqui entra
                
                    if (titulacio == "super")
                    {
                        profile = 1;
                    } else
                    {
                        profile = 0;
                    }*/

                    string dni = mysqlReader.GetString("dni");
                    string email = mysqlReader.GetString("email");
                    
                    if (u.Nickname == dni && u.Password == email)
                    {
                        profile = 7;

                        string sql2 = "SELECT * FROM `personal` p, `administrador` a WHERE p.dni = '" + u.Nickname + "' and a.dni = '" + u.Nickname + "' and p.email ='" + u.Password + "'";

                        connection2 = dataSource.getConnection(); //Establecer la cadena de conexión.
                        connection2.Open();

                        mysqlCmd2 = new MySqlCommand(sql2, connection2); //It makes the query
                        mysqlReader2 = mysqlCmd2.ExecuteReader();

                        while (mysqlReader2.Read())
                        {

                            string titulacio = mysqlReader2.GetString("titulacion");


                            if (titulacio == "super")
                            {
                                profile = 1;
                            }
                            else if (titulacio == "admin")
                            {
                                profile = 3;
                            }
                            else
                            {
                                profile = 0;
                            }
                        }


                    }

                }
            }
            catch (MySqlException e)
            {
               
            }
            finally
            {
                if (mysqlCmd != null) mysqlCmd.Dispose();
                if (mysqlReader != null) mysqlReader.Dispose();
                if (connection != null) connection.Close();
                if (mysqlCmd2 != null) mysqlCmd2.Dispose();
                if (mysqlReader2 != null) mysqlReader2.Dispose();
                if (connection2 != null) connection2.Close();
            }
            return profile;
        }


        public DataSet getAll()
        {
            DataSet dataAdmins = new DataSet();
            MySqlConnection connection = null;
            MySqlCommand mysqlCmd = null;
            MySqlDataAdapter mysqlAdapter = null;
            String sql;
            sql = "SELECT * from administrador;";
            try
            {
                connection = dataSource.getConnection();
                connection.Open();
                mysqlCmd = new MySqlCommand(sql, connection);
                mysqlAdapter = new MySqlDataAdapter(mysqlCmd);
                mysqlAdapter.Fill(dataAdmins);
            }
            catch (Exception e)
            {
                dataAdmins = new DataSet();
            }
            finally
            {
                if (mysqlCmd != null) mysqlCmd.Dispose();
                if (mysqlAdapter != null) mysqlAdapter.Dispose();
                if (connection != null) connection.Close();
            }
            return dataAdmins;
        }


        public int insertAdmin(User user)
        {
            int result = -1;
            MySqlConnection connection = null;
            MySqlCommand mysqlCmd = null;
            String sql;
            sql = "INSERT INTO personal(dni,nombre,apellidos,telefono,email) values('" + user.Dni + "','" + user.Nombre + "','" + user.Apellidos + "'," + user.Telefono + ",'" + user.Email + ")";

           /* int result2 = -1;
            MySqlConnection connection2 = null;
            MySqlCommand mysqlCmd2 = null;
            String sql2;*/

           // sql2 = "INSERT INTO administrador(dni,num_SS,titulacion) values('" + user.Dni + "','" + user.Num_ss + "','" + user.Titulacion + ");";


            try
            {
                connection = dataSource.getConnection();
                connection.Open();
                mysqlCmd = new MySqlCommand(sql, connection);

                /*connection2 = dataSource.getConnection();
                connection2.Open();
                mysqlCmd2 = new MySqlCommand(sql2, connection2);*/

                result = mysqlCmd.ExecuteNonQuery();

               // result2 = mysqlCmd2.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                result = -1;
                //result2 = -1;
            }
            finally
            {
                if (mysqlCmd != null) mysqlCmd.Dispose();
                if (connection != null) connection.Close();

                /*if (mysqlCmd2 != null) mysqlCmd2.Dispose();
                if (connection2 != null) connection2.Close();*/
            }
            return result;
        }
    }
}

