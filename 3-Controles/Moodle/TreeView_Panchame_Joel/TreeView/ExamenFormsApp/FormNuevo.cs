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
    public partial class FormNuevo : Form
    {
        public FormNuevo()
        {
            InitializeComponent();
        }

        public string[] getNodes()
        {
            //Guardo los datos de los campos en un array para cogerlos en el Form principal
            string[] nodes = new string[7];

            nodes[0] = this.textBoxNom.Text;
            nodes[1] = this.textBoxCognoms.Text;
            nodes[2] = this.textBoxMobil1.Text;
            nodes[3] = this.textBoxMobil2.Text;
            nodes[4] = this.textBoxTelefono.Text;
            nodes[5] = this.textBoxEmail.Text;
            nodes[6] = this.textBoxUf.Text;

            return nodes;
        }

    }
}
