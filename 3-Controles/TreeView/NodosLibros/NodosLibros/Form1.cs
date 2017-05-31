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

namespace NodosLibros
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            try
            {
                TreeNode node = treeView1.SelectedNode;
                tISBN.Text = node.Nodes[0].Text;
                tNom.Text = node.Text;
                tPreu.Text = node.Nodes[1].Text;
                tDescripcio.Text = node.Nodes[2].Text;
                tAutor.Text = node.Nodes[3].Text;
                tEditor.Text = node.Nodes[4].Text;
                tColeccio.Text = node.Nodes[5].Text; ;
                dateTimePicker1.Text = node.Nodes[6].Text;
            }
            catch
            {
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String[] datos = new String[8];
            datos[0] = tISBN.Text;
            datos[1] = tNom.Text;
            datos[2] = tPreu.Text;
            datos[3] = tDescripcio.Text;
            datos[4] = tAutor.Text;
            datos[5] = tEditor.Text;
            datos[6] = tColeccio.Text;
            datos[7] = dateTimePicker1.Text;
            TreeNode ISBN = new TreeNode(datos[0]);
            TreeNode Preu = new TreeNode(datos[2]);
            TreeNode Descripcio = new TreeNode(datos[3]);
            TreeNode Autor = new TreeNode(datos[4]);
            TreeNode Editor = new TreeNode(datos[5]);
            TreeNode Coleccio = new TreeNode(datos[6]);
            TreeNode dateTime = new TreeNode(datos[7]);
            TreeNode[] info = new TreeNode[] { ISBN, Preu, Descripcio, Autor, Editor,
                                                    Coleccio, dateTime};
            // Final node.
            TreeNode libro = new TreeNode(datos[1], info);
            treeView1.Nodes.Add(libro);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            String[] datos;
            String linea;
            //Pass the file path and file name to the StreamReader constructor
            try
            {
                StreamReader sr = new StreamReader("libros.txt");

                //Read the data of text
                while ((linea = sr.ReadLine()) != null)
                {
                    datos = linea.Split(';');
                    TreeNode ISBN = new TreeNode(datos[0]);
                    TreeNode Preu = new TreeNode(datos[2]);
                    TreeNode Descripcio = new TreeNode(datos[3]);
                    TreeNode Autor = new TreeNode(datos[4]);
                    TreeNode Editor = new TreeNode(datos[5]);
                    TreeNode Coleccio = new TreeNode(datos[6]);
                    TreeNode dateTime = new TreeNode(datos[7]);
                    TreeNode[] info = new TreeNode[] { ISBN, Preu, Descripcio, Autor, Editor,
                                                    Coleccio, dateTime};
                    // Final node.
                    TreeNode libro = new TreeNode(datos[1], info);
                    treeView1.Nodes.Add(libro);
                }
                //close the file
                sr.Close();
            }
            catch (FileNotFoundException fnfe)
            {
                MessageBox.Show("No se ha encontrado archivo");
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            using (TextWriter writer = File.CreateText("libros.txt"))
                for (int i = 0; i < treeView1.Nodes.Count; i++)
                {
                    writer.WriteLine(treeView1.Nodes[i].Nodes[0].Text + ";" + treeView1.Nodes[i].Text + ";"
                        + treeView1.Nodes[i].Nodes[1].Text + ";" + treeView1.Nodes[i].Nodes[2].Text + ";" + treeView1.Nodes[i].Nodes[3].Text + ";"
                        + treeView1.Nodes[i].Nodes[4].Text + ";" + treeView1.Nodes[i].Nodes[5].Text + ";" + treeView1.Nodes[i].Nodes[6].Text + ";");
                }
        }
        private void passantInfo(object sender, EventArgs e)
        {
            TreeNode node = treeView1.SelectedNode;
            MessageBox.Show(string.Format("You selected: {0}", node.Text));
        }
    }
}
