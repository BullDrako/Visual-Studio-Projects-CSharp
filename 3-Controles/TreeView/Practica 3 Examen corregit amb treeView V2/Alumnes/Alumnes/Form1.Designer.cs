namespace Alumnes
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
            this.label1 = new System.Windows.Forms.Label();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.editar = new System.Windows.Forms.Button();
            this.nou = new System.Windows.Forms.Button();
            this.esborrar = new System.Windows.Forms.Button();
            this.textBoxa = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 13);
            this.label1.TabIndex = 42;
            this.label1.Text = "Llistat dels llibres de la llibreria";
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(12, 33);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(182, 225);
            this.treeView1.TabIndex = 41;
            // 
            // editar
            // 
            this.editar.Location = new System.Drawing.Point(210, 73);
            this.editar.Name = "editar";
            this.editar.Size = new System.Drawing.Size(75, 23);
            this.editar.TabIndex = 43;
            this.editar.Text = "Editar";
            this.editar.UseVisualStyleBackColor = true;
            this.editar.Click += new System.EventHandler(this.actionEditarClick);
            // 
            // nou
            // 
            this.nou.Location = new System.Drawing.Point(210, 129);
            this.nou.Name = "nou";
            this.nou.Size = new System.Drawing.Size(75, 23);
            this.nou.TabIndex = 44;
            this.nou.Text = "Nou";
            this.nou.UseVisualStyleBackColor = true;
            this.nou.Click += new System.EventHandler(this.actionNouClick);
            // 
            // esborrar
            // 
            this.esborrar.Location = new System.Drawing.Point(210, 181);
            this.esborrar.Name = "esborrar";
            this.esborrar.Size = new System.Drawing.Size(75, 23);
            this.esborrar.TabIndex = 45;
            this.esborrar.Text = "Guardar";
            this.esborrar.UseVisualStyleBackColor = true;
            this.esborrar.Click += new System.EventHandler(this.actionSaveClick);
            // 
            // textBoxa
            // 
            this.textBoxa.Location = new System.Drawing.Point(200, 33);
            this.textBoxa.Name = "textBoxa";
            this.textBoxa.Size = new System.Drawing.Size(100, 20);
            this.textBoxa.TabIndex = 46;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 270);
            this.Controls.Add(this.textBoxa);
            this.Controls.Add(this.esborrar);
            this.Controls.Add(this.nou);
            this.Controls.Add(this.editar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.treeView1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Gestió d\'Alumnes";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button editar;
        private System.Windows.Forms.Button nou;
        private System.Windows.Forms.Button esborrar;
        private System.Windows.Forms.TextBox textBoxa;
    }
}

