using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamenFormsApp
{
    public partial class Form1 : Form
    {
        //Variables generales
        private int contador = -1;
        private List<User> agenda = new List<User>();
        private TreeNode node = new TreeNode();

        public Form1()
        {
            InitializeComponent();

            //Variables para cargar los datos
            User foo;
            string[] lectura, telefono;
            string line = "";

            // Lectura de fichero para sacar los datos
            string path = @".\DAM2.txt";
            System.IO.StreamReader file = new System.IO.StreamReader(path, true);
            while ((line = file.ReadLine()) != null)
            {
                string nom = "", congoms = "", email = "", uf = "", mobil1 = "", mobil2 = "", casa = "";
                
                lectura = line.Split(':');
                nom = lectura[0];
                congoms = lectura[1];
                telefono = lectura[2].Split(',');
                if (!telefono[0].Equals(""))
                {
                    mobil1 = telefono[0];
                }
                if (!telefono[1].Equals(""))
                {
                    mobil2 = telefono[1];
                }
                if (!telefono[2].Equals(""))
                {
                    casa = telefono[2];
                }
                email = lectura[3];
                uf = lectura[4];

                //Creo los usuarios con los datos del fichero y los guardo en el List
                foo = new User(nom, congoms, mobil1, mobil2, casa, email, uf);
                agenda.Add(foo);
                contador++;

                //Muestro los datos en el TreeView
                User mostrar = agenda[contador];
                TreeNode cognoms = new TreeNode(mostrar.Congoms);
                TreeNode movil1 = new TreeNode(mostrar.Mobil1);
                TreeNode movil2 = new TreeNode(mostrar.Mobil2);
                TreeNode telef = new TreeNode(mostrar.Telefono);
                TreeNode mail = new TreeNode(mostrar.Email);
                TreeNode uff = new TreeNode(mostrar.Uf);
                TreeNode[] info = new TreeNode[] {cognoms,movil1,movil2,
                                                telef,mail,uff};
                TreeNode user = new TreeNode(mostrar.Nom, info);
                treeView1.Nodes.Add(user);
            }
            file.Close();
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(@".\DAM2.txt"))
            {
                for (int i = 0; i <= contador; i++)
                {
                    file.WriteLine(agenda[i].Nom + ":" + agenda[i].Congoms + ":" + agenda[i].Mobil1 + "," + agenda[i].Mobil2 + "," + agenda[i].Telefono + ":" + agenda[i].Email + ":" + agenda[i].Uf + ":");
                }
            }
            MessageBox.Show("Cambios guardados en fichero.", "Éxito");
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            try
            {
                //Guardo el nodo que selecciono para editarlo
                node = treeView1.SelectedNode;
            }
            catch { }
            
        }

        private void Click(object sender, EventArgs e)
        {
            Button clickedButton = (Button)sender;
            switch (clickedButton.Name)
            {
                case "buttonEditar":
                    if(!node.IsSelected)
                    {
                        MessageBox.Show("No ha seleccionado ninguno");
                    }else
                    {
                        //Si hay un node seleccionado muestro el form
                        FormEditar editar = new FormEditar(node);
                        if (editar.ShowDialog() == DialogResult.OK){}

                        string[] nodes = editar.getNodes();//Cojo los datos de la clase FormEditar
                        //Guardo los datos nuevos en el List
                        if (!nodes[0].Equals("")) { 
                            agenda[node.Index].Nom = nodes[0];
                            agenda[node.Index].Congoms = nodes[1];
                            agenda[node.Index].Mobil1 = nodes[2];
                            agenda[node.Index].Mobil2 = nodes[3];
                            agenda[node.Index].Telefono = nodes[4];
                            agenda[node.Index].Email = nodes[5];
                            agenda[node.Index].Uf = nodes[6];
                            //Muestro los datos nuevos en el TreeView
                            node.Text = agenda[node.Index].Nom;
                            node.Nodes[0].Text = nodes[1];
                            node.Nodes[1].Text = nodes[2];
                            node.Nodes[2].Text = nodes[3];
                            node.Nodes[3].Text = nodes[4];
                            node.Nodes[4].Text = nodes[5];
                            node.Nodes[5].Text = nodes[6];
                        }
                    }
                    break;
                case "buttonNuevo":
                    FormNuevo nuevo = new FormNuevo();
                    if (nuevo.ShowDialog() == DialogResult.OK) { }

                    string[] nodesNuevo = nuevo.getNodes();//Cojo los datos de la clase FormNuevo
                    //Si el atributo nombre del usuario no esta vacio guardo los datos
                    if (!nodesNuevo[0].Equals(""))
                    {
                        //Creo el nuevo usuario y lo guardo en el List
                        User foo = new User(nodesNuevo[0], nodesNuevo[1], nodesNuevo[2], nodesNuevo[3], nodesNuevo[4], nodesNuevo[5], nodesNuevo[6]);
                        agenda.Add(foo);
                        contador++;

                        //Muestro los datos del nuevo usuario en el TreeView
                        User mostrar = agenda[contador];
                        TreeNode cognoms = new TreeNode(mostrar.Congoms);
                        TreeNode movil1 = new TreeNode(mostrar.Mobil1);
                        TreeNode movil2 = new TreeNode(mostrar.Mobil2);
                        TreeNode telef = new TreeNode(mostrar.Telefono);
                        TreeNode mail = new TreeNode(mostrar.Email);
                        TreeNode uff = new TreeNode(mostrar.Uf);
                        TreeNode[] info = new TreeNode[] {cognoms,movil1,movil2,
                                                    telef,mail,uff};
                        TreeNode user = new TreeNode(mostrar.Nom, info);
                        treeView1.Nodes.Add(user);
                        MessageBox.Show("Contacto "+foo.Nom+" creado con exito");
                    }else
                    {
                        MessageBox.Show("No has introducido ningun dato");
                    }
                    break;
            }
        }
    }
}
