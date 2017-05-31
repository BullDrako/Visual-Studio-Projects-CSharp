namespace BotonHola
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
            this.botonHola = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // botonHola
            // 
            this.botonHola.Location = new System.Drawing.Point(106, 144);
            this.botonHola.Name = "botonHola";
            this.botonHola.Size = new System.Drawing.Size(75, 23);
            this.botonHola.TabIndex = 0;
            this.botonHola.Text = "Hola";
            this.botonHola.UseVisualStyleBackColor = true;
            this.botonHola.Click += new System.EventHandler(this.ClickBoton);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.botonHola);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button botonHola;
    }
}

