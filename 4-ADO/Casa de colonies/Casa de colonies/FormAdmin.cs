using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaControladora;


namespace Casa_de_colonies
{
    public partial class FormAdmin : Form
    {
        public FormAdmin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!textBoxDni.Equals("") && !textBoxNombre.Equals("") && !textBoxApellidos.Equals("") && !textBoxTelefono.Equals("") && !textBoxEmail.Equals("") /*&& !textBoxNumss.Equals("") && !textBoxTitulacion.Equals("")*/)
            {
                String dni = textBoxDni.Text;
                String nombre = textBoxNombre.Text;
                String apellidos = textBoxApellidos.Text;
                String telefono = textBoxTelefono.Text;
                String email = textBoxEmail.Text;
                String num_ss = textBoxNumss.Text;
                String titulacion = textBoxTitulacion.Text;

                String message = UserController.newAdmin(dni, nombre, apellidos, telefono, email/*, num_ss, titulacion*/);

                MessageBox.Show(message);
                //dataGridView1.Update();
                //dataGridView1.Refresh();
               // FormBooks_Load(sender, e);
            }
            else
            {
                MessageBox.Show("Fill all fields with any data.");
            }
        }
    }
}
