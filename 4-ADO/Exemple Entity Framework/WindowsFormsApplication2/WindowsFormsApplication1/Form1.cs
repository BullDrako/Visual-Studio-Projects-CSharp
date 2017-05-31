using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        coloniesEntities colonies = new coloniesEntities();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nomUsuari = textBox1.Text;
            string contrassenya = textBox2.Text;
            users u = new users();
            u.username = nomUsuari;
            u.password = contrassenya;
            colonies.users.Add(u);
            try
            {
                colonies.SaveChanges();
                MessageBox.Show("Inserció exitosa");
            }catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //DELETING
            string nomUsuari = textBox1.Text;
            try
            {
                users u = colonies.users.First(usuari => usuari.username == nomUsuari);
                colonies.users.Remove(u);
                colonies.SaveChanges();
                MessageBox.Show("Esborrat exitós");
            }
            catch (Exception error)
            {
                MessageBox.Show("No existeix aquest usuari");
            }


        }

        private void button4_Click(object sender, EventArgs e)
        {
            //UPDATING
            string nomUsuari = textBox1.Text;
            try {
            users u=colonies.users.First(usuari=>usuari.username == nomUsuari);
                u.password = textBox2.Text;
                colonies.SaveChanges();
                MessageBox.Show("Modificació exitosa");
            }catch(Exception error)
            {
                MessageBox.Show("No existeix aquest usuari");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Login
            string nomUsuari = textBox1.Text;
            string contrassenya = textBox2.Text;
            users u = new users();
           
            try
            {
                u = colonies.users.First(usuari => usuari.username == nomUsuari);
                if (u.password == contrassenya)
                {

                    MessageBox.Show("Login correcte exitosa");
                }
                else
                {
                    MessageBox.Show("Usuari i/o password incorrectes");

                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Usuari i/o password incorrectes (bis)");
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            //Search users with the same password
            
            string contrassenya = textBox2.Text;
            listBox1.Items.Clear();

            try
            {
                var usuarios = from usuario in colonies.users
                               select usuario;
                if (usuarios.Count() == 0) { 

                    foreach (users u in usuarios)
                    {
                        if (u.password.Equals(contrassenya))
                        {
                            listBox1.Items.Add(u.username);

                        }

                    }
                }else
                {
                    MessageBox.Show("No hi ha usuaris a la taula!!");
                }
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }
    }
}
