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

namespace PruebaControles
{
    public partial class Form1 : Form
    {
        String fileName;

        public Form1()
        {
            InitializeComponent();
            nuevoToolStripButton.Enabled = false;
            guardarToolStripButton.Enabled = false;
            cortarToolStripButton.Enabled = false;
            pegarToolStripButton.Enabled = false;
            copiarToolStripButton.Enabled = false;


        }

        private void ClicantAbout(object sender, EventArgs e)
        {
            About oAbout = new About();
            oAbout.ShowDialog(); //(modal (per avisar)) si no es tanca la finestra que acaba d'apareixer no es pot anar a la primera
            //oAbout.Show();

            //Vull que estigui contingut isMDIContainer true
            //oAbout.MdiParent = this;
           // oAbout.Show();//es pot minimitzar quan vulguis.
        }

        private void clickCarrega(object sender, EventArgs e)
        {
            //Ha d'obrir un dialeg per poder entrar dins de les carpetes de Windows
            //openDialog

            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            //openFileDialog1.FilterIndex = 2; //posicion que se quiere mostrar. Se veria All files

            openFileDialog1.FileName = "";//quitar nombre predefinido de la caja



            if (openFileDialog1.ShowDialog() /*modal*/ == DialogResult.OK) //si se  ha abierto abre o se cierra
            {
                //obrir el fitxer
                //MessageBox.Show(openFileDialog1.FileName);

                //si nomes vull el nom del fitxer
                int pos;
                pos = openFileDialog1.FileName.LastIndexOf('\\');
                fileName = openFileDialog1.FileName.Substring(pos + 1);

                //si volgues ruta sencera al nom del arxiu
                //fileName = openFileDialog1.FileName;
                   
                try
                {
                    using (StreamReader sr = new StreamReader(openFileDialog1.FileName))
                    {
                       string line;

                       while((line = sr.ReadLine()) != null){

                            //omplir el textbox (propiedades multiline y dock-->fill)
                            //format a line (ToDo)
                            textBox1.Text += line + "\r\n";
                       }
                    }
                    edicióToolStripMenuItem.Enabled = true;
                    autorToolStripMenuItem.Enabled = true;
                    toolStrip1.Enabled = true;
                    nouToolStripMenuItem.Enabled = true;
                    guardarDadesToolStripMenuItem.Enabled = true;
                    sortirToolStripMenuItem.Enabled = true;

                    nuevoToolStripButton.Enabled = true;
                    guardarToolStripButton.Enabled = true;
                    cortarToolStripButton.Enabled = true;
                    pegarToolStripButton.Enabled = true;
                    copiarToolStripButton.Enabled = true;    
                }
                catch (Exception ex)
                {

                }
            }
        }

        private void habilitant(object sender, EventArgs e)
        {
            nouToolStripMenuItem.Enabled = false;
            guardarDadesToolStripMenuItem.Enabled = false;
            sortirToolStripMenuItem.Enabled = false;
        }

        private void nouToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //s'ha de preguntar i només vols reaccionar al "si"
            if (MessageBox.Show("Vols guardar les dades?", "Atenció", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //guardar dades
                guardarDadesToolStripMenuItem_Click(sender, e);
            }
            textBox1.Text = "";
            textBox1.ReadOnly = false;
        }

        private void guardarDadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //farem servir el saveFileDialog
            saveFileDialog1.InitialDirectory = "c:\\";
            saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog1.FileName = fileName;

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //l'usuari ha escollit on vol guardar i quin arxiu vol guardar

                //obrir el fitxer saveFileDialog.Filename en mode escriptura
                using (StreamWriter sw = new StreamWriter(saveFileDialog1.FileName))
                {
                   sw.WriteLine(textBox1.Text);                   
                }
            }
        }

        private void sortirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Segur que vols sortir?", "No es guardaran els canvis.", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                Close();
            }      
        }

        private void canviarFontToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Font = fontDialog1.Font;
            }
        }

        private void canviarFonsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                //color letra
                //textBox1.ForeColor = colorDialog1.Color;
                
                //color de fondo
                textBox1.BackColor = colorDialog1.Color;
            }
        }

        private void buscarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Buscar oBuscar = new Buscar();
            oBuscar.ShowDialog();
        }
    }
}
