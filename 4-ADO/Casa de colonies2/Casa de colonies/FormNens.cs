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
    public partial class FormNens : Form
    {
        MySqlConnection connection = new MySqlConnection("Datasource=localhost;port=3306;username=root;password=");
        string niñoCarnetQuery = "SELECT * FROM casacolonies.poblacio";
        string poblacionQuery = "SELECT * FROM casacolonies.poblacio";

        public FormNens()
        {
            InitializeComponent();
            
            //niño
            connection.Open();
            MySqlCommand command = new MySqlCommand(niñoCarnetQuery, connection);

            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                //listBox2.Items.Add(reader.GetString("codigo") + "  --> " + reader.GetString("descripcion"));
                comboBox1.Items.Add(reader.GetString("codigo"));
            }
            reader.Close();

            MySqlCommand command2 = new MySqlCommand(poblacionQuery, connection);
            MySqlDataReader reader2 = command2.ExecuteReader();

            while (reader2.Read())
            {
                //listBox2.Items.Add(reader.GetString("codigo") + "  --> " + reader.GetString("descripcion"));
                comboBox2.Items.Add(reader2.GetString("codigo"));
            }
            reader2.Close();


        }

        casacoloniesEntities db = new casacoloniesEntities();
        private void button1_Click(object sender, EventArgs e)
        {
            //insertar nens
            if (/*!textBox6.Equals("") &&*/ !textBox7.Equals("") && !textBox8.Equals("") && !textBox9.Equals("") && !textBox10.Equals("") && !textBox11.Equals(""))
            {
                int carnet = Int32.Parse(textBox7.Text);
                String nom = textBox11.Text;
                String apellidos = textBox10.Text;
                String direccion = textBox9.Text;
                String sexo = textBox8.Text;
                int anyNaixement = Int32.Parse(textBox12.Text);
                
                //int anyNaixement2 = Int32.Parse(comboBox1.Text);
                //int codPoblacion = Int32.Parse(textBox6.Text);
                //String nomPoblacio = textBox13.Text;

                niño n = new niño();
                n.carnet = carnet;
                n.nombre = nom;
                n.apellidos = apellidos;
                n.direccion = direccion;
                n.sexo = sexo;
                n.año_nacimiento = anyNaixement;
                n.codigo_poblacion = int.Parse(comboBox1.Text);
                

               /* poblacio p = new poblacio();
                p.nombre = nomPoblacio;
                

                db.poblacio.Add(p);*/

                db.niño.Add(n);
               

                db.SaveChanges();
                
                MessageBox.Show("Insertado");
            }
            else
            {
                MessageBox.Show("Fill all fields with any data.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //buscar nen
            try
            {
                int carnet = int.Parse(textBox5.Text);
                niño n = db.niño.First(niño => niño.carnet == carnet);
                
                var niños = from niñ in db.niño select niñ;
                textBox4.Text = n.nombre;
                textBox3.Text = n.apellidos;
                textBox2.Text = n.direccion;
                textBox1.Text = n.sexo;
                textBox6.Text = n.año_nacimiento.ToString();
                comboBox2.Text = n.codigo_poblacion.ToString();
            }
            catch (Exception error)
            {
                MessageBox.Show("No esisteix aquest nen");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //actualizar nen
           
            int carnet = int.Parse(textBox5.Text);

            try
            {
                niño n = db.niño.First(niño => niño.carnet == carnet);
                var niños = from niñ in db.niño select niñ;

                n.nombre = textBox4.Text;
                n.apellidos = textBox3.Text;
                n.direccion = textBox2.Text;
                n.sexo = textBox1.Text;
                n.año_nacimiento = int.Parse(textBox6.Text);
                n.codigo_poblacion = int.Parse(comboBox2.Text);

                db.SaveChanges();
                MessageBox.Show("Modificat exitós");

            }
            catch (Exception error)
            {
                MessageBox.Show("No esisteix aquest usuari");
            }
        }
    }
}
