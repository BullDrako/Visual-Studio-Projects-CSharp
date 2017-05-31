using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManipulaFormularis
{
    public partial class Form1 : Form
    {
        public String file;
        public Form1()
        {
            InitializeComponent();
        }

        
        //informació general sobre l'autor i la versió. Diàleg modal fet per mi
        private void sobreLautorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.ShowDialog(); // Si acaba en dialog es modal
        }

        //procediment per carregar totes les dades del fitxer
        private void carrega(String fileName)
        {
            
            
            UserADO listUsers;
            if (fileName.Equals("")) listUsers = new UserADO();
            else listUsers = new UserADO(fileName);

             
            Users allUsers = listUsers.allFile();
            ompleTextBox(allUsers);
        }

        //procediment per ficar dins del meu textbox les dades recollides del fitxer
        private void ompleTextBox(Users allUsers){

            if (allUsers != null)
            {
                foreach (User user in allUsers)
                {
                    textBox1.Text += user.Username + " " + user.Lastnames + " " + user.Phone + " " + user.Mobile + " " + user.Address + " " + user.City + " " + user.Email + "\r\n";
                }



            }


        }

        //procediment que fa laprimera càrrega quan li senyalo el fitxer des de openfiledialog
        private void carregaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            openFileDialog1.Filter = "Text|*.txt|Texto enriquecido|*.rtf";
            openFileDialog1.InitialDirectory = "D:\\";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.Title = "Escoge un fichero de usuarios";
            openFileDialog1.FileName = "";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                
                //mano fer la càrrega un cop sabem l'arxiu
                carrega(openFileDialog1.FileName);
               
                //deshabilito i habilito opcions
                textBox1.Enabled = false;
                deNouToolStripMenuItem.Enabled = true;
                guardarToolStripMenuItem.Enabled = true;
                sortirToolStripMenuItem.Enabled = true;
                edicioToolStripMenuItem.Enabled = true;
                toolStrip1.Enabled = true;
            }
        }


       

        private void Nuevo(object sender, EventArgs e)
        {
            if (textBox1.TextLength > 0)
            {

                DialogResult result = message("Quieres guardas los datos?", "Nuevo");
                if (result == DialogResult.Yes)
                {
                    Guardar(sender, e);
                    
                }
                textBox1.Clear();
                textBox1.Enabled = true;
            }
            else
            {
                textBox1.Enabled = true;
            }
        }


        private void Guardar(object sender, EventArgs e)
        {
            
            UserADO listUsers = new UserADO();
            
            int t=listUsers.saveAllFile();
            if (t == -1) message("Problemas con el fichero", "ATENCIÓN");
            else if (t == 0) message("No se ha guardado nada", "ATENCIÓN");
            else  MessageBox.Show("Los contactos han sido guardados.");
            
           
           
        }

       

        private void Salir(object sender, EventArgs e)
        {
           
            
            var result = message( "¿Estás seguro que quieres salir?", "ATENCIÓN: Acuérdate de guardar antes de salir");

            
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
           
        }

        private void BuscarContacto(object sender, EventArgs e)
        {
            FormBuscarContacto formBuscar = new FormBuscarContacto();
           

            //obro el formulari i me n'entero quan ha tancat i si vull puc fer alguna cosa més de del meu formulari principal
            if(formBuscar.ShowDialog()==DialogResult.OK){

            }

        }

        private void EliminarContacto(object sender, EventArgs e)
        {
            FormEliminarContacto formEliminar = new FormEliminarContacto();

            //obro el formulari i me n'entero quan ha tancat i des del meu formulari principal acabo de fer la càrrega correcta de dades
            if (formEliminar.ShowDialog() == DialogResult.Yes){
                textBox1.Text = "";
                UserADO listUsers=new UserADO();
                foreach(User user in listUsers.AllUsers){
                    textBox1.Text += user.toString();
                }
            }
        }

        private void ModificarContacto(object sender, EventArgs e)
        {
            FormModificarContacto formModificar = new FormModificarContacto(textBox1.Lines);
            if (formModificar.ShowDialog() == DialogResult.Yes)
            {
//to do
            }
            
        }

        //Dialogs que necessito en el menu contextual
        private void colorDeFondoToolStripMenuItem_Click(object sender, EventArgs e)
        {
             if (colorDialog1.ShowDialog() == DialogResult.OK) textBox1.BackColor = colorDialog1.Color;
        }

        private void tipoDeLetraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK) textBox1.Font = fontDialog1.Font;
        }

        //funció que crea un tipus de missatge sempre el mateix i que es fa servir bastant a l'aplicació
        private DialogResult message(String bodyMessage, String titleMessage)
        {
            DialogResult result = MessageBox.Show(bodyMessage, titleMessage,
                                            MessageBoxButtons.YesNo,
                                            MessageBoxIcon.Question);
           return result;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
