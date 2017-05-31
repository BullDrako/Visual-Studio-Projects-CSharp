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

namespace AgendaTreeView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            String[] datos;
            String linea;
            //Pass the file path and file name to the StreamReader constructor
            try
            {
                StreamReader sr = new StreamReader("agenda.txt");

                //Read the data of text
                while ((linea = sr.ReadLine()) != null)
                {
                    datos = linea.Split(';');
                   // TreeNode Nom = new TreeNode(datos[0]);
                    TreeNode Cognoms = new TreeNode(datos[1]);
                    TreeNode Mobil1 = new TreeNode(datos[2]);
                    TreeNode Mobil2 = new TreeNode(datos[3]);
                    TreeNode TelefonoCasa = new TreeNode(datos[4]);
                    TreeNode Email = new TreeNode(datos[5]);
                    TreeNode Modulos = new TreeNode(datos[6]);
                    TreeNode[] info = new TreeNode[] {Cognoms, Mobil1, Mobil2, TelefonoCasa,
                                                    Email, Modulos};
                    // Final node.
                    TreeNode Nom = new TreeNode(datos[0], info);
                    treeView1.Nodes.Add(Nom);
                   
                }
                //close the file
                sr.Close();
            }
            catch (FileNotFoundException fnfe)
            {
                MessageBox.Show("No se ha encontrado archivo");
            }
        }

       

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            EditarForm editarFormu = new EditarForm();
          
                editarFormu.textBox1.Text = treeView1.Nodes.ToString();
                //editarFormu.textBox1.Text = treeView1.SelectedNode.Text;
                /* editarFormu.textBox2.Text = Cognoms.Text;
                 editarFormu.textBox3.Text = Mobil1.Text;
                 editarFormu.textBox4.Text = Mobil2.Text;
                 editarFormu.textBox5.Text = TelefonoCasa.Text;
                 editarFormu.textBox6.Text = Email.Text;
                 editarFormu.textBox7.Text = Modulos.Text;*/
             
            






            /* if (editarFormu.ShowDialog() == DialogResult.Abort)
             {
                 editarFormu.textBox1.Text = treeView1.Nodes.ToString();
             }*/

            //this.Hide();
            editarFormu.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            NouForm nouFomru = new NouForm();
           // nouFomru.ShowDialog();

            if (nouFomru.ShowDialog() == DialogResult.Cancel)
             {
                //EditarForm nouFomru1 = new EditarForm();
                // nouFomru1.ShowDialog();
               
                TreeNode Cognoms = new TreeNode();
                TreeNode Mobil1 = new TreeNode();
                TreeNode Mobil2 = new TreeNode();
                TreeNode TelefonoCasa = new TreeNode();
                TreeNode Email = new TreeNode();
                TreeNode Modulos = new TreeNode();
                TreeNode[] info = new TreeNode[] {Cognoms, Mobil1, Mobil2, TelefonoCasa,
                                                    Email, Modulos};

                
                // Final node.
                TreeNode Nom = new TreeNode();
                treeView1.Nodes.Add(Nom);
                Nom.Nodes.Add(Cognoms);
                Nom.Nodes.Add(Mobil1);
                Nom.Nodes.Add(Mobil2);
                Nom.Nodes.Add(TelefonoCasa);
                Nom.Nodes.Add(Email);
                Nom.Nodes.Add(Modulos);

                Nom.Text = nouFomru.textBox1.Text;
                Cognoms.Text = nouFomru.textBox2.Text;
                Mobil1.Text = nouFomru.textBox3.Text;
                Mobil2.Text = nouFomru.textBox4.Text;
                TelefonoCasa.Text = nouFomru.textBox5.Text;
                Email.Text = nouFomru.textBox6.Text;
                Modulos.Text = nouFomru.textBox7.Text;

                using (System.IO.StreamWriter file = new System.IO.StreamWriter("agenda.txt", true))
                {

                    file.WriteLine("\n" + Nom.Text + ";" + Cognoms.Text + ";" + Mobil1.Text + ";" + Mobil2.Text + ";" + TelefonoCasa.Text + ";" + Email.Text + ";" + Modulos.Text + ";");
                    
                }


            }


            /* if (nouFomru.ShowDialog() == DialogResult.Yes)
            {
                //textBox1.Text = "";
                UserADO listUsers = new UserADO();
                foreach (User user in listUsers.AllUsers)
                {
                    // textBox1.Text += user.toString();
                    

                }*/



        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }
    }  
}
