using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace ExamenAccesDades
{
    public partial class Form1 : Form
    {
        cuinaEntities DB = new cuinaEntities();
        private static CapaModel.DBConnection dataSource;

        public Form1()
        {
            InitializeComponent();
            dataSource = CapaModel.DBConnection.getInstance();//crido a la connexió
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void toresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormTotesCategories formTotesCategories = new FormTotesCategories();
            formTotesCategories.MdiParent = this;
            formTotesCategories.Show();
        }

        private void carnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCategoriaCarn formCategoriaCarn = new FormCategoriaCarn();
            formCategoriaCarn.MdiParent = this;
            formCategoriaCarn.Show();
        }

        private void peixToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCategoriaPeix formCategoriaPeix = new FormCategoriaPeix();
            formCategoriaPeix.MdiParent = this;
            formCategoriaPeix.Show();
        }

        private void sortirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSortir formSortir = new FormSortir();
            formSortir.Show();
           
        }

        private void afegirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AfegirForm afegirForm = new AfegirForm();
            afegirForm.Show();
        }
    }
}
