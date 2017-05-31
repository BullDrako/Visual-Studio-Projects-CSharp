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
    public partial class AdminForm : Form
    {
        String fileName;
        private List<Product> products = new List<Product>();
        public AdminForm()
        {
            this.WindowState = FormWindowState.Maximized;
            InitializeComponent();
        }

        private void AdminForm_Load(object sender, EventArgs e)
        {
            cargarFicheroProducts();
            CargarProductos();
        }

        public void cargarFicheroProducts()
        {
            openFileDialog1.FileName = "";

                String linea;
                //Pass the file path and file name to the StreamReader constructor
                try
                {
                    StreamReader sr = new StreamReader(@".\products.txt");

                    //Read the data of text
                    while ((linea = sr.ReadLine()) != null)
                    {
                        //Creem al mètode per crear un objecte Product a partir de la linia 
                        //i afegir-lo a la llista de productes
                        crearProducts(linea);
                    }

                    //close the file
                    sr.Close();
                }
                catch (FileNotFoundException fnfe)
                {
                    MessageBox.Show("No se ha encontrado archivo");
                }
            //}
        }


        private void crearProducts(string linea)
        {
         
            //Tabla de Strings que utilitzarem per separar per ; i crear l'objecte
            String[] datos;
            datos = linea.Split(';');

            //Creem el Producte amb les dades de la linia
            Product p = new Product();
            p.setCodi(datos[0]);
            p.setDescripcio(datos[1]);
            p.setId(datos[2]);
            p.setUnitats(datos[3]);
            p.setPreu(datos[4]);
           
            //Afegim el Producte a la llista de Productes.
            products.Add(p);
        }


        private void CargarProductos()
        {
            //Netegem el TreeView per poder omplir-hi les dades després
            treeView1.Nodes.Clear();

            //Realitzem el recorregut per tots els objectes Product de la llista de Productes
            foreach (Product p in products)
            {
                TreeNode Codi = new TreeNode(p.getCodi());
                TreeNode Descripcio = new TreeNode(p.getDescripcio());
                TreeNode Id = new TreeNode(p.getId());
                TreeNode Unitats = new TreeNode(p.getUnitats());
                TreeNode Preu = new TreeNode(p.getPreu());
                TreeNode[] info = new TreeNode[] { Codi, Descripcio, Id, Unitats, Preu };
                // Final node.
                TreeNode Product = new TreeNode(p.getCodi(), info);
                treeView1.Nodes.Add(Product);
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                //Creem un objecte de la classe AfegirFormulari
                AfegirForm afegirFormu = new AfegirForm();

                //Mostra el formulari
                if (afegirFormu.ShowDialog() == DialogResult.OK)
                {

                }

                //Un cop tancat el formulari edita les dades del producte i actualitza la llista
                Product p = afegirFormu.getProduct();
                products.Add(p);

                //Crida al mètode CargarProductos() perquè escrigui les dades corresponents al treeView
                CargarProductos();
            }
            catch (System.ArgumentOutOfRangeException)
            {

            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        Products prod = Products.getInstance();
            if (prod != null)
            {
                if (prod.Select != null)
                {
                    prod.borrarProduct(prod.Select);

                }
                actualizarDatos();
            }
        }


        private void actualizarDatos()
        {

            Products prod = Products.getInstance();
            this.treeView1.Nodes.Clear();
            

            for (int i = 0; i < prod.contarProductos(); i++)
            {
                Product product = prod.buscarProductIndexOf(i);
                TreeNode Codi = new TreeNode(product.getCodi());
                TreeNode Descripcio = new TreeNode(product.getDescripcio());
                TreeNode Id = new TreeNode(product.getId());
                TreeNode Unitats = new TreeNode(product.getUnitats());
                TreeNode Preu = new TreeNode(product.getPreu());
                
                TreeNode[] info = new TreeNode[] { Codi, Descripcio, Id, Unitats, Preu };
                TreeNode treeRoot = new TreeNode(product.getCodi(), info);
                this.treeView1.Nodes.Add(treeRoot);

                
            }
            

        }

        //Al tancar el formulari dona l'opció de guardar les dades a un fitxer
        private void AdminForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            saveFileDialog1.InitialDirectory = @".\Products.txt";
            saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            fileName = "Products.txt";
            saveFileDialog1.FileName = fileName;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //l'usuari ha escollit on vol guardar i quin arxiu vol guardar

                //obrir el fitxer saveFileDialog.Filename en mode escriptura
                using (StreamWriter sw = new StreamWriter(saveFileDialog1.FileName))
                {
                    //sw.WriteLine(textBox1.Text);

                    // sw.WriteLine(treeView1.Nodes[0].Text);

                    String resultat = "";

                    foreach (Product p in products)
                    {
                        resultat += p.getCodi() + ";";
                        resultat += p.getDescripcio() + ";";
                        resultat += p.getId() + ";";
                        resultat += p.getUnitats() + ";";
                        resultat += p.getPreu() + ";" + "\r\n";

                    }

                    sw.Write(resultat);

                }
            }
        }

        //Crear un nou producte al treeView des de l'icona full en blanc
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            newToolStripMenuItem_Click(sender, e);
        }
    }
}
