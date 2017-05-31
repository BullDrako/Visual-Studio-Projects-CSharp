using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamenAccesDades
{
    public partial class FormCategoriaPeix : Form
    {
        private static CapaModel.DBConnection dataSource;
        public FormCategoriaPeix()
        {
            InitializeComponent();
            MySqlConnection connection = null;
            MySqlCommand mysqlCmd = null;
            MySqlDataReader mysqlReader = null;

            dataSource = CapaModel.DBConnection.getInstance();//crido a la connexió


            string sql = "SELECT * FROM cuina.receptes where idCategoria = '2'";

            try
            {
                connection = dataSource.getConnection(); //Establecer la cadena de conexión.
                connection.Open(); //Open connection.

                mysqlCmd = new MySqlCommand(sql, connection); //It makes the query
                mysqlReader = mysqlCmd.ExecuteReader(); //Executes query and get result.

                while (mysqlReader.Read())
                {
                    ListViewItem lVI = listView1.Items.Add(mysqlReader.GetString("nomRecepta"));
                    lVI.SubItems.Add(mysqlReader.GetString("TempsPreparacioMinuts"));
                    lVI.SubItems.Add(mysqlReader.GetString("ingredients"));
                    lVI.SubItems.Add(mysqlReader.GetString("DescripcioPreparacio"));
                    lVI.SubItems.Add(mysqlReader.GetString("dificultat"));

                }
            }
            catch (Exception e)
            {

            }
        }
    }
}
