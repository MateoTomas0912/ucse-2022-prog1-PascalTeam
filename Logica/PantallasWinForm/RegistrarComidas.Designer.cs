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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrarComidas));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.fechaComida = new System.Windows.Forms.DateTimePicker();
            this.grillaRecetas = new System.Windows.Forms.DataGridView();
            this.CheckReceta = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_salir = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.listaMomentos = new System.Windows.Forms.ComboBox();
            this.eliminarFiltro = new System.Windows.Forms.Button();
            this.filtroBuscar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grillaRecetas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(39, 112);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Selecciona la receta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label2.Location = new System.Drawing.Point(39, 52);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Selecciona la fecha";
            // 
            // fechaComida
            // 
            this.fechaComida.Location = new System.Drawing.Point(184, 48);
            this.fechaComida.Margin = new System.Windows.Forms.Padding(2);
            this.fechaComida.Name = "fechaComida";
            this.fechaComida.Size = new System.Drawing.Size(204, 20);
            this.fechaComida.TabIndex = 2;
            // 
            // grillaRecetas
            // 
            this.grillaRecetas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaRecetas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CheckReceta,
            this.Codigo,
            this.Nombre});
            this.grillaRecetas.Location = new System.Drawing.Point(159, 103);
            this.grillaRecetas.Margin = new System.Windows.Forms.Padding(2);
            this.grillaRecetas.MultiSelect = false;
            this.grillaRecetas.Name = "grillaRecetas";
            this.grillaRecetas.RowHeadersWidth = 51;
            this.grillaRecetas.RowTemplate.Height = 24;
            this.grillaRecetas.Size = new System.Drawing.Size(482, 155);
            this.grillaRecetas.TabIndex = 3;
            // 
            // CheckReceta
            // 
            this.CheckReceta.HeaderText = "Seleccionar";
            this.CheckReceta.MinimumWidth = 6;
            this.CheckReceta.Name = "CheckReceta";
            this.CheckReceta.Width = 125;
            // 
            // Codigo
            // 
            this.Codigo.DataPropertyName = "Codigo";
            this.Codigo.HeaderText = "Codigo Receta";
            this.Codigo.MinimumWidth = 6;
            this.Codigo.Name = "Codigo";
            this.Codigo.Width = 125;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.HeaderText = "Nombre Receta";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.Width = 125;
            // 
            // btn_salir
            // 
            this.btn_salir.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_salir.Location = new System.Drawing.Point(49, 367);
            this.btn_salir.Margin = new System.Windows.Forms.Padding(2);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(91, 30);
            this.btn_salir.TabIndex = 5;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = false;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(461, 369);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 28);
            this.button1.TabIndex = 6;
            this.button1.Text = "Aceptar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listaMomentos
            // 
            this.listaMomentos.FormattingEnabled = true;
            this.listaMomentos.Items.AddRange(new object[] {
            "Desayuno",
            "Almuerzo",
            "Merienda",
            "Cena"});
            this.listaMomentos.Location = new System.Drawing.Point(43, 309);
            this.listaMomentos.Name = "listaMomentos";
            this.listaMomentos.Size = new System.Drawing.Size(136, 21);
            this.listaMomentos.TabIndex = 30;
            // 
            // eliminarFiltro
            // 
            this.eliminarFiltro.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.eliminarFiltro.Location = new System.Drawing.Point(198, 307);
            this.eliminarFiltro.Name = "eliminarFiltro";
            this.eliminarFiltro.Size = new System.Drawing.Size(75, 23);
            this.eliminarFiltro.TabIndex = 29;
            this.eliminarFiltro.Text = "Quitar Filtro";
            this.eliminarFiltro.UseVisualStyleBackColor = false;
            // 
            // filtroBuscar
            // 
            this.filtroBuscar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.filtroBuscar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.filtroBuscar.Location = new System.Drawing.Point(198, 278);
            this.filtroBuscar.Name = "filtroBuscar";
            this.filtroBuscar.Size = new System.Drawing.Size(75, 23);
            this.filtroBuscar.TabIndex = 28;
            this.filtroBuscar.Text = "Buscar";
            this.filtroBuscar.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(46, 283);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "Busque por tipo de comida";
            // 
            // RegistrarComidas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(932, 426);
            this.Controls.Add(this.listaMomentos);
            this.Controls.Add(this.eliminarFiltro);
            this.Controls.Add(this.filtroBuscar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.grillaRecetas);
            this.Controls.Add(this.fechaComida);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "RegistrarComidas";
            this.Text = "RegistrarComidas";
            this.Load += new System.EventHandler(this.Principal_Load);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.ComboBox listaMomentos;
        private System.Windows.Forms.Button eliminarFiltro;
        private System.Windows.Forms.Button filtroBuscar;
        private System.Windows.Forms.Label label3;
    }
}