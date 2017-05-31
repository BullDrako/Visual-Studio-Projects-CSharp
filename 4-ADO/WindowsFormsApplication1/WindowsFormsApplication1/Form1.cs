using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //para crear procedure: ir a la BBDD > rutinas > agregar nueva rutina
            //invoker
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Des d'aquest em connecto agregar referencia data.dll 
            //y poner using MySql.Data.MySqlClient;

            string stringConnection = null;
            MySqlConnection conn = null;
            stringConnection = "Server=localhost;Database=ebookshop;Uid=client;Pwd=client;"; //servidor, base de dades
            //Uid=cuenta de usuario;Pwd=contraseña;
            conn = new MySqlConnection(stringConnection);

            MySqlCommand command = null;
            MySqlCommand commandStored = null;
            //string consulta = "insert into book values(null, 'TitolC', 'AutorC', 45, 55);"; //sentencia directa
            // o "insert into book(titol, autor, pice, quantity) values('TitolC', 'AutorC', 45, 55);";
            //insert, delete y update va con executeNonQuery

            //sentencia preparada
            //string consulta = "insert into book values(null, @titol, @autor, @preu, @quantity);";

            string consultaDataReader = "select * from book where id = @id";

            try
            {
                conn.Open();//obrir conexion
                MessageBox.Show("M'he connectat!!!");
                /* command = new MySqlCommand(consulta, conn);
                 command.Parameters.Add(new MySqlParameter("@titol", "titolPre"));
                 command.Parameters.Add(new MySqlParameter("@autor", "autorPre"));
                 command.Parameters.Add(new MySqlParameter("@preu", 77));
                 command.Parameters.Add(new MySqlParameter("@quantity", 10));*/

                //con stored procedure
                /* command = new MySqlCommand();
                 command.Connection = conn;
                 command.CommandType = CommandType.StoredProcedure;
                 command.CommandText = "insertBook";
                 command.Parameters.Add(new MySqlParameter("@titol", "titolStored"));
                 command.Parameters.Add(new MySqlParameter("@autor", "autorStored"));
                 command.Parameters.Add(new MySqlParameter("@preu", 11));
                 command.Parameters.Add(new MySqlParameter("@quantity", 22));*/
                //

                //DataReader
                command = new MySqlCommand(consultaDataReader, conn);
                command.Parameters.Add(new MySqlParameter("@id", 1));
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    MessageBox.Show(" DataReader\n Consulta: select * from book where id = @id \n "+
                    "ID: " + reader.GetValue(0) + "; \n" +
                    "Titol: "+ reader.GetValue(1) + "; \n" +
                    "Autor: " + reader.GetValue(2) + "; \n" +
                    "Preu: " + reader.GetValue(3) + "; \n" +
                    "Quantitat: " + reader.GetValue(4) + "; \n");
                }
                reader.Close();

                //datareader procedure
                commandStored = new MySqlCommand();
                commandStored.Connection = conn;
                commandStored.CommandType = CommandType.StoredProcedure;
                commandStored.CommandText = "selectID1";
               

                MySqlDataReader reader2 = commandStored.ExecuteReader();

                while (reader2.Read())
                {
                    MessageBox.Show("DataReader Procedure \n Consulta: select * from book where id = 1 \n"+
                     "ID: " + reader2.GetValue(0) + "; \n" +
                    "Titol: " + reader2.GetValue(1) + "; \n" +
                    "Autor: " + reader2.GetValue(2) + "; \n" +
                    "Preu: " + reader2.GetValue(3) + "; \n" +
                    "Quantitat: " + reader2.GetValue(4) + "; \n");
                }
                reader2.Close();





                //int insertedRows= command.ExecuteNonQuery();//retornara files afectades
                //MessageBox.Show("S'han inserit " + insertedRows + " files");
            }
            catch (MySqlException error)
            {
                MessageBox.Show(error.Message);
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }
        }
    }
}
