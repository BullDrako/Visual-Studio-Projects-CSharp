using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EntityFrameworkEjemplo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        ebookshopEntities db = new ebookshopEntities(); //com si cridés a la base de dades
        
        private void button1_Click(object sender, EventArgs e)
        {
            //insert
            String usuari = textBox1.Text;
            String contrasenya = textBox2.Text;

            user u = new user();
            u.username = usuari; //u.setUsername(usuari) en java
            u.password = contrasenya;

            db.user.Add(u);//afegir
            db.SaveChanges();//guardar
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //delete
            string nomUsuari = textBox1.Text;

            try
            {
                user u = db.user.First(usuari => usuari.username == textBox1.Text); //=> cada registre
                db.user.Remove(u);
                db.SaveChanges();
                MessageBox.Show("Esborrat exitós");
            }
            catch (Exception error)
            {
                MessageBox.Show("No esisteix aquest usuari");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //update la contrasenya
            string nomUsuari = textBox1.Text;

            try
            {
                user u = db.user.First(usuari => usuari.username == textBox1.Text); //=> cada registre
                u.password = textBox2.Text;
                db.SaveChanges();
                MessageBox.Show("Modificat exitós");
            }
            catch (Exception error)
            {
                MessageBox.Show("No esisteix aquest usuari");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //busca per password

            string contrasenya = textBox2.Text;
            listBox1.Items.Clear();

            try
            {
                var usuarios = from usuario in db.user select usuario;

                if (usuarios.Any())
                {
                    foreach(user u in usuarios)
                    {
                        if (u.password.Equals(textBox2.Text)) //contrasenya
                        {
                            listBox1.Items.Add(u.username);
                        }
                    }
                }
            }
            catch (Exception error)
            {

            }
        }
    }
}
