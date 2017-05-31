using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Examen2M7
{
    public partial class Form1 : Form
    {
        String fileName;
        private List<User> agenda = new List<User>();
        User user = new User();
        public Form1()
        {
            InitializeComponent();
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String linea;
            //Pass the file path and file name to the StreamReader constructor
            try
            {
                StreamReader sr = new StreamReader("Users.txt");

                //Read the data of text
                while ((linea = sr.ReadLine()) != null)
                {
                    //Creem al mètode per crear un objecte Pel·licula a partir de la linia 
                    //i afegir-lo a la llista de Pel·licules
                    crearUser(linea);
                }

                //close the file
                sr.Close();
            }
            catch (FileNotFoundException fnfe)
            {
                MessageBox.Show("No se ha encontrado archivo");
            }

            foreach (User p in agenda)
            {
                if (textBox1.Text.Equals(p.getUserName()) && textBox2.Text.Equals(p.getPassword()) && p.getRole().Equals("admin"))
                {
                    AdminForm adminFormu = new AdminForm();
                    if (adminFormu.ShowDialog() == DialogResult.OK)
                    {
                        
                    }
                }
                

                if (textBox1.Text.Equals(p.getUserName()) && textBox2.Text.Equals(p.getPassword()) && p.getRole().Equals("basic"))
                {
                    SaleForm saleFormu = new SaleForm();
                    if (saleFormu.ShowDialog() == DialogResult.OK)
                    {
                        
                    }
                }
            }
        }

        

        private void crearUser(String linea)
        {
            //Tabla de Strings que utilitzarem per separar per ; i crear l'objecte
            String[] datos;
            datos = linea.Split(';');

            //Creem el user amb les dades de la linia
            User u = new User();
            u.setUserName(datos[0]);
            u.setPassword(datos[1]);
            u.setRole(datos[2]);

            //Afegim el user a la agenda.
            agenda.Add(u);
        }
    }
}
