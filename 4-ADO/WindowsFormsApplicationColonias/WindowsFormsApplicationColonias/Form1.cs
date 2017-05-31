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

namespace WindowsFormsApplicationColonias
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string stringConnection = null;
            MySqlConnection conn = null;
            stringConnection = "Server=localhost;Database=casacolonies;Uid=root;Pwd=;"; //servidor, base de dades
            //Uid=cuenta de usuario;Pwd=contraseña;
            conn = new MySqlConnection(stringConnection);

            MySqlCommand command = null;
            MySqlCommand commandStored = null;

            string consultaDataReader = "select * from personal where dni = @nickname and email = @password";

            try
            {
                conn.Open();//obrir conexion
                MessageBox.Show("M'he connectat!!!");

                command = new MySqlCommand(consultaDataReader, conn);
                command.Parameters.Add(new MySqlParameter("@nickname", "33333333C"));
                command.Parameters.Add(new MySqlParameter("@password", "pfernandez@gmail.com"));
                MySqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    MessageBox.Show(
                    "dni: " + reader.GetValue(0) + "; \n" +
                    "Nombre: " + reader.GetValue(1) + "; \n" +
                    "Apellido: " + reader.GetValue(2) + "; \n" +
                    "telefono: " + reader.GetValue(3) + "; \n" +
                    "email: " + reader.GetValue(4) + "; \n");
                }
                reader.Close();

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
