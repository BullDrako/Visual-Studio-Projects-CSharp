using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExempleDeClasse
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void clicantAbout(object sender, EventArgs e)
        {
            About oAbout = new About();
            //Vull que estigui contingut dins de Gestor
            //oAbout.MdiParent = this;
            oAbout.ShowDialog();
            //oAbout.Show();
            
        }

        private void clicCarrega(object sender, EventArgs e)
        {
            //Ha d'obrir un diàleg per poder entrar 
            //dins de les carpetes de Windows:openDialog
            openFileDialog1.InitialDirectory="c:\\";
            openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";

            openFileDialog1.ShowDialog();
        }
    }
}
