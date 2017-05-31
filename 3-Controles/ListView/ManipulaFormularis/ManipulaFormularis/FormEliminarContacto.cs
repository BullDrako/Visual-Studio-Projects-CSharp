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
    public partial class FormEliminarContacto : Form
    {
        
        public FormEliminarContacto()
        {
            
            InitializeComponent();
        }

        private void EliminarContacto(object sender, EventArgs e)
        {
            String field = "";
            if (!textBox1.Text.Equals(""))
            {
                field = textBox1.Text;
                label1.Text = "";
            }
            else label1.Text = "Has d'omplir aquest camp";
            textBox2.Clear();
            if (!field.Equals(""))
            {
                UserADO listUsers = new UserADO();

                Users auxUsers = listUsers.searchField(field);
                if (auxUsers.Count == 0) textBox2.Text = "No hay coincidencias";
                else
                {
                  
                    DialogResult result = MessageBox.Show("Quieres eliminar el contacto?", "Eliminar",
                                                 MessageBoxButtons.YesNo,
                                                 MessageBoxIcon.Question);
                    switch (result)
                    {
                        case DialogResult.No:
                            
                            label1.Text = "No se ha eliminado ningún contacto.";
                            break;
                        case DialogResult.Yes:
                            auxUsers = listUsers.deleteUser(auxUsers);
                            if (auxUsers.Count == 0) label1.Text = "Problemas con el fichero.";
                            else
                            {

                                textBox2.Text = "LLISTA DELS CONTACTES ACTUALS\r\n";

                                foreach (User user in auxUsers)
                                {

                                    textBox2.Text += user.toString();

                                }
                                
                            }
                            break;
                    }


                }
                
            }  
            
            
            
            
                    
                
        }

        private void tancant(object sender, FormClosingEventArgs e)
        {
            DialogResult = DialogResult.Yes;
        }

        private void FormEliminarContacto_Load(object sender, EventArgs e)
        {

        }
    }
}
