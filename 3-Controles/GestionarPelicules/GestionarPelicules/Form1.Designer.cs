namespace GestionarPelicules
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arxiuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aparençaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.obrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.anomenaIDesaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sortirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.afegirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actualitzarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.textBoxa = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arxiuToolStripMenuItem,
            this.accionsToolStripMenuItem,
            this.aparençaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(542, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // arxiuToolStripMenuItem
            // 
            this.arxiuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.obrirToolStripMenuItem,
            this.anomenaIDesaToolStripMenuItem,
            this.sortirToolStripMenuItem});
            this.arxiuToolStripMenuItem.Name = "arxiuToolStripMenuItem";
            this.arxiuToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.arxiuToolStripMenuItem.Text = "Arxiu";
            // 
            // accionsToolStripMenuItem
            // 
            this.accionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.afegirToolStripMenuItem,
            this.actualitzarToolStripMenuItem,
            this.eliminarToolStripMenuItem});
            this.accionsToolStripMenuItem.Name = "accionsToolStripMenuItem";
            this.accionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.accionsToolStripMenuItem.Text = "Accions";
            // 
            // aparençaToolStripMenuItem
            // 
            this.aparençaToolStripMenuItem.Name = "aparençaToolStripMenuItem";
            this.aparençaToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.aparençaToolStripMenuItem.Text = "Aparença";
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.treeView1.Location = new System.Drawing.Point(0, 24);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(121, 237);
            this.treeView1.TabIndex = 2;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Location = new System.Drawing.Point(121, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(421, 25);
            this.toolStrip1.TabIndex = 3;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // obrirToolStripMenuItem
            // 
            this.obrirToolStripMenuItem.Name = "obrirToolStripMenuItem";
            this.obrirToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.obrirToolStripMenuItem.Text = "Obrir";
            this.obrirToolStripMenuItem.Click += new System.EventHandler(this.obrirToolStripMenuItem_Click);
            // 
            // anomenaIDesaToolStripMenuItem
            // 
            this.anomenaIDesaToolStripMenuItem.Name = "anomenaIDesaToolStripMenuItem";
            this.anomenaIDesaToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.anomenaIDesaToolStripMenuItem.Text = "Anomena i Desa";
            this.anomenaIDesaToolStripMenuItem.Click += new System.EventHandler(this.anomenaIDesaToolStripMenuItem_Click);
            // 
            // sortirToolStripMenuItem
            // 
            this.sortirToolStripMenuItem.Name = "sortirToolStripMenuItem";
            this.sortirToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.sortirToolStripMenuItem.Text = "Sortir";
            // 
            // afegirToolStripMenuItem
            // 
            this.afegirToolStripMenuItem.Name = "afegirToolStripMenuItem";
            this.afegirToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.afegirToolStripMenuItem.Text = "Afegir";
            this.afegirToolStripMenuItem.Click += new System.EventHandler(this.afegirToolStripMenuItem_Click);
            // 
            // actualitzarToolStripMenuItem
            // 
            this.actualitzarToolStripMenuItem.Name = "actualitzarToolStripMenuItem";
            this.actualitzarToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.actualitzarToolStripMenuItem.Text = "Actualitzar";
            this.actualitzarToolStripMenuItem.Click += new System.EventHandler(this.actualitzarToolStripMenuItem_Click);
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.eliminarToolStripMenuItem.Text = "Eliminar";
            // 
            // textBoxa
            // 
            this.textBoxa.Location = new System.Drawing.Point(306, 106);
            this.textBoxa.Name = "textBoxa";
            this.textBoxa.Size = new System.Drawing.Size(100, 20);
            this.textBoxa.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 261);
            this.Controls.Add(this.textBoxa);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arxiuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem obrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem anomenaIDesaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sortirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem afegirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actualitzarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aparençaToolStripMenuItem;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.TextBox textBoxa;
    }
}

