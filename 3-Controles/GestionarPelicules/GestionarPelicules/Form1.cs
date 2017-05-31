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

namespace GestionarPelicules
{
    public partial class Form1 : Form
    {
        String fileName;

        private List<Pelicula> peliculas = new List<Pelicula>();

        public Form1()
        {
            InitializeComponent();
        }

        private void obrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            carregarDades();
        }

        private void carregarDades()
        {
            carregarFitxer();
            carregarPeliculas();
        }

        private void carregarPeliculas()
        {
            //Netegem el TreeView per poder omplir-hi les dades després
            treeView1.Nodes.Clear();

            //Realitzem el recorregut per tots els objectes Pel·Licula de la llista de Pel·licules
            foreach (Pelicula p in peliculas)
            {
                TreeNode Titol = new TreeNode(p.getTitol());
                TreeNode Director = new TreeNode(p.getTitol());
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

        private void carregarFitxer()
        {
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
                        //Criemam al mètode per crear un objecte Pel·licula a partir de la linia 
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

        private void crearPeliculas(string linea)
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
                Pelicula a = afegirFormu.getPelicula();
                peliculas.Add(a);

                //Crida al mètode CargarPeliculas() perquè escrigui les dades corresponents al treeView
                carregarPeliculas();
            }
            catch (System.ArgumentOutOfRangeException)
            {

            }
        }

        private void anomenaIDesaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.InitialDirectory = "F:\\_CFGS\\CFGS DAM\\M7\\Controls\\GestionarPelicules\\GestorionarPelicules\\bin\\Debug";
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

                    foreach (Pelicula a in peliculas)
                    {
                        resultat += a.getTitol() + ":";
                        resultat += a.getDirector() + ":";
                        resultat += a.getActorsPrincipals() + ":";
                        resultat += a.getPais() + ":";
                        resultat += a.getAny() + ":";
                        resultat += a.getDurada() + ":" + "\r\n";

                    }

                    sw.Write(resultat);

                }
            }
        }

        private void actualitzarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Pelicula a = new Pelicula();
                TreeNode node = treeView1.SelectedNode;
                MessageBox.Show(treeView1.SelectedNode.Index.ToString());
                a.setTitol(node.Nodes[0].Text);
                a.setDirector(node.Nodes[1].Text);
                a.setActorsPrincipals(node.Nodes[2].Text);
                a.setPais(node.Nodes[3].Text);
                a.setAny(node.Nodes[4].Text);
                a.setDurada(node.Nodes[5].Text);

                int index = trobarPelicula(a);
                textBoxa.Text = index.ToString();

                editarForm editarformu = new editarForm();

                MessageBox.Show("Peta");
                if (index >= 0)
                {
                    //Fer botar la classe Editar amb el form i esperar-lo
                    editarformu.setPelicula(peliculas[index]);

                    //Mostra el formulari
                    if (editarformu.ShowDialog() == DialogResult.OK)
                    {
                        
                    }

                    //Un cop tancat el formulari edita les dades del contacte i actualitza la llista
                    a = editarformu.getPelicula();
                    peliculas[index] = new Pelicula(a);

                    //Crida al mètode carregarPeliculas() perquè escrigui les dades corresponents al treeView
                    carregarPeliculas();

                
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
        private int trobarPelicula(Pelicula a)
        {
            int index = -1;
            int comptador = -1;

            foreach (Pelicula e in peliculas)
            {
                comptador++;
                //SOBRESCRIURE METODE EQUALS DE LA CLASSE ALUMNE
                if (e.Equals(a)) { index = comptador; }
            }

            return index;
        }


    }
}
