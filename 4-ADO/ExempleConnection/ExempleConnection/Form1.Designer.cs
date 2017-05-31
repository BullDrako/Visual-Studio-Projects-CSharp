namespace PresentationLayer
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.principalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.validacióToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sortidaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenimentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ususariToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.llibresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.principalToolStripMenuItem,
            this.mantenimentToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(284, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // principalToolStripMenuItem
            // 
            this.principalToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.validacióToolStripMenuItem,
            this.sortidaToolStripMenuItem});
            this.principalToolStripMenuItem.Name = "principalToolStripMenuItem";
            this.principalToolStripMenuItem.Size = new System.Drawing.Size(110, 20);
            this.principalToolStripMenuItem.Text = "Choice an option";
            // 
            // validacióToolStripMenuItem
            // 
            this.validacióToolStripMenuItem.Name = "validacióToolStripMenuItem";
            this.validacióToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.validacióToolStripMenuItem.Text = "Login";
            this.validacióToolStripMenuItem.Click += new System.EventHandler(this.validacióToolStripMenuItem_Click);
            // 
            // sortidaToolStripMenuItem
            // 
            this.sortidaToolStripMenuItem.Name = "sortidaToolStripMenuItem";
            this.sortidaToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.sortidaToolStripMenuItem.Text = "Exit";
            this.sortidaToolStripMenuItem.Click += new System.EventHandler(this.sortidaToolStripMenuItem_Click);
            // 
            // mantenimentToolStripMenuItem
            // 
            this.mantenimentToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ususariToolStripMenuItem,
            this.llibresToolStripMenuItem});
            this.mantenimentToolStripMenuItem.Name = "mantenimentToolStripMenuItem";
            this.mantenimentToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.mantenimentToolStripMenuItem.Text = "Manager";
            this.mantenimentToolStripMenuItem.Visible = false;
            // 
            // ususariToolStripMenuItem
            // 
            this.ususariToolStripMenuItem.Name = "ususariToolStripMenuItem";
            this.ususariToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.ususariToolStripMenuItem.Text = "Users";
            // 
            // llibresToolStripMenuItem
            // 
            this.llibresToolStripMenuItem.Name = "llibresToolStripMenuItem";
            this.llibresToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.llibresToolStripMenuItem.Text = "Books";
            this.llibresToolStripMenuItem.Click += new System.EventHandler(this.llibresToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Main";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem principalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem validacióToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mantenimentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ususariToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem llibresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sortidaToolStripMenuItem;
    }
}

