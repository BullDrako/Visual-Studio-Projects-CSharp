using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen2M7
{
    public partial class AfegirForm : Form
    {
        Product product = new Product();


        public AfegirForm()
        {
            InitializeComponent();
        }

        public void actualitzarDades()
        {
            textBox1.Text = product.getCodi();
            textBox2.Text = product.getDescripcio();
            textBox3.Text = product.getId();
            textBox4.Text = product.getUnitats();
            textBox5.Text = product.getPreu();
        }


        internal void setProduct(Product p)
        {
            product = new Product(p);
            actualitzarDades();
        }

        internal Product getProduct()
        {
            return this.product;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox1.Text != "" || textBox2.Text != "" || textBox3.Text != "" || textBox4.Text != "")
            {
                //Canvia les dades de l'alumne
                product.setCodi(textBox1.Text);
                product.setDescripcio(textBox2.Text);
                product.setId(textBox3.Text);
                product.setUnitats(textBox4.Text);
                product.setPreu(textBox5.Text);

                //Amaga la finestra perque es modifiquin les dades actuals
                this.Close();
            }
            else
            {

                MessageBox.Show("Debes completar todos los campos");
            }

        }
    }
}
