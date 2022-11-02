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
            this.ComidasTime = new System.Windows.Forms.DateTimePicker();
            this.button3 = new System.Windows.Forms.Button();
            this.buscarPorFecha = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_quitalfiltro = new System.Windows.Forms.Button();
            this.buscarSaludable = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.quitarCodigo = new System.Windows.Forms.Button();
            this.buscarCodigo = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.boxLetras = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.nombreRecetaFiltrar = new System.Windows.Forms.TextBox();
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
            this.btn_salir.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.grillaComidas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            // ComidasTime
            // 
            this.ComidasTime.Location = new System.Drawing.Point(378, 392);
            this.ComidasTime.Name = "ComidasTime";
            this.ComidasTime.Size = new System.Drawing.Size(200, 20);
            this.ComidasTime.TabIndex = 22;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button3.Location = new System.Drawing.Point(603, 389);
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
            this.buscarPorFecha.Location = new System.Drawing.Point(603, 360);
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
            this.label5.Location = new System.Drawing.Point(375, 366);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Busque por fecha";
            // 
            // btn_quitalfiltro
            // 
            this.btn_quitalfiltro.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_quitalfiltro.Location = new System.Drawing.Point(210, 394);
            this.btn_quitalfiltro.Name = "btn_quitalfiltro";
            this.btn_quitalfiltro.Size = new System.Drawing.Size(75, 23);
            this.btn_quitalfiltro.TabIndex = 29;
            this.btn_quitalfiltro.Text = "Quitar Filtro";
            this.btn_quitalfiltro.UseVisualStyleBackColor = false;
            this.btn_quitalfiltro.Click += new System.EventHandler(this.btn_quitalfiltro_Click);
            // 
            // buscarSaludable
            // 
            this.buscarSaludable.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buscarSaludable.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buscarSaludable.Location = new System.Drawing.Point(210, 365);
            this.buscarSaludable.Name = "buscarSaludable";
            this.buscarSaludable.Size = new System.Drawing.Size(75, 23);
            this.buscarSaludable.TabIndex = 28;
            this.buscarSaludable.Text = "Buscar";
            this.buscarSaludable.UseVisualStyleBackColor = false;
            this.buscarSaludable.Click += new System.EventHandler(this.buscarSaludable_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(58, 370);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Busque si es saludable";
            // 
            // quitarCodigo
            // 
            this.quitarCodigo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.quitarCodigo.Location = new System.Drawing.Point(406, 42);
            this.quitarCodigo.Name = "quitarCodigo";
            this.quitarCodigo.Size = new System.Drawing.Size(75, 23);
            this.quitarCodigo.TabIndex = 32;
            this.quitarCodigo.Text = "Quitar Filtro";
            this.quitarCodigo.UseVisualStyleBackColor = false;
            this.quitarCodigo.Click += new System.EventHandler(this.quitarCodigo_Click);
            // 
            // buscarCodigo
            // 
            this.buscarCodigo.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.buscarCodigo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buscarCodigo.Location = new System.Drawing.Point(406, 8);
            this.buscarCodigo.Name = "buscarCodigo";
            this.buscarCodigo.Size = new System.Drawing.Size(75, 23);
            this.buscarCodigo.TabIndex = 31;
            this.buscarCodigo.Text = "Buscar";
            this.buscarCodigo.UseVisualStyleBackColor = false;
            this.buscarCodigo.Click += new System.EventHandler(this.buscarCodigo_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(248, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 30;
            this.label2.Text = "Busque por codigo";
            // 
            // boxLetras
            // 
            this.boxLetras.FormattingEnabled = true;
            this.boxLetras.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E",
            "F",
            "G",
            "H",
            "I",
            "J",
            "K",
            "L",
            "M",
            "N",
            "Ñ",
            "O",
            "P",
            "Q",
            "R",
            "S",
            "T",
            "U",
            "V",
            "W",
            "X",
            "Y",
            "Z",
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.boxLetras.Location = new System.Drawing.Point(251, 42);
            this.boxLetras.Name = "boxLetras";
            this.boxLetras.Size = new System.Drawing.Size(121, 21);
            this.boxLetras.TabIndex = 33;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Location = new System.Drawing.Point(681, 42);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 36;
            this.button1.Text = "Quitar Filtro";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button2.Location = new System.Drawing.Point(681, 8);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 35;
            this.button2.Text = "Buscar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(523, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 13);
            this.label3.TabIndex = 34;
            this.label3.Text = "Busque por nombre receta";
            // 
            // nombreRecetaFiltrar
            // 
            this.nombreRecetaFiltrar.Location = new System.Drawing.Point(526, 43);
            this.nombreRecetaFiltrar.Name = "nombreRecetaFiltrar";
            this.nombreRecetaFiltrar.Size = new System.Drawing.Size(129, 20);
            this.nombreRecetaFiltrar.TabIndex = 37;
            // 
            // LoQueHeComido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(879, 458);
            this.Controls.Add(this.nombreRecetaFiltrar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.boxLetras);
            this.Controls.Add(this.quitarCodigo);
            this.Controls.Add(this.buscarCodigo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_quitalfiltro);
            this.Controls.Add(this.buscarSaludable);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ComidasTime);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.buscarPorFecha);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.AgregarComida);
            this.Controls.Add(this.grillaComidas);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
        private System.Windows.Forms.DateTimePicker ComidasTime;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button buscarPorFecha;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_quitalfiltro;
        private System.Windows.Forms.Button buscarSaludable;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button quitarCodigo;
        private System.Windows.Forms.Button buscarCodigo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox boxLetras;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nombreRecetaFiltrar;
    }
}