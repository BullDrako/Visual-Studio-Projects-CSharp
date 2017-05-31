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
    public partial class FormBuscarContacto : Form
    {
        
        public FormBuscarContacto()
        {
            
            InitializeComponent();
        }

        private void BuscarContacto(object sender, EventArgs e)
        {
            String field = "";
            if (!textBox1.Text.Equals(""))
            {
                field = textBox1.Text;
                label2.Text = "";
            }
            else label2.Text = "Has d'omplir aquest camp";
            textBox3.Clear();
            if(!field.Equals("")){
                UserADO listUsers = new UserADO();

                Users searchedUsers = listUsers.searchField(field);
                if (searchedUsers.Count==0) textBox3.Text="No hay coincidencias";
                foreach (User user in searchedUsers){
                
                    textBox3.Text += user.toString();
                    
                }
            } 
        }

        private void FormBuscarContacto_Load(object sender, EventArgs e)
        {

        }
    }
}
