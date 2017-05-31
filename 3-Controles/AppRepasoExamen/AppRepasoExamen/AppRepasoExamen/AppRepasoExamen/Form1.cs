using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppRepasoExamen
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        private bool groupBox = false, treeView = true, loadFile = false;
        public Form1()
        {
            this.WindowState = FormWindowState.Maximized;
            InitializeComponent();
            accionsToolStripMenuItem.Enabled = false;
            this.groupBox1.Visible = groupBox;
        }

        private void Form_Load(object sender, EventArgs e)
        {

        }

        private void obrir(object sender, EventArgs e)
        {
            Agenda agenda = Agenda.getInstance();
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.Filter = "Text files (*.txt)|*.txt|(*.data)|*.data";
            openFileDialog1.InitialDirectory = "D:";
            openFileDialog1.FileName = "";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                agenda.Name = openFileDialog1.FileName;
                try
                {
                    using (StreamReader sr = new StreamReader(openFileDialog1.FileName))
                    {
                        string line;

                        while ((line = sr.ReadLine()) != null)
                        {
                            String[] linea = line.Split(':');
                            Pelicula pelicula = new Pelicula();
                            pelicula.Nombre = linea[0];
                            pelicula.Director = linea[1];
                            pelicula.Reparto = linea[2];
                            pelicula.Pais = linea[3];
                            pelicula.Año = linea[4];
                            pelicula.Duracion = linea[5];
                            agenda.nuevaPelicula(pelicula);
                        }
                    }

                    toolStrip1.Enabled = true;
                    accionsToolStripMenuItem.Enabled = true;
                    actualizarPizarra();
                    this.loadFile = true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("The file could not be read: " + agenda.Name);
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    
                }
            }

        }

        private void guardar(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            Agenda agenda = Agenda.getInstance();
            saveFileDialog1.Filter = "Text files *.txt|*.data";
            saveFileDialog1.InitialDirectory = "D:";
            saveFileDialog1.FileName = agenda.Name;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (StreamWriter sw = new StreamWriter(saveFileDialog1.FileName))
                    {
                        for (int x = 0; x < agenda.contarPeliculas(); x++)
                        {
                            sw.Write(agenda.buscarPeliculaIndexOf(x).toString() + "\r\n");
                        }

                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("The file could not be read:");
                    Console.WriteLine(ex.Message);
                }
            }
        }

        private void salir(object sender, EventArgs e)
        {
            Agenda agenda = Agenda.getInstance();
            
            guardar(sender, e);
            Close();
                
           
        }

        private void afterSelect(object sender, TreeViewEventArgs e)
        {
            try
            {
                Agenda agenda = Agenda.getInstance();
                TreeNode node = treeView1.SelectedNode;
                agenda.Select = agenda.buscarPeliculaPorNombre(node.Nodes[0].Text);
            }catch(Exception error)
            {

            }
        }

        private void agregar(object sender, EventArgs e)
        {
            Agenda agenda = Agenda.getInstance();
            if (agenda != null) {
                Agregar oAgregar = new Agregar();
                var resultado = oAgregar.ShowDialog();
                if (resultado == DialogResult.Cancel)
                {
                    actualizarPizarra();
                }
            }
        }



        private void actualizar(object sender, EventArgs e)
        {
            Agenda agenda = Agenda.getInstance();
            if (agenda != null)
            {
                Actualizar oActualizar = new Actualizar();
                var resultado = oActualizar.ShowDialog();
                if (resultado == DialogResult.Cancel)
                {
                    actualizarPizarra();
                }
            }

        }

        private void Eliminar(object sender, EventArgs e)
        {
            Agenda agenda = Agenda.getInstance();
            if (agenda != null)
            {
                if (agenda.Select != null)
                {
                    agenda.borrarPelicula(agenda.Select);

                }
                actualizarPizarra();
            }
        }

        private void buscar(object sender, EventArgs e)
        {
            this.groupBox = !this.groupBox;
            this.groupBox1.Visible = this.groupBox;
        }

        

        private void actualizarPizarra()
        {
            Agenda agenda = Agenda.getInstance();
            this.treeView1.Nodes.Clear();
            this.listView1.Items.Clear();

            for (int i = 0; i < agenda.contarPeliculas(); i++)
            {
                Pelicula pelicula = agenda.buscarPeliculaIndexOf(i);
                TreeNode Nombre = new TreeNode(pelicula.Nombre);
                TreeNode Director = new TreeNode(pelicula.Director);
                TreeNode Reparto = new TreeNode(pelicula.Reparto);
                TreeNode Pais = new TreeNode(pelicula.Pais);
                TreeNode Año = new TreeNode(pelicula.Año);
                TreeNode Duracion = new TreeNode(pelicula.Duracion);
                TreeNode[] info = new TreeNode[] { Nombre, Director, Reparto, Pais, Año, Duracion };
                TreeNode treeRoot = new TreeNode(pelicula.Nombre, info);
                this.treeView1.Nodes.Add(treeRoot);

                ListViewItem viewItem = new ListViewItem(pelicula.Nombre);
                viewItem.SubItems.Add(pelicula.Director);
                viewItem.SubItems.Add(pelicula.Reparto);
                viewItem.SubItems.Add(pelicula.Pais);
                viewItem.SubItems.Add(pelicula.Año);
                viewItem.SubItems.Add(pelicula.Duracion);
                this.listView1.Items.Add(viewItem);
            }
            

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            String name = this.comboBox1.SelectedItem.ToString();
            switch (name) {
                case "Actor":
                    setActorActualizar(name);
                    break;
                case "Director":
                    setActorActualizar(name);
                    break;
                default:
                    actualizarPizarra();
                    break;

            }
                 
        }

        private void setActorActualizar(String name)
        {
            Agenda agenda = Agenda.getInstance();
            this.listView1.Items.Clear();

            for (int i = 0; i < agenda.contarPeliculas(); i++)
            {
                Pelicula pelicula = agenda.buscarPeliculaIndexOf(i);
                ListViewItem viewItem = new ListViewItem("");
                if (name.Equals("Director")){
                    viewItem.SubItems.Add(pelicula.Director);
                } else {
                    viewItem.SubItems.Add("");
                }
                if (name.Equals("Actor"))
                {
                    viewItem.SubItems.Add(pelicula.Reparto);
                }
                else
                {
                    viewItem.SubItems.Add("");
                }
                viewItem.SubItems.Add("");
                viewItem.SubItems.Add("");
                viewItem.SubItems.Add("");
                this.listView1.Items.Add(viewItem);
            }
        }

        private void aparençaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            contextMenuStrip1.Show();
        }

        private void Scroll(object sender, EventArgs e)
        {
            if (this.loadFile)
            {
                this.treeView1.Scrollable = this.treeView;
                this.treeView = !this.treeView;
            }
        }

        private void font(object sender, EventArgs e)
        {
            if (this.loadFile)
            {
                FontDialog fontDialog1 = new FontDialog();
                if (fontDialog1.ShowDialog() == DialogResult.OK)
                {
                    treeView1.Font = fontDialog1.Font;
                }
            }
        }
    }
}
