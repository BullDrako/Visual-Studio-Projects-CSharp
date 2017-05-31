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


namespace ExempleDeClasse
{
    public partial class Form1 : Form
    {
        String fileName;
        List<Contacte> contactes = new List<Contacte>();
        int posicion = -1;
        //ListViewItem treb = new ListViewItem();
        public Form1()
        {
            InitializeComponent();
        }


        //public List<Contacte> getContactes() { return contactes; }

        private void clicantAbout(object sender, EventArgs e)
        {
            About oAbout = new About();
            //Vull que estigui contingut dins de Gestor
            // oAbout.MdiParent = this;
            oAbout.ShowDialog();
            // oAbout.Show();

        }

        private void clicCarrega(object sender, EventArgs e)
        {
            //Ha d'obrir un diàleg per poder entrar 
            //dins de les carpetes de Windows:openDialog
            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";

            openFileDialog1.FileName = "";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //si vulgues només agafar el nom del fitxer
                int pos;
                pos = openFileDialog1.FileName.LastIndexOf('\\');

                fileName = openFileDialog1.FileName.Substring(pos + 1);
                //obrir el fitxer
                //obrir en mode lectura el fitxer sel·leccionat
                try
                {
                    //Neteja la llista
                    contactes = new List<Contacte>();

                    // Create an instance of StreamReader to read from a file.
                    // The using statement also closes the StreamReader.
                    using (StreamReader sr = new StreamReader(openFileDialog1.FileName))
                    {
                        string line;

                        //llegim línia línia el nostre fitxer acabat d'obrir
                        while ((line = sr.ReadLine()) != null)
                        {
                            //omplir el textbox
                            //format a line (to do)
                            //textBox1.Text += line +"\r\n";
                            crearContactes(line);

                        }
                    }
                    actualitzarDadesLlista();

                    edicioToolStripMenuItem.Enabled = true;
                    autorToolStripMenuItem.Enabled = true;
                    toolStrip1.Enabled = true;
                    deNouToolStripMenuItem.Enabled = true;
                    guardarToolStripMenuItem.Enabled = true;
                    sortirToolStripMenuItem.Enabled = true;
                }
                catch (Exception error)
                {

                    // Let the user know what went wrong.

                }


            }
        }

        private void crearContactes(String linia)
        {
            //Fer recorregut de la linia separant per ';'
            //Guardamos cada cadena separada por dos puntos para resolver los
            //atributos del contacto
            string[] stringSeparatorsContactos = new string[] { ";" };
            string[] resultContactos = linia.Split(stringSeparatorsContactos, StringSplitOptions.None);


            //Crear Contacte
            Contacte c = new Contacte(resultContactos[0].Trim(), resultContactos[1].Trim(),
                resultContactos[2].Trim(), resultContactos[3].Trim(), resultContactos[4].Trim());

            //Afegir Contacte a la llista
            contactes.Add(c);

            //Imprimim al TextBox
            //TO-DO INTRODUIR LES DADES A LA LLISTA 
            //textBox1.Text += c.ToString() + "\r\n";
            //actualitzarDadesLlista();
        }

        private void actualitzarDadesLlista()
        {
            //ListViewItem lVI = new ListViewItem();
            //TODO
            //--Borrar datos lista!!!!
            listView1.Items.Clear();
            int index = 0;

            foreach (Contacte c in contactes)
            {
                ListViewItem lVI = listView1.Items.Add(index.ToString());
                lVI.SubItems.Add(c.getNom());
                lVI.SubItems.Add(c.getCognoms());
                lVI.SubItems.Add(c.getTelefon());
                lVI.SubItems.Add(c.getMovil());
                lVI.SubItems.Add(c.getEmail());
                index++;
            }

        }

        private void habilitant(object sender, EventArgs e)
        {
            deNouToolStripMenuItem.Enabled = false;
            guardarToolStripMenuItem.Enabled = false;
            sortirToolStripMenuItem.Enabled = false;
        }

        private void deNouToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //s'ha de preguntar i només vols reaccionar al si
            if (MessageBox.Show("Vols guardar les dades?", "Atenció", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                //guardar dades
                guardarToolStripMenuItem_Click(sender, e);

            }

            borrarDades();
            actualitzarDadesLlista();

            //Restaurar List
            contactes = new List<Contacte>();
        }

        private void borrarDades()
        {
            contactes = new List<Contacte>();
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //farem servir el saveFileDialog
            saveFileDialog1.InitialDirectory = "C:\\";
            saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog1.FileName = fileName;
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //l'usuari ha escollit on vol guardar i quin arxiu vol guardar
                //obrir el fitxer saveFileDialog1.FileName en mode escriptura
                using (StreamWriter sw = new StreamWriter(saveFileDialog1.FileName))
                {
                    String resultat = "";

                    foreach (Contacte c in contactes)
                    {
                        resultat += c.getNom() + ";";
                        resultat += c.getCognoms() + ";";
                        resultat += c.getTelefon() + ";";
                        resultat += c.getMovil() + ";";
                        resultat += c.getEmail() + ";"+"\r\n";
                    }

                    sw.Write(resultat);

                }

            }
        }

        private void sortirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Segur que vols sortir?", "No es guardaran els canvis", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                Close();
            }
        }

        private void canviarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                //textBox12.Font = fontDialog1.Font;

            }
        }

        private void cToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                //per canviar el color de la lletra
                //textBox1.ForeColor = colorDialog1.Color;
                //per canviar el color del fons
                //textBox12.BackColor= colorDialog1.Color; 

            }
        }

        private void buscarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Buscar oBuscar = new Buscar();
            oBuscar.setContactes(contactes);
            oBuscar.Show();
        }


        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(listView1.SelectedItems.Count > 0 & posicion >= 0){
                //Contacte c = contactes[posicion];
                Modificar oModificar = new Modificar();

                //Agafa la posició del contacte en la llista i l'envia per paràmetre al mètode
                oModificar.setContacte(contactes[posicion]);
                
                //Mostra el formulari
               // oModificar.Show();


                if(oModificar.ShowDialog() == DialogResult.OK)
                {
                    //Instruccions 
                    //MessageBox.Show("Hola");
                    
                }

                //Un cop tancat el formulari edita les dades del contacte i actualitza la llista
                Contacte c = oModificar.getContacte();
                contactes[posicion] = new Contacte(c);

                //textBox1.Text = contactes[posicion].ToString();
                actualitzarDadesLlista();

            }
            
        }

        private void esborrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //if (index != 0 & hihaContactes() == true)
            if (listView1.SelectedItems.Count > 0 & posicion >= 0)
            {
                //Agafa el contacte de l'index
                Contacte c = contactes[posicion];

                //Esborra el contacte de la llista
                contactes.Remove(c);

                /*foreach(Contacte c in contactes)
                {
                    if (c.getTelefon().Equals(tlf))
                    {
                        contactes.Remove(c);
                    }
                }*/


                //Actualitza la llista
                actualitzarDadesLlista();


                /*Borrar oBorrar = new Borrar();
                oBorrar.setContactes(contactes);
                oBorrar.Show();*/
            }
        }

        /*private Boolean hihaContactes()
        {
            int numero_contactes = 0;

            foreach(Contacte c in contactes)
            {
                numero_contactes++;
            }

            if (numero_contactes == 0) return false;
            else return false;
        }*/

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (listView1.SelectedItems.Count > 0)
            {
                //TODO
                //-Agafar index i guardar-lo en una variable
                ListViewItem treb = listView1.SelectedItems[0];
                posicion = Int32.Parse(treb.SubItems[0].Text);
                //tlf = treb.SubItems[2].Text;
            }
        }
    }
}

/* TODO 
 * (Mètode modificar que retorni l'objecte modificat)
 * (Mètode esborrar que agafi l'index del ListView - ara agafa el .Count)
 * Apart tot funciona bé, però comprobar-ho tot per si acas
 * */