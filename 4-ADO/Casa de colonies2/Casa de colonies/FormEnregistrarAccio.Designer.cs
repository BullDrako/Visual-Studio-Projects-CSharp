namespace Casa_de_colonies
{
    partial class FormEnregistrarAccio
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.casacoloniesDataSet = new Casa_de_colonies.casacoloniesDataSet();
            this.monitortareastandaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.monitor_tareas_tandaTableAdapter = new Casa_de_colonies.casacoloniesDataSetTableAdapters.monitor_tareas_tandaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.casacoloniesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.monitortareastandaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(31, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(436, 205);
            this.dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(481, 65);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Apuntar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // casacoloniesDataSet
            // 
            this.casacoloniesDataSet.DataSetName = "casacoloniesDataSet";
            this.casacoloniesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // monitortareastandaBindingSource
            // 
            this.monitortareastandaBindingSource.DataMember = "monitor_tareas_tanda";
            this.monitortareastandaBindingSource.DataSource = this.casacoloniesDataSet;
            // 
            // monitor_tareas_tandaTableAdapter
            // 
            this.monitor_tareas_tandaTableAdapter.ClearBeforeFill = true;
            // 
            // FormEnregistrarAccio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 261);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormEnregistrarAccio";
            this.Text = "FormEnregistrarAccio";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.casacoloniesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.monitortareastandaBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private casacoloniesDataSet casacoloniesDataSet;
        private System.Windows.Forms.BindingSource monitortareastandaBindingSource;
        private casacoloniesDataSetTableAdapters.monitor_tareas_tandaTableAdapter monitor_tareas_tandaTableAdapter;
    }
}