using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Casa_de_colonies
{
    public partial class FormMonitor : Form
    {
        public FormMonitor()
        {
            InitializeComponent();
        }

        casacoloniesEntities db = new casacoloniesEntities();

        private void button1_Click(object sender, EventArgs e)
        {
            //insertar monitor
            if (!textBoxDni.Equals("") && !textBoxNombre.Equals("") && !textBoxApellidos.Equals("") && !textBoxTelefono.Equals("") && !textBoxEmail.Equals("") )
            {
                String dni = textBoxDni.Text;
                String nombre = textBoxNombre.Text;
                String apellidos = textBoxApellidos.Text;
                int telefono = Int32.Parse(textBoxTelefono.Text);
                String email = textBoxEmail.Text;

                DateTimePicker fechaNacimiento = dateTimePicker1;
                

                personal p = new personal();
                p.dni = dni;
                p.nombre = nombre;
                p.apellidos = apellidos;
                p.telefono = telefono;
                p.email = email;

                monitor m = new monitor();
                m.dni = dni;
                m.fecha_nacimiento = fechaNacimiento.Value;
                

                db.personal.Add(p);
                db.monitor.Add(m);

                db.SaveChanges();

                MessageBox.Show("Insertado");
            }
            else
            {
                MessageBox.Show("Fill all fields with any data.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //buscar  monitor
            string dniMonitor = textBox5.Text;

            try
            {
                monitor m = db.monitor.First(moni => moni.dni == textBox5.Text);


                var usuarios = from moni in db.monitor select moni;
                dateTimePicker2.Value = m.fecha_nacimiento;


                personal p = db.personal.First(pers => pers.dni == textBox5.Text);

                var perso = from per in db.personal select per;

                textBox4.Text = p.nombre;
                textBox3.Text = p.apellidos;
                textBox2.Text = p.email;
                textBox1.Text = p.telefono.ToString();

            }
            catch (Exception error)
            {
                MessageBox.Show("No esisteix aquest usuari");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //buscar  monitor
            string dniMonitor = textBox10.Text;

            try
            {
                monitor m = db.monitor.First(moni => moni.dni == textBox10.Text);

                var usuarios = from moni in db.monitor select moni;
                dateTimePicker3.Value = m.fecha_nacimiento;


                personal p = db.personal.First(pers => pers.dni == textBox10.Text);

                var perso = from per in db.personal select per;

                textBox9.Text = p.nombre;
                textBox8.Text = p.apellidos;
                textBox7.Text = p.email;
                textBox6.Text = p.telefono.ToString();

            }
            catch (Exception error)
            {
                MessageBox.Show("No esisteix aquest usuari");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //donar baixa
            string dni = textBox10.Text;
            try
            {
                monitor m = db.monitor.First(moni => moni.dni == textBox10.Text);
                db.monitor.Remove(m);
                db.SaveChanges();
                MessageBox.Show("Donat de baixa");
            }
            catch (Exception error)
            {
                MessageBox.Show("No existeix aquest usuari");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //borrar del tot
            string dni = textBox10.Text;
            try
            {
                monitor m = db.monitor.First(moni => moni.dni == textBox10.Text);

                personal p = db.personal.First(pers => pers.dni == textBox10.Text);

                db.monitor.Remove(m);
                db.personal.Remove(p);

                db.SaveChanges();
                MessageBox.Show("Donat de baixa");
            }
            catch (Exception error)
            {
                MessageBox.Show("No existeix aquest usuari");
            }
        }
    } 
}
