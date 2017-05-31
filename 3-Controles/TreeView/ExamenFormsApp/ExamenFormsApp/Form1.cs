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
    public partial class Form1 : Form
    {
        private int contador = 0, maximo = -1;
        private Boolean editar = false, nuevo = false;
        private List<User> agenda = new List<User>();
        public Form1()
        {
            InitializeComponent();
            // Creación de variables
            User foo;
            string[] lectura, telefono;
            string line = "";
            // Lectura de fichero para guardar en agenda
            string path = @".\DAM2.txt";
            System.IO.StreamReader file = new System.IO.StreamReader(path, true);
            while ((line = file.ReadLine()) != null)
            {
                string texto = "", nom = "", congoms = "", email = "", uf = "", mobil1 = "", mobil2 = "", casa = "";
                // Expresion: Pep:Garcia Roca:686666111,,936585656:pep@gmail.com:UF1M3,UF1M4,UF2M4,UF1M5:
                lectura = line.Split(':');
                nom = lectura[0];
                congoms = lectura[1];
                telefono = lectura[2].Split(',');
                if (!telefono[0].Equals(""))
                {
                    mobil1 = telefono[0];
                }
                if (!telefono[1].Equals(""))
                {
                    mobil2 = telefono[1];
                }
                if (!telefono[2].Equals(""))
                {
                    casa = telefono[2];
                }
                email = lectura[3];
                uf = lectura[4];
                foo = new User(nom, congoms, mobil1, mobil2, casa, email, uf);
                agenda.Add(foo);
                maximo++;
                //MessageBox.Show(foo.Nom, "Lectura de fichero");
            }
            file.Close();
            User mostrar = agenda[0];
            this.textBoxNom.Text = mostrar.Nom;
            this.textBoxCognoms.Text = mostrar.Congoms;
            this.textBoxMobil1.Text = mostrar.Mobil1;
            this.textBoxMobil2.Text = mostrar.Mobil2;
            this.textBoxTelefono.Text = mostrar.Telefono;
            this.textBoxEmail.Text = mostrar.Email;
            this.textBoxUf.Text = mostrar.Uf;
        }

        private void Click(object sender, EventArgs e)
        {
            User mostrar;
            Button clickedButton = (Button)sender;
            switch (clickedButton.Name)
            {
                case "buttonAtras":
                    
                    if (contador - 1 > -1)
                    {
                        putNothing();
                        contador--;
                        mostrar = agenda[contador];
                        this.textBoxNom.Text = mostrar.Nom;
                        this.textBoxCognoms.Text = mostrar.Congoms;
                        this.textBoxMobil1.Text = mostrar.Mobil1;
                        this.textBoxMobil2.Text = mostrar.Mobil2;
                        this.textBoxTelefono.Text = mostrar.Telefono;
                        this.textBoxEmail.Text = mostrar.Email;
                        this.textBoxUf.Text = mostrar.Uf;
                    }
                    else
                    {
                        putNothing();
                        mostrar = agenda[contador];
                        this.textBoxNom.Text = mostrar.Nom;
                        this.textBoxCognoms.Text = mostrar.Congoms;
                        this.textBoxMobil1.Text = mostrar.Mobil1;
                        this.textBoxMobil2.Text = mostrar.Mobil2;
                        this.textBoxTelefono.Text = mostrar.Telefono;
                        this.textBoxEmail.Text = mostrar.Email;
                        this.textBoxUf.Text = mostrar.Uf;
                    }
                    break;
                case "buttonPrincipio":
                    putNothing();
                    contador = 0;
                    mostrar = agenda[0];
                    this.textBoxNom.Text = mostrar.Nom;
                    this.textBoxCognoms.Text = mostrar.Congoms;
                    this.textBoxMobil1.Text = mostrar.Mobil1;
                    this.textBoxMobil2.Text = mostrar.Mobil2;
                    this.textBoxTelefono.Text = mostrar.Telefono;
                    this.textBoxEmail.Text = mostrar.Email;
                    this.textBoxUf.Text = mostrar.Uf;
                    break;
                case "buttonAdelante":
                    putNothing();
                    if (contador + 1 <= maximo)
                    {
                        putNothing();
                        contador++;
                        mostrar = agenda[contador];
                        this.textBoxNom.Text = mostrar.Nom;
                        this.textBoxCognoms.Text = mostrar.Congoms;
                        this.textBoxMobil1.Text = mostrar.Mobil1;
                        this.textBoxMobil2.Text = mostrar.Mobil2;
                        this.textBoxTelefono.Text = mostrar.Telefono;
                        this.textBoxEmail.Text = mostrar.Email;
                        this.textBoxUf.Text = mostrar.Uf;
                    }
                    else
                    {
                        putNothing();
                        mostrar = agenda[contador];
                        this.textBoxNom.Text = mostrar.Nom;
                        this.textBoxCognoms.Text = mostrar.Congoms;
                        this.textBoxMobil1.Text = mostrar.Mobil1;
                        this.textBoxMobil2.Text = mostrar.Mobil2;
                        this.textBoxTelefono.Text = mostrar.Telefono;
                        this.textBoxEmail.Text = mostrar.Email;
                        this.textBoxUf.Text = mostrar.Uf;
                    }
                    break;
                case "buttonFinal":
                    putNothing();
                    contador = maximo;
                    mostrar = agenda[maximo];
                    this.textBoxNom.Text = mostrar.Nom;
                    this.textBoxCognoms.Text = mostrar.Congoms;
                    this.textBoxMobil1.Text = mostrar.Mobil1;
                    this.textBoxMobil2.Text = mostrar.Mobil2;
                    this.textBoxTelefono.Text = mostrar.Telefono;
                    this.textBoxEmail.Text = mostrar.Email;
                    this.textBoxUf.Text = mostrar.Uf;
                    break;
                case "buttonEditar":
                    if (editar)
                    {
                        //Codigo de Botonoes
                        this.buttonAdelante.Enabled = !this.buttonAdelante.Enabled;
                        this.buttonAtras.Enabled = !this.buttonAtras.Enabled;
                        this.buttonPrincipio.Enabled = !this.buttonPrincipio.Enabled;
                        this.buttonFinal.Enabled = !this.buttonFinal.Enabled;
                        this.textBoxNom.ReadOnly = !this.textBoxNom.ReadOnly;
                        this.textBoxCognoms.ReadOnly = !this.textBoxCognoms.ReadOnly;
                        this.textBoxMobil1.ReadOnly = !this.textBoxMobil1.ReadOnly;
                        this.textBoxMobil2.ReadOnly = !this.textBoxMobil2.ReadOnly;
                        this.textBoxTelefono.ReadOnly = !this.textBoxTelefono.ReadOnly;
                        this.textBoxEmail.ReadOnly = !this.textBoxEmail.ReadOnly;
                        this.textBoxUf.ReadOnly = !this.textBoxUf.ReadOnly;
                        // Guardar cambios en local
                        agenda[contador].Nom = this.textBoxNom.Text;
                        agenda[contador].Congoms = this.textBoxCognoms.Text;
                        agenda[contador].Mobil1 = this.textBoxMobil1.Text;
                        agenda[contador].Mobil2 = this.textBoxMobil2.Text;
                        agenda[contador].Telefono = this.textBoxTelefono.Text;
                        agenda[contador].Email = this.textBoxEmail.Text;
                        agenda[contador].Uf = this.textBoxUf.Text;
                    }
                    else
                    {
                        //Codigo de Botones
                        this.buttonAdelante.Enabled = !this.buttonAdelante.Enabled;
                        this.buttonAtras.Enabled = !this.buttonAtras.Enabled;
                        this.buttonPrincipio.Enabled = !this.buttonPrincipio.Enabled;
                        this.buttonFinal.Enabled = !this.buttonFinal.Enabled;
                        this.textBoxNom.ReadOnly = !this.textBoxNom.ReadOnly;
                        this.textBoxCognoms.ReadOnly = !this.textBoxCognoms.ReadOnly;
                        this.textBoxMobil1.ReadOnly = !this.textBoxMobil1.ReadOnly;
                        this.textBoxMobil2.ReadOnly = !this.textBoxMobil2.ReadOnly;
                        this.textBoxTelefono.ReadOnly = !this.textBoxTelefono.ReadOnly;
                        this.textBoxEmail.ReadOnly = !this.textBoxEmail.ReadOnly;
                        this.textBoxUf.ReadOnly = !this.textBoxUf.ReadOnly;
                    }
                    editar = !editar;
                    break;
                case "buttonNuevo":
                    if (nuevo)
                    {
                        //Codigo de Botonoes
                        this.buttonAdelante.Enabled = !this.buttonAdelante.Enabled;
                        this.buttonAtras.Enabled = !this.buttonAtras.Enabled;
                        this.buttonPrincipio.Enabled = !this.buttonPrincipio.Enabled;
                        this.buttonFinal.Enabled = !this.buttonFinal.Enabled;
                        // Codigo TextBox
                        this.textBoxNom.ReadOnly = !this.textBoxNom.ReadOnly;
                        this.textBoxCognoms.ReadOnly = !this.textBoxCognoms.ReadOnly;
                        this.textBoxMobil1.ReadOnly = !this.textBoxMobil1.ReadOnly;
                        this.textBoxMobil2.ReadOnly = !this.textBoxMobil2.ReadOnly;
                        this.textBoxTelefono.ReadOnly = !this.textBoxTelefono.ReadOnly;
                        this.textBoxEmail.ReadOnly = !this.textBoxEmail.ReadOnly;
                        this.textBoxUf.ReadOnly = !this.textBoxUf.ReadOnly;
                        // Guardar cambios en local
                        User foo = new User(this.textBoxNom.Text, this.textBoxCognoms.Text, this.textBoxMobil1.Text, this.textBoxMobil2.Text, this.textBoxTelefono.Text, this.textBoxEmail.Text, this.textBoxUf.Text);
                        agenda.Add(foo);
                        maximo++;
                        contador = maximo;
                    }
                    else
                    {
                        //Codigo de Botones
                        this.buttonAdelante.Enabled = !this.buttonAdelante.Enabled;
                        this.buttonAtras.Enabled = !this.buttonAtras.Enabled;
                        this.buttonPrincipio.Enabled = !this.buttonPrincipio.Enabled;
                        this.buttonFinal.Enabled = !this.buttonFinal.Enabled;
                        // Codigo TextBox
                        this.textBoxNom.ReadOnly = !this.textBoxNom.ReadOnly;
                        this.textBoxCognoms.ReadOnly = !this.textBoxCognoms.ReadOnly;
                        this.textBoxMobil1.ReadOnly = !this.textBoxMobil1.ReadOnly;
                        this.textBoxMobil2.ReadOnly = !this.textBoxMobil2.ReadOnly;
                        this.textBoxTelefono.ReadOnly = !this.textBoxTelefono.ReadOnly;
                        this.textBoxEmail.ReadOnly = !this.textBoxEmail.ReadOnly;
                        this.textBoxUf.ReadOnly = !this.textBoxUf.ReadOnly;
                        // Poner en blanco
                        putNothing();
                    }
                    nuevo = !nuevo;
                    break;
                case "buttonGuardar":
                    if (!editar && !nuevo)
                    {
                        using (System.IO.StreamWriter file = new System.IO.StreamWriter(@".\DAM2.txt"))
                        {
                            for (int i = 0; i <= maximo; i++)
                            {
                                file.WriteLine(agenda[i].Nom + ":" + agenda[i].Congoms + ":" + agenda[i].Mobil1 + "," + agenda[i].Mobil2 + "," + agenda[i].Telefono + ":" + agenda[i].Email + ":" + agenda[i].Uf + ":");
                            }
                        }
                        MessageBox.Show("Cambios guardados en fichero.", "Éxito");
                    }
                    else
                    {
                        MessageBox.Show("Debe finalizar la acción qué está en curso.", "Error");
                    }
                    break;
            }
        }

        private void putNothing()
        {
            this.textBoxNom.Text = " ";
            this.textBoxCognoms.Text = " ";
            this.textBoxMobil1.Text = " ";
            this.textBoxMobil2.Text = " ";
            this.textBoxTelefono.Text = " ";
            this.textBoxEmail.Text = " ";
            this.textBoxUf.Text = " ";
        }
    }
}
