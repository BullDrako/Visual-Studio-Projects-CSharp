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
            string consulta = "insert into book values(null, 'TitolC', 'AutorC', 45, 55);";
            // o "insert into book(titol, autor, pice, quantity) values('TitolC', 'AutorC', 45, 55);";
            //insert, delete y update va con executeNonQuery

            try
            {
                conn.Open();//obrir conexion
                MessageBox.Show("M'he connectat!!!");
                command = new MySqlCommand(consulta, conn);
                int insertedRows= command.ExecuteNonQuery();//retornara files afectades
                MessageBox.Show("S'han inserit " + insertedRows + " files");
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
