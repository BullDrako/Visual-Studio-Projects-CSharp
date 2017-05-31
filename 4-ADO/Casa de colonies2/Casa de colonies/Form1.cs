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
                        MessageBox.Show("Ets Super administrador");
                        managerToolStripMenuItem.Visible = true;
                        break; 
                    case "Monitor":
                        MessageBox.Show("Ets monitor");
                        enregistrarToolStripMenuItem.Visible = true;
                        break;
                    case "Admin":
                        MessageBox.Show("Ets Administrador normal");
                        nensIInscripcionsToolStripMenuItem.Visible = true;
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

        private void monitorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormMonitor monitorForm = new FormMonitor();
            monitorForm.MdiParent = this;
            monitorForm.Show();
        }

        private void activitatsCasesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormActivitatCases activitatCasaForm = new FormActivitatCases();
            activitatCasaForm.MdiParent = this;
            activitatCasaForm.Show();
        }

        private void nensToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormNens nensForm = new FormNens();
            nensForm.MdiParent = this;
            nensForm.Show();
        }

        private void enregistrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEnregistrarAccio enregistrarAccio = new FormEnregistrarAccio();
            enregistrarAccio.MdiParent = this;
            enregistrarAccio.Show();
        }

        private void inscripcionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormInscripcions inscripcionsForm = new FormInscripcions();
            inscripcionsForm.MdiParent = this;
            inscripcionsForm.Show();
        }
    }
}
