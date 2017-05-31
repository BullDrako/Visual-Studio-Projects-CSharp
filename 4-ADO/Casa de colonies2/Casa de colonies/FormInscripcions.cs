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
    public partial class FormInscripcions : Form
    {
        casacoloniesEntities db = new casacoloniesEntities();
        MySqlConnection connection = new MySqlConnection("Datasource=localhost;port=3306;username=root;password=");
        string niñoCarnetQuery = "SELECT * FROM casacolonies.niño";
        string tandaQuery = "SELECT * FROM casacolonies.tanda";
        string casaQuery = "SELECT * FROM casacolonies.casa";
        string insert_inscripciones_casa_tanda = "insert into inscripciones_casa_tanda values(@carnet, @fecha_inicio, @casa, @num_inscripcion);";


        public FormInscripcions()
        {
            InitializeComponent();

            //MySqlConnection connection = new MySqlConnection("Datasource=localhost;port=3306;username=root;password=");

            //niño
           // string niñoCarnetQuery = "SELECT * FROM casacolonies.niño";
            connection.Open();
            MySqlCommand command = new MySqlCommand(niñoCarnetQuery, connection);

            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                //listBox2.Items.Add(reader.GetString("codigo") + "  --> " + reader.GetString("descripcion"));
                comboBox1.Items.Add(reader.GetString("carnet"));
            }
            reader.Close();

            //tanda
            //string tandaQuery = "SELECT * FROM casacolonies.tanda";

            MySqlCommand command2 = new MySqlCommand(tandaQuery, connection);

            MySqlDataReader reader2 = command2.ExecuteReader();
            while (reader2.Read())
            {
                //listBox2.Items.Add(reader.GetString("codigo") + "  --> " + reader.GetString("descripcion"));
                comboBox2.Items.Add(reader2.GetString("fecha_inicio"));
            }
            reader2.Close();


            //casa
            //string casaQuery = "SELECT * FROM casacolonies.casa";

            MySqlCommand command3 = new MySqlCommand(casaQuery, connection);

            MySqlDataReader reader3 = command3.ExecuteReader();
            while (reader3.Read())
            {
                comboBox3.Items.Add(reader3.GetString("nombre"));
            }
            reader3.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //insertar

            string stringConnection = null;
            MySqlConnection conn = null;
            stringConnection = "Server=localhost;Database=casacolonies;Uid=root;Pwd=;"; //servidor, base de dades
                                                                                        //Uid=cuenta de usuario;Pwd=contraseña;
            conn = new MySqlConnection(stringConnection);

            MySqlCommand command = null;
            
          //  string insert_inscripciones_casa_tanda = "insert into inscripciones_casa_tanda values(@carnet, @fecha_inicio, @casa, @num_inscripcion);";
            
            try
            {

                conn.Open();//obrir conexion

                command = new MySqlCommand(insert_inscripciones_casa_tanda, conn);
                command.Parameters.Add(new MySqlParameter("@carnet", comboBox1.SelectedItem));
                command.Parameters.Add(new MySqlParameter("@fecha_inicio", comboBox2.SelectedItem));
                command.Parameters.Add(new MySqlParameter("@casa", comboBox3.SelectedItem));
                command.Parameters.Add(new MySqlParameter("@num_inscripcion", textBox1.Text));




                int insertedRows = command.ExecuteNonQuery();//retornara files afectades
                //MessageBox.Show("S'han inserit " + insertedRows + " files");
                MessageBox.Show("Inscricpion casa tanda ok");
                

            }
            catch (MySqlException error)
            {
                MessageBox.Show(error.Message);
            }


           inscripciones_casa_tanda ict = new inscripciones_casa_tanda();
            ict.carnet_niño = int.Parse(comboBox1.Text);
            textBox2.Text = comboBox2.Text;
            //DateTime fecha = comboBox2.Text;
            //ict.fecha_inicio = textBox2.;
            ict.nombre_casa = comboBox3.Text;
            ict.numero_inscripcion = int.Parse(textBox1.Text);


        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Modificar
            int num_carnet = int.Parse(textBox3.Text);

            try
            {

                inscripciones_casa_tanda ict = db.inscripciones_casa_tanda.First(car => car.carnet_niño == num_carnet);

                ict.fecha_inicio = dateTimePicker2.Value;
                ict.nombre_casa = textBox5.Text;
                ict.numero_inscripcion = Int32.Parse(textBox4.Text);
                


                db.SaveChanges();
                MessageBox.Show("Modificat exitós");
                MessageBox.Show("Modificació exitosa");
            }
            catch (Exception error)
            {
                MessageBox.Show("No existeix aquest usuari");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int num_carnet = int.Parse(textBox3.Text);
            try
            {
                inscripciones_casa_tanda ict = db.inscripciones_casa_tanda.First(car => car.carnet_niño == num_carnet);

                var carn = from car in db.inscripciones_casa_tanda select car;

                dateTimePicker2.Value = ict.fecha_inicio;
                textBox5.Text = ict.nombre_casa;
                textBox4.Text = ict.numero_inscripcion.ToString();
            }
            catch (Exception error)
            {
                MessageBox.Show("No existeix aquest carnet");
            }
        }
    }
}
