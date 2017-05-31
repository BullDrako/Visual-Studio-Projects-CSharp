namespace AppRepasoExamen
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arxiuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.obrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.anomenaIDesaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sortirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.afegirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actualitzarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aparençaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.habilitarScrollToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.canviarTipusDeFontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonAfegir = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonActualitzar = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonEliminar = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonBuscar = new System.Windows.Forms.ToolStripButton();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.Nombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Director = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Reparto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Pais = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Año = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Duracion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Aqua;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arxiuToolStripMenuItem,
            this.accionsToolStripMenuItem,
            this.aparençaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(917, 24);
            this.menuStrip1.TabIndex = 0;
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
            // obrirToolStripMenuItem
            // 
            this.obrirToolStripMenuItem.Name = "obrirToolStripMenuItem";
            this.obrirToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.obrirToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.obrirToolStripMenuItem.Text = "Obrir";
            this.obrirToolStripMenuItem.Click += new System.EventHandler(this.obrir);
            // 
            // anomenaIDesaToolStripMenuItem
            // 
            this.anomenaIDesaToolStripMenuItem.Name = "anomenaIDesaToolStripMenuItem";
            this.anomenaIDesaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.anomenaIDesaToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.anomenaIDesaToolStripMenuItem.Text = "Anomena i desa";
            this.anomenaIDesaToolStripMenuItem.Click += new System.EventHandler(this.guardar);
            // 
            // sortirToolStripMenuItem
            // 
            this.sortirToolStripMenuItem.Name = "sortirToolStripMenuItem";
            this.sortirToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.sortirToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.sortirToolStripMenuItem.Text = "Sortir";
            this.sortirToolStripMenuItem.Click += new System.EventHandler(this.salir);
            // 
            // accionsToolStripMenuItem
            // 
            this.accionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.afegirToolStripMenuItem,
            this.actualitzarToolStripMenuItem,
            this.eliminarToolStripMenuItem,
            this.buscarToolStripMenuItem});
            this.accionsToolStripMenuItem.Name = "accionsToolStripMenuItem";
            this.accionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.accionsToolStripMenuItem.Text = "Accions";
            // 
            // afegirToolStripMenuItem
            // 
            this.afegirToolStripMenuItem.Name = "afegirToolStripMenuItem";
            this.afegirToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.afegirToolStripMenuItem.Text = "Afegir";
            this.afegirToolStripMenuItem.Click += new System.EventHandler(this.agregar);
            // 
            // actualitzarToolStripMenuItem
            // 
            this.actualitzarToolStripMenuItem.Name = "actualitzarToolStripMenuItem";
            this.actualitzarToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.actualitzarToolStripMenuItem.Text = "Actualitzar";
            this.actualitzarToolStripMenuItem.Click += new System.EventHandler(this.actualizar);
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.eliminarToolStripMenuItem.Text = "Eliminar";
            this.eliminarToolStripMenuItem.Click += new System.EventHandler(this.Eliminar);
            // 
            // buscarToolStripMenuItem
            // 
            this.buscarToolStripMenuItem.Name = "buscarToolStripMenuItem";
            this.buscarToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.buscarToolStripMenuItem.Text = "Buscar";
            this.buscarToolStripMenuItem.Click += new System.EventHandler(this.buscar);
            // 
            // aparençaToolStripMenuItem
            // 
            this.aparençaToolStripMenuItem.Name = "aparençaToolStripMenuItem";
            this.aparençaToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.aparençaToolStripMenuItem.Text = "Aparença";
            this.aparençaToolStripMenuItem.Click += new System.EventHandler(this.aparençaToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.habilitarScrollToolStripMenuItem,
            this.canviarTipusDeFontToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(187, 48);
            // 
            // habilitarScrollToolStripMenuItem
            // 
            this.habilitarScrollToolStripMenuItem.Name = "habilitarScrollToolStripMenuItem";
            this.habilitarScrollToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.habilitarScrollToolStripMenuItem.Text = "Habilitar Scroll";
            this.habilitarScrollToolStripMenuItem.Click += new System.EventHandler(this.Scroll);
            // 
            // canviarTipusDeFontToolStripMenuItem
            // 
            this.canviarTipusDeFontToolStripMenuItem.Name = "canviarTipusDeFontToolStripMenuItem";
            this.canviarTipusDeFontToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.canviarTipusDeFontToolStripMenuItem.Text = "Canviar tipus de Font";
            this.canviarTipusDeFontToolStripMenuItem.Click += new System.EventHandler(this.font);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Enabled = false;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonAfegir,
            this.toolStripButtonActualitzar,
            this.toolStripButtonEliminar,
            this.toolStripButtonBuscar});
            this.toolStrip1.Location = new System.Drawing.Point(208, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(709, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButtonAfegir
            // 
            this.toolStripButtonAfegir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonAfegir.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonAfegir.Image")));
            this.toolStripButtonAfegir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAfegir.Name = "toolStripButtonAfegir";
            this.toolStripButtonAfegir.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonAfegir.Text = "toolStripButton1";
            this.toolStripButtonAfegir.Click += new System.EventHandler(this.agregar);
            // 
            // toolStripButtonActualitzar
            // 
            this.toolStripButtonActualitzar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonActualitzar.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonActualitzar.Image")));
            this.toolStripButtonActualitzar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonActualitzar.Name = "toolStripButtonActualitzar";
            this.toolStripButtonActualitzar.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonActualitzar.Text = "toolStripButton2";
            this.toolStripButtonActualitzar.Click += new System.EventHandler(this.actualizar);
            // 
            // toolStripButtonEliminar
            // 
            this.toolStripButtonEliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonEliminar.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonEliminar.Image")));
            this.toolStripButtonEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonEliminar.Name = "toolStripButtonEliminar";
            this.toolStripButtonEliminar.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonEliminar.Text = "toolStripButton3";
            this.toolStripButtonEliminar.Click += new System.EventHandler(this.Eliminar);
            // 
            // toolStripButtonBuscar
            // 
            this.toolStripButtonBuscar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonBuscar.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonBuscar.Image")));
            this.toolStripButtonBuscar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonBuscar.Name = "toolStripButtonBuscar";
            this.toolStripButtonBuscar.Size = new System.Drawing.Size(23, 22);
            this.toolStripButtonBuscar.Text = "toolStripButton4";
            this.toolStripButtonBuscar.Click += new System.EventHandler(this.buscar);
            // 
            // comboBox1
            // 
            this.comboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Director",
            "Actor"});
            this.comboBox1.Location = new System.Drawing.Point(6, 19);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(679, 21);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.Text = "Filtrar per ...";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Nombre,
            this.Director,
            this.Reparto,
            this.Pais,
            this.Año,
            this.Duracion});
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(6, 46);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(679, 399);
            this.listView1.TabIndex = 4;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // Nombre
            // 
            this.Nombre.Text = "Nombre";
            this.Nombre.Width = 107;
            // 
            // Director
            // 
            this.Director.Text = "Director";
            this.Director.Width = 123;
            // 
            // Reparto
            // 
            this.Reparto.Text = "Reparto";
            this.Reparto.Width = 200;
            // 
            // Pais
            // 
            this.Pais.Text = "Pais";
            this.Pais.Width = 79;
            // 
            // Año
            // 
            this.Año.Text = "Año";
            this.Año.Width = 76;
            // 
            // Duracion
            // 
            this.Duracion.Text = "Duracion";
            this.Duracion.Width = 68;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.listView1);
            this.groupBox1.Location = new System.Drawing.Point(214, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(691, 457);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cerca";
            // 
            // treeView1
            // 
            this.treeView1.BackColor = System.Drawing.Color.Aqua;
            this.treeView1.ContextMenuStrip = this.contextMenuStrip1;
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.treeView1.Location = new System.Drawing.Point(0, 24);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(208, 485);
            this.treeView1.TabIndex = 1;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.afterSelect);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 509);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.Text = "Gestor de Películas";
            this.Load += new System.EventHandler(this.Form_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arxiuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem obrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem anomenaIDesaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sortirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aparençaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem afegirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actualitzarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButtonAfegir;
        private System.Windows.Forms.ToolStripButton toolStripButtonActualitzar;
        private System.Windows.Forms.ToolStripButton toolStripButtonEliminar;
        private System.Windows.Forms.ToolStripButton toolStripButtonBuscar;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Nombre;
        private System.Windows.Forms.ColumnHeader Director;
        private System.Windows.Forms.ColumnHeader Reparto;
        private System.Windows.Forms.ColumnHeader Pais;
        private System.Windows.Forms.ColumnHeader Año;
        private System.Windows.Forms.ColumnHeader Duracion;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem habilitarScrollToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem canviarTipusDeFontToolStripMenuItem;
        private System.Windows.Forms.TreeView treeView1;
    }
}

