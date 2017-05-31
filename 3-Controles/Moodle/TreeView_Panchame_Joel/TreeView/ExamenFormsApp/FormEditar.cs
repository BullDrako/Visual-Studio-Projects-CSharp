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
    public partial class FormEditar : Form
    {
        public FormEditar(TreeNode node)
        {
            InitializeComponent();
            try
            {
                //Muestro los datos en los TextBox
                this.textBoxNom.Text = node.Text;
                this.textBoxCognoms.Text = node.Nodes[0].Text;
                this.textBoxMobil1.Text = node.Nodes[1].Text;
                this.textBoxMobil2.Text = node.Nodes[2].Text;
                this.textBoxTelefono.Text = node.Nodes[3].Text;
                this.textBoxEmail.Text = node.Nodes[4].Text;
                this.textBoxUf.Text = node.Nodes[5].Text;
            }
            catch {  }
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
