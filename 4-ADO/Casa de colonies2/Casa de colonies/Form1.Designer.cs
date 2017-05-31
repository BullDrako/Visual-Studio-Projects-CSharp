namespace Casa_de_colonies
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.choiceAnOptionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loginToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.managerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administradorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.monitorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.activitatsCasesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nensIInscripcionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nensToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inscripcionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enregistrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.choiceAnOptionToolStripMenuItem,
            this.managerToolStripMenuItem,
            this.nensIInscripcionsToolStripMenuItem,
            this.enregistrarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(402, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // choiceAnOptionToolStripMenuItem
            // 
            this.choiceAnOptionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loginToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.choiceAnOptionToolStripMenuItem.Name = "choiceAnOptionToolStripMenuItem";
            this.choiceAnOptionToolStripMenuItem.Size = new System.Drawing.Size(110, 20);
            this.choiceAnOptionToolStripMenuItem.Text = "Choice an option";
            // 
            // loginToolStripMenuItem
            // 
            this.loginToolStripMenuItem.Name = "loginToolStripMenuItem";
            this.loginToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.loginToolStripMenuItem.Text = "Login";
            this.loginToolStripMenuItem.Click += new System.EventHandler(this.loginToolStripMenuItem_Click_1);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // managerToolStripMenuItem
            // 
            this.managerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.administradorsToolStripMenuItem,
            this.monitorsToolStripMenuItem,
            this.activitatsCasesToolStripMenuItem});
            this.managerToolStripMenuItem.Name = "managerToolStripMenuItem";
            this.managerToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.managerToolStripMenuItem.Text = "Manager";
            this.managerToolStripMenuItem.Visible = false;
            // 
            // administradorsToolStripMenuItem
            // 
            this.administradorsToolStripMenuItem.Name = "administradorsToolStripMenuItem";
            this.administradorsToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.administradorsToolStripMenuItem.Text = "Administradors";
            this.administradorsToolStripMenuItem.Click += new System.EventHandler(this.administradorsToolStripMenuItem_Click);
            // 
            // monitorsToolStripMenuItem
            // 
            this.monitorsToolStripMenuItem.Name = "monitorsToolStripMenuItem";
            this.monitorsToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.monitorsToolStripMenuItem.Text = "Monitors";
            this.monitorsToolStripMenuItem.Click += new System.EventHandler(this.monitorsToolStripMenuItem_Click);
            // 
            // activitatsCasesToolStripMenuItem
            // 
            this.activitatsCasesToolStripMenuItem.Name = "activitatsCasesToolStripMenuItem";
            this.activitatsCasesToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.activitatsCasesToolStripMenuItem.Text = "Activitats Cases";
            this.activitatsCasesToolStripMenuItem.Click += new System.EventHandler(this.activitatsCasesToolStripMenuItem_Click);
            // 
            // nensIInscripcionsToolStripMenuItem
            // 
            this.nensIInscripcionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nensToolStripMenuItem,
            this.inscripcionsToolStripMenuItem});
            this.nensIInscripcionsToolStripMenuItem.Name = "nensIInscripcionsToolStripMenuItem";
            this.nensIInscripcionsToolStripMenuItem.Size = new System.Drawing.Size(118, 20);
            this.nensIInscripcionsToolStripMenuItem.Text = "Nens i Inscripcions";
            this.nensIInscripcionsToolStripMenuItem.Visible = false;
            // 
            // nensToolStripMenuItem
            // 
            this.nensToolStripMenuItem.Name = "nensToolStripMenuItem";
            this.nensToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.nensToolStripMenuItem.Text = "Nens";
            this.nensToolStripMenuItem.Click += new System.EventHandler(this.nensToolStripMenuItem_Click);
            // 
            // inscripcionsToolStripMenuItem
            // 
            this.inscripcionsToolStripMenuItem.Name = "inscripcionsToolStripMenuItem";
            this.inscripcionsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.inscripcionsToolStripMenuItem.Text = "Inscripcions";
            this.inscripcionsToolStripMenuItem.Click += new System.EventHandler(this.inscripcionsToolStripMenuItem_Click);
            // 
            // enregistrarToolStripMenuItem
            // 
            this.enregistrarToolStripMenuItem.Name = "enregistrarToolStripMenuItem";
            this.enregistrarToolStripMenuItem.Size = new System.Drawing.Size(75, 20);
            this.enregistrarToolStripMenuItem.Text = "Enregistrar";
            this.enregistrarToolStripMenuItem.Visible = false;
            this.enregistrarToolStripMenuItem.Click += new System.EventHandler(this.enregistrarToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(402, 261);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem choiceAnOptionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loginToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem managerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administradorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem monitorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem activitatsCasesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nensIInscripcionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nensToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inscripcionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enregistrarToolStripMenuItem;
    }
}

