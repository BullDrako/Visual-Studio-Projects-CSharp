using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManipulaFormularis
{
    public partial class FormModificarContacto : Form
    {
        String[] contactos;
        int posicion;
        public FormModificarContacto(String[] lines)
        {
            contactos = lines;
            InitializeComponent();
        }

        private void FormModificarContacto_Load(object sender, EventArgs e)
        {

        }

        private void ModificarContacto(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            textBox3.Clear();
           
            int i = 0;
            foreach (String contacto in contactos)
            {
                String[] split = contacto.Split(new Char[] { '\t' });
                
                if (i == posicion)
                {
                    sb.AppendLine(textBox2.Text+"\t"+textBox6.Text+"\t"+textBox4.Text+ "\t" +textBox7.Text+ "\t" +
                    textBox5.Text+ "\t" +textBox8.Text);
                }
                else
                {
                    sb.AppendLine(contacto);
                }

                i++;
            }
            textBox3.Text = sb.ToString();
            
        }

        private void BuscarContacto(object sender, EventArgs e)
        {
            String field = "";
            if (!textBox1.Text.Equals(""))
            {
                field = textBox1.Text;
                label3.Text = "";
            }
            else label3.Text = "Has d'omplir aquest camp";
            textBox3.Clear();
            if (!field.Equals(""))
            {
                UserADO listUsers = new UserADO();

                Users searchedUsers = listUsers.searchField(field);
                if (searchedUsers.Count == 0) textBox3.Text = "No hay coincidencias";
                foreach (User user in searchedUsers)
                {

                    textBox3.Text += user.toString();

                }
            } 
        }

        private void tancant(object sender, FormClosingEventArgs e)
        {
           DialogResult= DialogResult.Yes;
        }

        private void textBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
