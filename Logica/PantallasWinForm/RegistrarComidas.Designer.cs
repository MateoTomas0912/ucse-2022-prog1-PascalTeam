namespace PantallasWinForm
{
    partial class RegistrarComidas
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.fechaComida = new System.Windows.Forms.DateTimePicker();
            this.grillaRecetas = new System.Windows.Forms.DataGridView();
            this.btn_salir = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.CheckReceta = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grillaRecetas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 177);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Selecciona la receta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 117);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Selecciona la fecha";
            // 
            // fechaComida
            // 
            this.fechaComida.Location = new System.Drawing.Point(187, 113);
            this.fechaComida.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.fechaComida.Name = "fechaComida";
            this.fechaComida.Size = new System.Drawing.Size(204, 20);
            this.fechaComida.TabIndex = 2;
            // 
            // grillaRecetas
            // 
            this.Load += new System.EventHandler(this.Principal_Load);
            this.grillaRecetas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaRecetas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CheckReceta});
            this.grillaRecetas.Location = new System.Drawing.Point(187, 169);
            this.grillaRecetas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grillaRecetas.Name = "grillaRecetas";
            this.grillaRecetas.RowHeadersWidth = 51;
            this.grillaRecetas.RowTemplate.Height = 24;
            this.grillaRecetas.Size = new System.Drawing.Size(283, 155);
            this.grillaRecetas.TabIndex = 3;
            // 
            // btn_salir
            // 
            this.btn_salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_salir.Location = new System.Drawing.Point(49, 367);
            this.btn_salir.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(91, 30);
            this.btn_salir.TabIndex = 5;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(487, 367);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 28);
            this.button1.TabIndex = 6;
            this.button1.Text = "Aceptar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CheckReceta
            // 
            this.CheckReceta.HeaderText = "Seleccionar";
            this.CheckReceta.Name = "CheckReceta";
            // 
            // RegistrarComidas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 426);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.grillaRecetas);
            this.Controls.Add(this.fechaComida);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "RegistrarComidas";
            this.Text = "RegistrarComidas";
            ((System.ComponentModel.ISupportInitialize)(this.grillaRecetas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker fechaComida;
        private System.Windows.Forms.DataGridView grillaRecetas;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn CheckReceta;
    }
}