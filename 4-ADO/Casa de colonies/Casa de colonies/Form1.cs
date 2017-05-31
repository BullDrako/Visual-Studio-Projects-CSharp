using CapaControladora;
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
    public partial class Form1 : Form
    {

        UserController controller;

        public Form1()
        {
            InitializeComponent();
            controller = new UserController();
        }

     

        private void loginToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FormLogin formLogin = new FormLogin();
            formLogin.ShowDialog();
            if (formLogin.DialogResult == DialogResult.OK)
            {
                String userType = controller.checkTypeOfUser(formLogin.nick, formLogin.password);
                MessageBox.Show(userType);
                switch (userType)
                {
                    case "Super":
                        MessageBox.Show("admin");
                        managerToolStripMenuItem.Visible = true;
                        break;
                    case "Basic":
                        MessageBox.Show("basic");
                        break;
                }
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void administradorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAdmin adminForm = new FormAdmin();
            adminForm.MdiParent = this;
            adminForm.Show();
        }
    }
}
