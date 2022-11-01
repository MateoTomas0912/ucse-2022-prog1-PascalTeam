namespace PantallasWinForm
{
    partial class LoQueHeComido
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoQueHeComido));
            this.label1 = new System.Windows.Forms.Label();
            this.btn_salir = new System.Windows.Forms.Button();
            this.grillaComidas = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreReceta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RegistroDeComida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AgregarComida = new System.Windows.Forms.Button();
            this.dateTimeComidas = new System.Windows.Forms.DateTimePicker();
            this.button3 = new System.Windows.Forms.Button();
            this.buscarPorFecha = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grillaComidas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Font = new System.Drawing.Font("MV Boli", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(60, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tranqui";
            // 
            // btn_salir
            // 
            this.btn_salir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_salir.Location = new System.Drawing.Point(646, 280);
            this.btn_salir.Margin = new System.Windows.Forms.Padding(2);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(89, 38);
            this.btn_salir.TabIndex = 1;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = false;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // grillaComidas
            // 
            this.grillaComidas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaComidas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.NombreReceta,
            this.RegistroDeComida});
            this.grillaComidas.Location = new System.Drawing.Point(58, 94);
            this.grillaComidas.Margin = new System.Windows.Forms.Padding(2);
            this.grillaComidas.Name = "grillaComidas";
            this.grillaComidas.RowHeadersWidth = 51;
            this.grillaComidas.RowTemplate.Height = 24;
            this.grillaComidas.Size = new System.Drawing.Size(677, 161);
            this.grillaComidas.TabIndex = 2;
            // 
            // Codigo
            // 
            this.Codigo.DataPropertyName = "Codigo";
            this.Codigo.HeaderText = "Codigo Comida";
            this.Codigo.MinimumWidth = 6;
            this.Codigo.Name = "Codigo";
            this.Codigo.Width = 125;
            // 
            // NombreReceta
            // 
            this.NombreReceta.DataPropertyName = "NombreReceta";
            this.NombreReceta.HeaderText = "Receta";
            this.NombreReceta.MinimumWidth = 6;
            this.NombreReceta.Name = "NombreReceta";
            this.NombreReceta.Width = 125;
            // 
            // RegistroDeComida
            // 
            this.RegistroDeComida.DataPropertyName = "RegistroDeComida";
            this.RegistroDeComida.HeaderText = "Fecha";
            this.RegistroDeComida.MinimumWidth = 6;
            this.RegistroDeComida.Name = "RegistroDeComida";
            this.RegistroDeComida.Width = 125;
            // 
            // AgregarComida
            // 
            this.AgregarComida.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.AgregarComida.Location = new System.Drawing.Point(58, 280);
            this.AgregarComida.Name = "AgregarComida";
            this.AgregarComida.Size = new System.Drawing.Size(113, 37);
            this.AgregarComida.TabIndex = 3;
            this.AgregarComida.Text = "Agregar Comida";
            this.AgregarComida.UseVisualStyleBackColor = false;
            this.AgregarComida.Click += new System.EventHandler(this.AgregarComida_Click);
            // 
            // dateTimeComidas
            // 
            this.dateTimeComidas.Location = new System.Drawing.Point(234, 297);
            this.dateTimeComidas.Name = "dateTimeComidas";
            this.dateTimeComidas.Size = new System.Drawing.Size(200, 20);
            this.dateTimeComidas.TabIndex = 22;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button3.Location = new System.Drawing.Point(289, 323);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 21;
            this.button3.Text = "Quitar Filtro";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // buscarPorFecha
            // 
            this.buscarPorFecha.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buscarPorFecha.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buscarPorFecha.Location = new System.Drawing.Point(356, 266);
            this.buscarPorFecha.Name = "buscarPorFecha";
            this.buscarPorFecha.Size = new System.Drawing.Size(75, 23);
            this.buscarPorFecha.TabIndex = 20;
            this.buscarPorFecha.Text = "Buscar";
            this.buscarPorFecha.UseVisualStyleBackColor = false;
            this.buscarPorFecha.Click += new System.EventHandler(this.buscarPorFecha_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(231, 271);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Busque por fecha";
            // 
            // LoQueHeComido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(879, 458);
            this.Controls.Add(this.dateTimeComidas);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.buscarPorFecha);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.AgregarComida);
            this.Controls.Add(this.grillaComidas);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "LoQueHeComido";
            this.Text = "Comido";
            this.Load += new System.EventHandler(this.Principal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grillaComidas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.DataGridView grillaComidas;
        private System.Windows.Forms.Button AgregarComida;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreReceta;
        private System.Windows.Forms.DataGridViewTextBoxColumn RegistroDeComida;
        private System.Windows.Forms.DateTimePicker dateTimeComidas;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button buscarPorFecha;
        private System.Windows.Forms.Label label5;
    }
}