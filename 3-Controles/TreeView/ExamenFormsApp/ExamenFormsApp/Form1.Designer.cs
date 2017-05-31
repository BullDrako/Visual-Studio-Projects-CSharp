namespace ExamenFormsApp
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
            this.buttonAtras = new System.Windows.Forms.Button();
            this.buttonPrincipio = new System.Windows.Forms.Button();
            this.labelNom = new System.Windows.Forms.Label();
            this.labelCognoms = new System.Windows.Forms.Label();
            this.labelMobil1 = new System.Windows.Forms.Label();
            this.labelMobil2 = new System.Windows.Forms.Label();
            this.textBoxNom = new System.Windows.Forms.TextBox();
            this.textBoxCognoms = new System.Windows.Forms.TextBox();
            this.textBoxMobil1 = new System.Windows.Forms.TextBox();
            this.textBoxMobil2 = new System.Windows.Forms.TextBox();
            this.labelTelefono = new System.Windows.Forms.Label();
            this.textBoxTelefono = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.labelEmail = new System.Windows.Forms.Label();
            this.textBoxUf = new System.Windows.Forms.TextBox();
            this.labelUf = new System.Windows.Forms.Label();
            this.buttonAdelante = new System.Windows.Forms.Button();
            this.buttonFinal = new System.Windows.Forms.Button();
            this.buttonNuevo = new System.Windows.Forms.Button();
            this.buttonEditar = new System.Windows.Forms.Button();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonAtras
            // 
            this.buttonAtras.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonAtras.Location = new System.Drawing.Point(12, 12);
            this.buttonAtras.Name = "buttonAtras";
            this.buttonAtras.Size = new System.Drawing.Size(75, 23);
            this.buttonAtras.TabIndex = 0;
            this.buttonAtras.Text = "<";
            this.buttonAtras.UseVisualStyleBackColor = true;
            this.buttonAtras.Click += new System.EventHandler(this.Click);
            // 
            // buttonPrincipio
            // 
            this.buttonPrincipio.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonPrincipio.Location = new System.Drawing.Point(12, 41);
            this.buttonPrincipio.Name = "buttonPrincipio";
            this.buttonPrincipio.Size = new System.Drawing.Size(75, 23);
            this.buttonPrincipio.TabIndex = 1;
            this.buttonPrincipio.Text = "<<";
            this.buttonPrincipio.UseVisualStyleBackColor = true;
            this.buttonPrincipio.Click += new System.EventHandler(this.Click);
            // 
            // labelNom
            // 
            this.labelNom.AutoSize = true;
            this.labelNom.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.labelNom.Location = new System.Drawing.Point(93, 16);
            this.labelNom.Name = "labelNom";
            this.labelNom.Size = new System.Drawing.Size(32, 15);
            this.labelNom.TabIndex = 2;
            this.labelNom.Text = "Nom";
            // 
            // labelCognoms
            // 
            this.labelCognoms.AutoSize = true;
            this.labelCognoms.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.labelCognoms.Location = new System.Drawing.Point(93, 45);
            this.labelCognoms.Name = "labelCognoms";
            this.labelCognoms.Size = new System.Drawing.Size(56, 15);
            this.labelCognoms.TabIndex = 3;
            this.labelCognoms.Text = "Cognoms";
            // 
            // labelMobil1
            // 
            this.labelMobil1.AutoSize = true;
            this.labelMobil1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.labelMobil1.Location = new System.Drawing.Point(93, 78);
            this.labelMobil1.Name = "labelMobil1";
            this.labelMobil1.Size = new System.Drawing.Size(46, 15);
            this.labelMobil1.TabIndex = 4;
            this.labelMobil1.Text = "Móbil 1";
            // 
            // labelMobil2
            // 
            this.labelMobil2.AutoSize = true;
            this.labelMobil2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.labelMobil2.Location = new System.Drawing.Point(93, 106);
            this.labelMobil2.Name = "labelMobil2";
            this.labelMobil2.Size = new System.Drawing.Size(46, 15);
            this.labelMobil2.TabIndex = 5;
            this.labelMobil2.Text = "Móbil 2";
            // 
            // textBoxNom
            // 
            this.textBoxNom.Location = new System.Drawing.Point(160, 13);
            this.textBoxNom.Name = "textBoxNom";
            this.textBoxNom.ReadOnly = true;
            this.textBoxNom.Size = new System.Drawing.Size(206, 22);
            this.textBoxNom.TabIndex = 6;
            // 
            // textBoxCognoms
            // 
            this.textBoxCognoms.Location = new System.Drawing.Point(160, 45);
            this.textBoxCognoms.Name = "textBoxCognoms";
            this.textBoxCognoms.ReadOnly = true;
            this.textBoxCognoms.Size = new System.Drawing.Size(206, 22);
            this.textBoxCognoms.TabIndex = 7;
            // 
            // textBoxMobil1
            // 
            this.textBoxMobil1.Location = new System.Drawing.Point(160, 75);
            this.textBoxMobil1.Name = "textBoxMobil1";
            this.textBoxMobil1.ReadOnly = true;
            this.textBoxMobil1.Size = new System.Drawing.Size(206, 22);
            this.textBoxMobil1.TabIndex = 8;
            // 
            // textBoxMobil2
            // 
            this.textBoxMobil2.Location = new System.Drawing.Point(160, 103);
            this.textBoxMobil2.Name = "textBoxMobil2";
            this.textBoxMobil2.ReadOnly = true;
            this.textBoxMobil2.Size = new System.Drawing.Size(206, 22);
            this.textBoxMobil2.TabIndex = 9;
            // 
            // labelTelefono
            // 
            this.labelTelefono.AutoSize = true;
            this.labelTelefono.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.labelTelefono.Location = new System.Drawing.Point(53, 134);
            this.labelTelefono.Name = "labelTelefono";
            this.labelTelefono.Size = new System.Drawing.Size(96, 15);
            this.labelTelefono.TabIndex = 10;
            this.labelTelefono.Text = "Teléfono de Casa";
            // 
            // textBoxTelefono
            // 
            this.textBoxTelefono.Location = new System.Drawing.Point(160, 131);
            this.textBoxTelefono.Name = "textBoxTelefono";
            this.textBoxTelefono.ReadOnly = true;
            this.textBoxTelefono.Size = new System.Drawing.Size(206, 22);
            this.textBoxTelefono.TabIndex = 11;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(160, 159);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.ReadOnly = true;
            this.textBoxEmail.Size = new System.Drawing.Size(206, 22);
            this.textBoxEmail.TabIndex = 12;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.labelEmail.Location = new System.Drawing.Point(93, 162);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(35, 15);
            this.labelEmail.TabIndex = 13;
            this.labelEmail.Text = "Email";
            // 
            // textBoxUf
            // 
            this.textBoxUf.Location = new System.Drawing.Point(160, 187);
            this.textBoxUf.Multiline = true;
            this.textBoxUf.Name = "textBoxUf";
            this.textBoxUf.ReadOnly = true;
            this.textBoxUf.Size = new System.Drawing.Size(206, 87);
            this.textBoxUf.TabIndex = 14;
            // 
            // labelUf
            // 
            this.labelUf.AutoSize = true;
            this.labelUf.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.labelUf.Location = new System.Drawing.Point(13, 190);
            this.labelUf.Name = "labelUf";
            this.labelUf.Size = new System.Drawing.Size(136, 15);
            this.labelUf.TabIndex = 15;
            this.labelUf.Text = "Módulos / Uf pendientes";
            // 
            // buttonAdelante
            // 
            this.buttonAdelante.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonAdelante.Location = new System.Drawing.Point(372, 12);
            this.buttonAdelante.Name = "buttonAdelante";
            this.buttonAdelante.Size = new System.Drawing.Size(75, 23);
            this.buttonAdelante.TabIndex = 16;
            this.buttonAdelante.Text = ">";
            this.buttonAdelante.UseVisualStyleBackColor = true;
            this.buttonAdelante.Click += new System.EventHandler(this.Click);
            // 
            // buttonFinal
            // 
            this.buttonFinal.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonFinal.Location = new System.Drawing.Point(372, 41);
            this.buttonFinal.Name = "buttonFinal";
            this.buttonFinal.Size = new System.Drawing.Size(75, 23);
            this.buttonFinal.TabIndex = 17;
            this.buttonFinal.Text = ">>";
            this.buttonFinal.UseVisualStyleBackColor = true;
            this.buttonFinal.Click += new System.EventHandler(this.Click);
            // 
            // buttonNuevo
            // 
            this.buttonNuevo.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonNuevo.Location = new System.Drawing.Point(241, 299);
            this.buttonNuevo.Name = "buttonNuevo";
            this.buttonNuevo.Size = new System.Drawing.Size(75, 23);
            this.buttonNuevo.TabIndex = 18;
            this.buttonNuevo.Text = "Nou";
            this.buttonNuevo.UseVisualStyleBackColor = true;
            this.buttonNuevo.Click += new System.EventHandler(this.Click);
            // 
            // buttonEditar
            // 
            this.buttonEditar.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonEditar.Location = new System.Drawing.Point(160, 299);
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Size = new System.Drawing.Size(75, 23);
            this.buttonEditar.TabIndex = 19;
            this.buttonEditar.Text = "Editar";
            this.buttonEditar.UseVisualStyleBackColor = true;
            this.buttonEditar.Click += new System.EventHandler(this.Click);
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.buttonGuardar.Location = new System.Drawing.Point(322, 299);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(75, 23);
            this.buttonGuardar.TabIndex = 20;
            this.buttonGuardar.Text = "Guardar";
            this.buttonGuardar.UseVisualStyleBackColor = true;
            this.buttonGuardar.Click += new System.EventHandler(this.Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 334);
            this.Controls.Add(this.buttonGuardar);
            this.Controls.Add(this.buttonEditar);
            this.Controls.Add(this.buttonNuevo);
            this.Controls.Add(this.buttonFinal);
            this.Controls.Add(this.buttonAdelante);
            this.Controls.Add(this.labelUf);
            this.Controls.Add(this.textBoxUf);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.textBoxTelefono);
            this.Controls.Add(this.labelTelefono);
            this.Controls.Add(this.textBoxMobil2);
            this.Controls.Add(this.textBoxMobil1);
            this.Controls.Add(this.textBoxCognoms);
            this.Controls.Add(this.textBoxNom);
            this.Controls.Add(this.labelMobil2);
            this.Controls.Add(this.labelMobil1);
            this.Controls.Add(this.labelCognoms);
            this.Controls.Add(this.labelNom);
            this.Controls.Add(this.buttonPrincipio);
            this.Controls.Add(this.buttonAtras);
            this.Font = new System.Drawing.Font("Open Sans", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Alumnes Dam curs 16-17";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAtras;
        private System.Windows.Forms.Button buttonPrincipio;
        private System.Windows.Forms.Label labelNom;
        private System.Windows.Forms.Label labelCognoms;
        private System.Windows.Forms.Label labelMobil1;
        private System.Windows.Forms.Label labelMobil2;
        private System.Windows.Forms.TextBox textBoxNom;
        private System.Windows.Forms.TextBox textBoxCognoms;
        private System.Windows.Forms.TextBox textBoxMobil1;
        private System.Windows.Forms.TextBox textBoxMobil2;
        private System.Windows.Forms.Label labelTelefono;
        private System.Windows.Forms.TextBox textBoxTelefono;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.TextBox textBoxUf;
        private System.Windows.Forms.Label labelUf;
        private System.Windows.Forms.Button buttonAdelante;
        private System.Windows.Forms.Button buttonFinal;
        private System.Windows.Forms.Button buttonNuevo;
        private System.Windows.Forms.Button buttonEditar;
        private System.Windows.Forms.Button buttonGuardar;
    }
}

