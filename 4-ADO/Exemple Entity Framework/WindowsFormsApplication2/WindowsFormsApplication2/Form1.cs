using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsEntity
{
    public partial class Form1 : Form
    {
    
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //login with an existing user
           


        }

        private void button2_Click(object sender, EventArgs e)
        {
            String nomUsuari = textBox1.Text;
            String contrasenya = textBox2.Text;
            users u = new users();
            u.username = nomUsuari;
            u.password = contrasenya;
            colonies.users.Add(u);
            colonies.SaveChanges();
            MessageBox.Show("Inserció correcta");
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
