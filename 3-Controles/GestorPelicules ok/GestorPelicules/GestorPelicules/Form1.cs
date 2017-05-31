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

namespace GestorPelicules
{
    public partial class Form1 : Form
    {
        String fileName;
        private List<Pelicula> peliculas = new List<Pelicula>();

        public Form1()
        {
            InitializeComponent();
            groupBox1.Visible = false;
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

       
        //Abrir Fichero
        private void obrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            carrgarDatos();
        }


        //Mètode que carrega totes les dades procedents de l'arxiu als atributs i objectes del form 
        private void carrgarDatos()
        {
            //Obre les dades del fitxer per poder fer les operacions línia a lina
            CargarFichero();
            //Carrega les dades de les pel·licules al TreeView
            CargarPeliculas();
        }

        private void CargarFichero()
        {
           openFileDialog1.FileName = "";

            if (openFileDialog1.ShowDialog() /*modal*/ == DialogResult.OK) //si se  ha abierto abre o se cierra
            {
                int pos;
                pos = openFileDialog1.FileName.LastIndexOf('\\');
                fileName = openFileDialog1.FileName.Substring(pos + 1);

                String linea;
                //Pass the file path and file name to the StreamReader constructor
                try
                {
                    StreamReader sr = new StreamReader("peliculas.txt");

                    //Read the data of text
                    while ((linea = sr.ReadLine()) != null)
                    {
                        //Creem al mètode per crear un objecte Pel·licula a partir de la linia 
                        //i afegir-lo a la llista de Pel·licules
                        crearPeliculas(linea);
                    }

                    //close the file
                    sr.Close();
                }
                catch (FileNotFoundException fnfe)
                {
                    MessageBox.Show("No se ha encontrado archivo");
                }
            }
        }


        //Habilitar SCROLL click dret
        private void habilitarScrollToolStripMenuItem_Click(object sender, EventArgs e)
        {
            treeView1.BorderStyle = BorderStyle.FixedSingle;
            treeView1.Scrollable = true;
        }

        //Canviar FONT click dret
        private void canviarTipusDeFontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                treeView1.Font = fontDialog1.Font;
            }
        }

        //Anomena i Desa menu
        private void anomenaIDesaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //saveFileDialog1.InitialDirectory = "F:\\_CFGS\\CFGS DAM\\M7\\Controls\\GestorPelicules\\GestorPelicules\\bin\\Debug";
            saveFileDialog1.InitialDirectory = @".\peliculas.txt";
            saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
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

                    foreach (Pelicula p in peliculas)
                    {
                        resultat += p.getTitol() + ":";
                        resultat += p.getDirector() + ":";
                        resultat += p.getActorsPrincipals() + ":";
                        resultat += p.getPais() + ":";
                        resultat += p.getAny() + ":";
                        resultat += p.getDurada() + ":" + "\r\n";
                        
                    }

                    sw.Write(resultat);

                }
            }
        }

        //Mètode que crea i afegeix a la llista dde pel·licules segons una linia.
        private void crearPeliculas(String linea)
        {
            //Tabla de Strings que utilitzarem per separar per : i crear l'objecte
            String[] datos;
            datos = linea.Split(':');

            //Creem la Pel·licula amb les dades de la linia
            Pelicula e = new Pelicula();
            e.setTitol(datos[0]);
            e.setDirector(datos[1]);
            e.setActorsPrincipals(datos[2]);
            e.setPais(datos[3]);
            e.setAny(datos[4]);
            e.setDurada(datos[5]);
          
            //Afegim la Pel·licula a la llista de Pel·licules.
            peliculas.Add(e);
        }



        //Mètode que carrega totes les Pel·licules de la llista de Pel·licules dins el TreeView
        private void CargarPeliculas()
        {
            //Netegem el TreeView per poder omplir-hi les dades després
            treeView1.Nodes.Clear();

            //Realitzem el recorregut per tots els objectes Pel·Licula de la llista de Pel·licules
            foreach (Pelicula p in peliculas)
            {
                TreeNode Titol = new TreeNode(p.getTitol());
                TreeNode Director = new TreeNode(p.getDirector());
                TreeNode ActorsPrincipals = new TreeNode(p.getActorsPrincipals());
                TreeNode Pais = new TreeNode(p.getPais());
                TreeNode Any = new TreeNode(p.getAny());
                TreeNode Durada = new TreeNode(p.getDurada());
                TreeNode[] info = new TreeNode[] { Titol, Director, ActorsPrincipals, Pais, Any, Durada };
                // Final node.
                TreeNode Pelicula = new TreeNode(p.getTitol(), info);
                treeView1.Nodes.Add(Pelicula);
            }
        }

        //Sortir menu
        private void sortirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            anomenaIDesaToolStripMenuItem_Click(sender, e);
            Application.Exit();
        }

        //Mètode que s'executa al clicar a afegir
        
            //Afegir
        private void afegirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Capturem si el node sel·leccionem està ben introduit
            try
            {
                //Creem un objecte de la classe AfegirFormulari
                AfegirForm afegirFormu = new AfegirForm();

                //Mostra el formulari
                if (afegirFormu.ShowDialog() == DialogResult.OK)
                {
                    
                }

                //Un cop tancat el formulari edita les dades de la Pel·licula i actualitza la llista
                Pelicula p = afegirFormu.getPelicula();
                peliculas.Add(p);

                //Crida al mètode CargarPeliculas() perquè escrigui les dades corresponents al treeView
                CargarPeliculas();
            }
            catch (System.ArgumentOutOfRangeException)
            {

            }
        }

        //actualitzar pelicula
        private void actualitzarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Capturem si el node sel·leccionem està ben introduit
            try
            {

                //--Obtenir index de l'objecte Alumne per modificar--
                //1-Cream un objecte alumne segons les dades obtenides pel node
                Pelicula a = new Pelicula();
                TreeNode node = treeView1.SelectedNode;
                a.setTitol(node.Nodes[0].Text);
                a.setDirector(node.Nodes[1].Text);
                a.setActorsPrincipals(node.Nodes[2].Text);
                a.setPais(node.Nodes[3].Text);
                a.setAny(node.Nodes[4].Text);
                a.setDurada(node.Nodes[5].Text);
                

                //2-Creem un index segons un mètode que comproba l'objecte Pelicula passat per paràmetre
                //amb la llista pelicules.
                int index = EncontrarPelicula(a);

                //Creem un objecte de la classe editar
                ActualitzarForm editar = new ActualitzarForm();

                //MessageBox.Show("Si no cambio la funcion encontrar pelicula, no va, si cambio va mal");
                //Comprobem que s'ha introduit bé l'index
                if (index >= 0)
                {
                    //Fer botar la classe Editar amb el form i esperar-lo
                    editar.setPelicula(peliculas[index]);
                    
                    //Mostra el formulari
                    if (editar.ShowDialog() == DialogResult.OK)
                    {}

                    //Un cop tancat el formulari edita les dades de la pel·licula i actualitza la llista
                    a = editar.getPelicula();
                    peliculas[index] = new Pelicula(a);

                    //Crida al mètode CargarPeliculas() perquè escrigui les dades corresponents al treeView
                    CargarPeliculas();

                }
                else
                {
                    //imprimir missatge d'error
                }
            }
            catch (System.ArgumentOutOfRangeException)
            {

            }
        }

        //Mètode que retorna l'index de la llista segons l'objecte trobat
        private int EncontrarPelicula(Pelicula p)
        {
            int index = treeView1.SelectedNode.Index;
            int comptador = -1;

            foreach (Pelicula pe in peliculas)
            {
                comptador++;
                //SOBRESCRIURE METODE EQUALS DE LA CLASSE ALUMNE
                if (pe.Equals(p)) { index = comptador; }
            }

            return index;
        }

        //Elimina element seleccionat del treeView del menu
        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            treeView1.SelectedNode.Remove();
            
       }

        //Apareix el groupBox amb el listView i el comboBox
        private void buscarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            CargarPeliculasListView();
        }

        private void CargarPeliculasListView()
        {
            
            listView1.Items.Clear();

            using (StreamReader reader = new StreamReader(@".\peliculas.txt", false))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] fields = line.Split(':');
                    ListViewItem lVI = listView1.Items.Add(fields[0]);
                    lVI.SubItems.Add(fields[1]);
                    lVI.SubItems.Add(fields[2]);
                    lVI.SubItems.Add(fields[3]);
                    lVI.SubItems.Add(fields[4]);
                    lVI.SubItems.Add(fields[5]);
                    lVI.SubItems.Add(fields[6]);

                }
            }
        }

        //icona de obir el fitxer obre el fitxer de les pelis
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            obrirToolStripMenuItem_Click(sender, e);
        }

        //icona de actualitzar la peli seleccionada
        private void toolStripButton2_Click(object sender, EventArgs e)
        {

            actualitzarToolStripMenuItem_Click(sender, e);
        }

        //icona de borrar la peli seleccionada
        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            eliminarToolStripMenuItem_Click(sender, e);
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            treeView1.SelectedNode.Remove();
        }

        private void habilitarScrollToolStripMenuItem1_Click(object sender, EventArgs e)
        {
             //Habilitar SCROLL
            treeView1.BorderStyle = BorderStyle.FixedSingle;
            treeView1.Scrollable = true;
        

        }

        private void canviarTipusDeFontToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //Canviar FONT
        
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                treeView1.Font = fontDialog1.Font;
            }
        }

    }
}
