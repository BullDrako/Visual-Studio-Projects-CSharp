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

namespace Alumnes
{
    public partial class Form1 : Form
    {
        private List<Alumne> agenda = new List<Alumne>();
        public Form1()
        {
            InitializeComponent();
        }

        //--MÈTODES QUE S'EXECUTEN AMB UN OBJECTE SENDER--


        //Mètode que s'executa quan s'encen l'aplicació
        private void Form1_Load(object sender, EventArgs e)
        {
            //Carrega totes les dades en els atributs i al formulari
            carregarDades();
        }

        //Mètode que s'executa al clicar el botó editar
        private void actionEditarClick(object sender, EventArgs e)
        {
            //Capturem si el node sel·leccionem està ben introduit
            try
            {

                //--Obtenir index de l'objecte Alumne per modificar--
                //1-Cream un objecte alumne segons les dades obtenides pel node
                Alumne a = new Alumne();
                TreeNode node = treeView1.SelectedNode;
                a.setNom(node.Nodes[0].Text);
                a.setCognoms(node.Nodes[1].Text);
                a.setMobil1(node.Nodes[2].Text);
                a.setMobil2(node.Nodes[3].Text);
                a.setTelefon(node.Nodes[4].Text);
                a.setEmail(node.Nodes[5].Text);
                a.setUf(node.Nodes[6].Text);

                //2-Cream un index segons un mètode que comproba l'objecte Alumne passat per paràmetre
                //amb la llista agenda.
                int index = trobarAlumne(a);
                textBoxa.Text = index.ToString();
                //Cream un objecte de la classe editar
                Editar editar = new Editar();

                //Comprobem que s'ha introduit bé l'index
                if (index >= 0)
                {
                    //Fer botar la classe Editar amb el form i esperar-lo
                    editar.setAlumne(agenda[index]);

                    //Mostra el formulari
                    if (editar.ShowDialog() == DialogResult.OK)
                    {
                        //Instruccions 
                        //MessageBox.Show("Hola");
                    }

                    //Un cop tancat el formulari edita les dades del contacte i actualitza la llista
                    a = editar.getAlumne();
                    agenda[index] = new Alumne(a);

                    //Crida al mètode carregarAlumnes() perquè escrigui les dades corresponents al treeView
                    carregarAlumnes();

                }
                else
                {
                    //imprimir missatge d'error
                }
            }
            catch (System.ArgumentOutOfRangeException )
            {

            }

        }

        //Mètode que s'executa ál clicar el botó Nou
        private void actionNouClick(object sender, EventArgs e)
        {
            //Capturem si el node sel·leccionem està ben introduit
            try { 
                //Cream un objecte de la classe Nou
                Nou nou = new Nou();

                //Mostra el formulari
                if (nou.ShowDialog() == DialogResult.OK)
                {
                    //Instruccions 
                    //MessageBox.Show("Hola");
                }

                //Un cop tancat el formulari edita les dades del contacte i actualitza la llista
                Alumne a = nou.getAlumne();
                agenda.Add(a);

                //Crida al mètode carregarAlumnes() perquè escrigui les dades corresponents al treeView
                carregarAlumnes();
            }
            catch (System.ArgumentOutOfRangeException)
            {

            }
        }

        //Mètode que guarda el resultat
        private void actionSaveClick(object sender, EventArgs e)
        {
            escriureDadesFitxer();
        }


        //--MÈTODES QUE S'EXECUTEN ÚNICAMENT PER REALITZAR ALGUNA APLICACIÓ--

        //Mètode que carrega totes les dades procedents de l'arxiu als atributs i objectes del form 
        private void carregarDades()
        {
            //Obre les dades del fitxer per poder fer les operacions línia a lina
            carregarFitxer();
            //Carrega les dades de l'agenda al TreeView
            carregarAlumnes();
        }

        //Carrega les dades del fitxer per poder-hi executar totes les operacions
        private void carregarFitxer()
        {
            String linea;
            //Pass the file path and file name to the StreamReader constructor
            try
            {
                StreamReader sr = new StreamReader("alumnes.txt");

                //Read the data of text
                while ((linea = sr.ReadLine()) != null)
                {
                    //Cridam al mètode per crear un objecte Alumne a partir de la linia 
                    //i afegir-lo a l'agenda
                    crearAlumnes(linea);
                }

                //close the file
                sr.Close();
            }
            catch (FileNotFoundException fnfe)
            {
                MessageBox.Show("No se ha encontrado archivo");
            }
        }


        //Mètode que crea i afegeig a la llista d'alumnes segons una linia.
        private void crearAlumnes(String linea)
        {
            //Tabla de Strings que utilitzarem per separar per ; i crear l'objecte
            String[] datos;
            datos = linea.Split(';');

            //Cream l'Alumne amb les dades de la linia
            Alumne e = new Alumne();
            e.setNom(datos[0]);
            e.setCognoms(datos[1]);
            e.setMobil1(datos[2]);
            e.setMobil2(datos[3]);
            e.setTelefon(datos[4]);
            e.setEmail(datos[5]);
            e.setUf(datos[6]);

            //Afegim l'Alumne a l'agenda.
            agenda.Add(e);
        }


        //Mètode que carrega tots els alumnes de l'agenda dins el TreeView
        private void carregarAlumnes()
        {
            //Netegem el TreeView per poder omplir-hi les dades després
            treeView1.Nodes.Clear();

            //Realitzem el recorregut per tots els objectes Alumne de la llista agenda
            foreach(Alumne e in agenda)
            {
                TreeNode Mom = new TreeNode(e.getNom());
                TreeNode Cognoms = new TreeNode(e.getCognoms());
                TreeNode Mobil1 = new TreeNode(e.getMobil1());
                TreeNode Mobil2 = new TreeNode(e.getMobil2());
                TreeNode Telefon = new TreeNode(e.getTelefon());
                TreeNode Mail = new TreeNode(e.getEmail());
                TreeNode Uf = new TreeNode(e.getUf());
                TreeNode[] info = new TreeNode[] { Mom, Cognoms, Mobil1, Mobil2, Telefon, Mail, Uf };

                // Final node.
                TreeNode libro = new TreeNode(e.getNom(), info);
                treeView1.Nodes.Add(libro);
            }
        }

        //Mètode que retorna l'index de la llista segons l'objecte trobat

        private int trobarAlumne(Alumne a)
        {
            int index = -1;
            int comptador = -1;

            foreach(Alumne e in agenda)
            {
                comptador++;
                //SOBRESCRIURE METODE EQUALS DE LA CLASSE ALUMNE
                if (e.Equals(a)) { index = comptador; }
            }

            return index;
        }

        //Mètode que escriu tots els alumnes de la llista agenda dins el fitxer
        private void escriureDadesFitxer()
        {
            using (StreamWriter sw = new StreamWriter("alumnes.txt"))
            {
                String resultat = "";

                foreach (Alumne a in agenda)
                {
                    resultat += a.getNom() + ";";
                    resultat += a.getCognoms() + ";";
                    resultat += a.getMobil1() + ";";
                    resultat += a.getMobil2() + ";";
                    resultat += a.getTelefon() + ";";
                    resultat += a.getEmail() + ";";
                    resultat += a.getUf() + ";" + "\r\n";
                }

                sw.Write(resultat);

            }
        }

        
    }
}
