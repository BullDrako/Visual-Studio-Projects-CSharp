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
    public partial class FormEnregistrarAccio : Form
    {
        casacoloniesEntities db = new casacoloniesEntities();
        MySqlConnection connection = new MySqlConnection("Datasource=localhost;port=3306;username=root;password=");
        string carrgarDatos = " SELECT * FROM casacolonies.monitor_tareas_tanda";

        MySqlCommand cmd;
        MySqlDataAdapter adapter;
        DataTable dt = new DataTable();

        public FormEnregistrarAccio()
        {
            InitializeComponent();
            connection.Open();

           /* dataGridView1.ColumnCount = 4;
            dataGridView1.Columns[0].Name = "DNI Monitor";
            dataGridView1.Columns[1].Name = "Codigo tarea";
            dataGridView1.Columns[2].Name = "Fecha inicio tanda";
            dataGridView1.Columns[3].Name = "Dia Tarea";*/

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            //SELECTION MODE
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;





            DataTable dtDatos = new DataTable();
            MySqlDataAdapter mdaDatos = new MySqlDataAdapter(carrgarDatos, connection);
            mdaDatos.Fill(dtDatos);
            dataGridView1.DataSource = dtDatos;
            connection.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {

            add(dataGridView1.Rows[0].ToString(), int.Parse(dataGridView1.Rows[1].ToString()), DateTime.Parse(dataGridView1.Rows[2].ToString()), DateTime.Parse(dataGridView1.Rows[3].ToString()));
        }

        private void add(string dni, int codTarea, DateTime fechaInicioTanda, DateTime diaTarea)
        {
            //SQL STMT
            string sql = "INSERT INTO monitor_tareas_tanda(dni_monitor,codigo_tarea,fecha_inicio_tanda, dia_tarea) VALUES(@dni,@codTarea,@fechaInicioTanda,@diaTarea)";
            cmd = new MySqlCommand(sql, connection);
            //ADD PARAMETERS
            cmd.Parameters.AddWithValue("@dni", dni);
            cmd.Parameters.AddWithValue("@codTarea", codTarea);
            cmd.Parameters.AddWithValue("@fechaInicioTanda", fechaInicioTanda);
            cmd.Parameters.AddWithValue("@diaTarea", diaTarea);
            //OPEN CON AND EXEC insert

            try
            {
                connection.Open();
                if (cmd.ExecuteNonQuery() > 0)
                {
                   // clearTxts();
                    MessageBox.Show("Successfully Inserted");
                }
                connection.Close();
                retrieve();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                connection.Close();
            }


        }


        //RETRIEVE FROM DB
        private void retrieve()
        {
            dataGridView1.Rows.Clear();
            //SQL STMT
            string sql = "SELECT * FROM monitor_tareas_tanda ";
            cmd = new MySqlCommand(sql, connection);
            //OPEN CON,RETRIEVE,FILL DGVIEW
            try
            {
                connection.Open();
                adapter = new MySqlDataAdapter(cmd);
                adapter.Fill(dt);
                //LOOP THRU DT
                foreach (DataRow row in dt.Rows)
                {
                    populate(row[0].ToString(), int.Parse(row[1].ToString()), DateTime.Parse(row[2].ToString()), DateTime.Parse(row[3].ToString()));
                }
                connection.Close();
                //CLEAR DT
                dt.Rows.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                connection.Close();
            }
        }

        //ADD TO DGVIEW
        private void populate(String dni, int codTarea, DateTime fechaInicioTanda, DateTime diaTarea)
        {
            dataGridView1.Rows.Add(dni, codTarea, fechaInicioTanda, diaTarea);
        }
    }
}
