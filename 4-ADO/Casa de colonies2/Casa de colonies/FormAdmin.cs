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

        casacoloniesEntities db = new casacoloniesEntities();



        private void button1_Click(object sender, EventArgs e)
        {
            //insertar admin
            if (!textBoxDni.Equals("") && !textBoxNombre.Equals("") && !textBoxApellidos.Equals("") && !textBoxTelefono.Equals("") && !textBoxEmail.Equals("") && !textBoxNumss.Equals("") && !textBoxTitulacion.Equals(""))
            {
                String dni = textBoxDni.Text;
                String nombre = textBoxNombre.Text;
                String apellidos = textBoxApellidos.Text;
                int telefono = Int32.Parse(textBoxTelefono.Text);
                String email = textBoxEmail.Text;

                String num_ss = textBoxNumss.Text;
                String titulacion = textBoxTitulacion.Text;

                personal p = new personal();
                p.dni = dni;
                p.nombre = nombre;
                p.apellidos = apellidos;
                p.telefono = telefono;
                p.email = email;

                administrador a = new administrador();
                a.dni = dni;
                a.num_SS = num_ss;
                a.titulacion = titulacion;

                db.personal.Add(p);
                db.administrador.Add(a);

                db.SaveChanges();

                MessageBox.Show("Insertado");
            }
            else
            {
                MessageBox.Show("Fill all fields with any data.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //update admin
            string dniAdmin = textBox7.Text;

            try
            {
                administrador a = db.administrador.First(admin => admin.dni == textBox7.Text);

                /* var usuarios = from adm in db.administrador select adm;
                 listBox1.Items.Add(a.num_SS);
                 listBox2.Items.Add(a.titulacion);
                 */
                /* a.num_SS = textBox2.Text;
                 a.titulacion = textBox1.Text;*/

                a.num_SS = textBox3.Text;
                a.titulacion = textBox4.Text;

                personal p = db.personal.First(pers => pers.dni == textBox7.Text);
                p.nombre = textBox8.Text;
                p.apellidos = textBox6.Text;
                p.email = textBox1.Text;
                p.telefono = Int32.Parse(textBox5.Text);


                db.SaveChanges();
                MessageBox.Show("Modificat exitós");
                
            }
            catch (Exception error)
            {
                MessageBox.Show("No esisteix aquest usuari");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //buscar admin
            try
            {
                administrador a = db.administrador.First(admin => admin.dni == textBox7.Text);

                var admins = from adm in db.administrador select adm;
                textBox3.Text = a.num_SS;
                textBox4.Text = a.titulacion;

                personal p = db.personal.First(pers => pers.dni == textBox7.Text);

                var perso = from per in db.personal select per;

                textBox8.Text = p.nombre;
                textBox6.Text = p.apellidos;
                textBox1.Text = p.email;
                textBox5.Text = p.telefono.ToString();
    
            }
            catch (Exception error)
            {
                MessageBox.Show("No esisteix aquest usuari");
            }
        }
    }
}
