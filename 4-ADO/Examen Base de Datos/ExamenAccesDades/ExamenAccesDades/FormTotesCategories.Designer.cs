namespace ExamenAccesDades
{
    partial class FormTotesCategories
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
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.listView1 = new System.Windows.Forms.ListView();
            this.accionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.afegirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.esborrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.accionsToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(117, 26);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listView1.Location = new System.Drawing.Point(91, 70);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(479, 97);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // accionsToolStripMenuItem
            // 
            this.accionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.afegirToolStripMenuItem,
            this.esborrarToolStripMenuItem});
            this.accionsToolStripMenuItem.Name = "accionsToolStripMenuItem";
            this.accionsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.accionsToolStripMenuItem.Text = "Accions";
            // 
            // afegirToolStripMenuItem
            // 
            this.afegirToolStripMenuItem.Name = "afegirToolStripMenuItem";
            this.afegirToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.afegirToolStripMenuItem.Text = "Afegir";
            // 
            // esborrarToolStripMenuItem
            // 
            this.esborrarToolStripMenuItem.Name = "esborrarToolStripMenuItem";
            this.esborrarToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.esborrarToolStripMenuItem.Text = "Esborrar";
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "NomRecepta";
            this.columnHeader1.Width = 89;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Temps_preparacio";
            this.columnHeader2.Width = 104;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Ingredients";
            this.columnHeader3.Width = 80;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Descripcio";
            this.columnHeader4.Width = 91;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Dificultat";
            // 
            // FormTotesCategories
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(659, 261);
            this.Controls.Add(this.listView1);
            this.Name = "FormTotesCategories";
            this.Text = "FormTotesCategories";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ToolStripMenuItem accionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem afegirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem esborrarToolStripMenuItem;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
    }
}