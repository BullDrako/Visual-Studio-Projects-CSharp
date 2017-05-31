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


namespace Casa_de_colonies
{
    public partial class FormActivitatCases : Form
    {
        casacoloniesEntities db = new casacoloniesEntities();

        MySqlConnection connection = new MySqlConnection("Datasource=localhost;port=3306;username=root;password=");
        string activitatsQuery = "SELECT * FROM casacolonies.activitat";
        string casaQuery = "SELECT * FROM casacolonies.casa";
        string asociarCasaActivitatCasaQuery = "insert into actividad_casa values(@cod_act, @cod_casa, @nivel, @calidad);";


        public FormActivitatCases()
        {
            InitializeComponent();

            connection.Open();
            MySqlCommand command = new MySqlCommand(activitatsQuery, connection);
           
            MySqlDataReader reader = command.ExecuteReader();
            listBox2.Items.Add("Codigos y Nombres de las Actividades");
            while (reader.Read())
            {
                listBox2.Items.Add(reader.GetString("codigo") + "  --> " + reader.GetString("descripcion"));
                comboBox1.Items.Add(reader.GetString("codigo")); 
            }
            reader.Close();

            MySqlCommand command2 = new MySqlCommand(casaQuery, connection);
            MySqlDataReader reader2 = command2.ExecuteReader();
            listBox1.Items.Add("Codigos y Nombres de las Casas");
            while (reader2.Read())
            {
                comboBox2.Items.Add(reader2.GetString("codigo"));
                //comboBox2.Items.Add(reader2.GetString("nombre");
                listBox1.Items.Add(reader2.GetString("codigo") +  " --> "+ reader2.GetString("nombre"));
            }


            System.Object[] ItemObject = new System.Object[11];
            for (int i = 0; i <= 10; i++)
            {
                ItemObject[i] = i;
            }
            comboBox3.Items.AddRange(ItemObject);
            comboBox4.Items.AddRange(ItemObject);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string stringConnection = null;
            MySqlConnection conn = null;
            stringConnection = "Server=localhost;Database=casacolonies;Uid=root;Pwd=;"; //servidor, base de dades
                                                                                        //Uid=cuenta de usuario;Pwd=contraseña;
            conn = new MySqlConnection(stringConnection);

            MySqlCommand command = null;

            try
            {
                conn.Open();//obrir conexion
                
                command = new MySqlCommand(asociarCasaActivitatCasaQuery, conn);
                command.Parameters.Add(new MySqlParameter("@cod_act", comboBox1.SelectedItem));
               
                command.Parameters.Add(new MySqlParameter("@cod_casa", comboBox2.SelectedItem));
                command.Parameters.Add(new MySqlParameter("@nivel", comboBox3.SelectedItem));
                command.Parameters.Add(new MySqlParameter("@calidad", comboBox4.SelectedItem));
                
               
                int insertedRows = command.ExecuteNonQuery();//retornara files afectades
                //MessageBox.Show("S'han inserit " + insertedRows + " files");
                MessageBox.Show("Casa i Activitat asociada");
            }
            catch (MySqlException error)
            {
                MessageBox.Show(error.Message);
            }
        }  
    }
}
