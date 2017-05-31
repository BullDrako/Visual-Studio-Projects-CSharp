namespace ExamenAccesDades
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
            this.llistatPerCategoriesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sortirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.carnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.peixToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.afegirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.esborrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.llistatPerCategoriesToolStripMenuItem,
            this.accionsToolStripMenuItem,
            this.sortirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(428, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // llistatPerCategoriesToolStripMenuItem
            // 
            this.llistatPerCategoriesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toresToolStripMenuItem,
            this.carnToolStripMenuItem,
            this.peixToolStripMenuItem});
            this.llistatPerCategoriesToolStripMenuItem.Name = "llistatPerCategoriesToolStripMenuItem";
            this.llistatPerCategoriesToolStripMenuItem.Size = new System.Drawing.Size(127, 20);
            this.llistatPerCategoriesToolStripMenuItem.Text = "Llistat per categories";
            // 
            // accionsToolStripMenuItem
            // 
            this.accionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.afegirToolStripMenuItem,
            this.esborrarToolStripMenuItem});
            this.accionsToolStripMenuItem.Name = "accionsToolStripMenuItem";
            this.accionsToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.accionsToolStripMenuItem.Text = "Accions ";
            // 
            // sortirToolStripMenuItem
            // 
            this.sortirToolStripMenuItem.Name = "sortirToolStripMenuItem";
            this.sortirToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.sortirToolStripMenuItem.Text = "Sortir";
            this.sortirToolStripMenuItem.Click += new System.EventHandler(this.sortirToolStripMenuItem_Click);
            // 
            // toresToolStripMenuItem
            // 
            this.toresToolStripMenuItem.Name = "toresToolStripMenuItem";
            this.toresToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.toresToolStripMenuItem.Text = "Totes";
            this.toresToolStripMenuItem.Click += new System.EventHandler(this.toresToolStripMenuItem_Click);
            // 
            // carnToolStripMenuItem
            // 
            this.carnToolStripMenuItem.Name = "carnToolStripMenuItem";
            this.carnToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.carnToolStripMenuItem.Text = "Carn";
            this.carnToolStripMenuItem.Click += new System.EventHandler(this.carnToolStripMenuItem_Click);
            // 
            // peixToolStripMenuItem
            // 
            this.peixToolStripMenuItem.Name = "peixToolStripMenuItem";
            this.peixToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.peixToolStripMenuItem.Text = "Peix";
            this.peixToolStripMenuItem.Click += new System.EventHandler(this.peixToolStripMenuItem_Click);
            // 
            // afegirToolStripMenuItem
            // 
            this.afegirToolStripMenuItem.Name = "afegirToolStripMenuItem";
            this.afegirToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.afegirToolStripMenuItem.Text = "Afegir";
            this.afegirToolStripMenuItem.Click += new System.EventHandler(this.afegirToolStripMenuItem_Click);
            // 
            // esborrarToolStripMenuItem
            // 
            this.esborrarToolStripMenuItem.Name = "esborrarToolStripMenuItem";
            this.esborrarToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.esborrarToolStripMenuItem.Text = "Esborrar";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 261);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem llistatPerCategoriesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem carnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem peixToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sortirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem afegirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem esborrarToolStripMenuItem;
    }
}

