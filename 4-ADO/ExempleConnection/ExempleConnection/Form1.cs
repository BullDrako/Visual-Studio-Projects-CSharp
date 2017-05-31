using ControllerLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class Form1 : Form
    {
        UserController controller;
        public Form1()
        {
            InitializeComponent();
            controller = new UserController();
        }

        private void validacióToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(controller.checkTypeOfUser("dam2", "dam2"));
            
            FormLogin formLogin = new FormLogin();
            formLogin.ShowDialog();
            if (formLogin.DialogResult == DialogResult.OK)
            {
                String userType = controller.checkTypeOfUser(formLogin.nick, formLogin.password);
                MessageBox.Show(userType);
                switch (userType) { 
                    case "Admin":
                        mantenimentToolStripMenuItem.Visible = true;
                        ususariToolStripMenuItem.Enabled = true;
                        break;
                    case "Basic":
                        mantenimentToolStripMenuItem.Visible = true;
                        ususariToolStripMenuItem.Enabled = false;
                        break;
                }
            }
        }

        private void llibresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormBooks booksForm = new FormBooks();
            booksForm.MdiParent = this;
            booksForm.Show();

            //TODO
            //DataSet books = new DataSet();

        }

        private void sortidaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
