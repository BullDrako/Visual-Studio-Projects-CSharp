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
    public partial class AfegirForm : Form
    {
        cuinaEntities db = new cuinaEntities();

        public AfegirForm()
        {
            InitializeComponent();

            for (int i=0; i<10; i++)
            {
                comboBox2.Items.Add(i);
            }
        }

     

        private void button1_Click(object sender, EventArgs e)
        {

            //insertar admin
            if (!textBox1.Equals("") && !textBox2.Equals("") && !textBox3.Equals("") && !textBox4.Equals(""))
            {
               
                receptes r = new receptes();
                r.nomRecepta = textBox1.Text;
                r.tempsPreparacioMinuts = int.Parse(textBox2.Text);
                r.ingredients = textBox3.Text;
                r.descripcioPreparacio = textBox4.Text;
                r.dificultat = int.Parse(comboBox2.Text);

                if(radioButton1.Checked == true)
                {
                    r.idCategoria = 1;
                }

                if (radioButton2.Checked == true)
                {
                    r.idCategoria = 2;
                }
               
               

                db.receptes.Add(r);

                
                db.SaveChanges();

                MessageBox.Show("Insertado");
            }
            else
            {
                MessageBox.Show("Fill all fields with any data.");
            }
        }
    }
}
