namespace PantallasWinForm
{
    partial class AgregarReceta
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.NombreReceta = new System.Windows.Forms.TextBox();
            this.checkSaludable = new System.Windows.Forms.CheckBox();
            this.btn_crearReceta = new System.Windows.Forms.Button();
            this.btn_volverInicio = new System.Windows.Forms.Button();
            this.grillaProductos = new System.Windows.Forms.DataGridView();
            this.AgregarProducto = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.listaMomento = new System.Windows.Forms.ListBox();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grillaProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.MaximumSize = new System.Drawing.Size(237, 289);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "RECETAS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 122);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.MaximumSize = new System.Drawing.Size(142, 174);
            this.label2.MinimumSize = new System.Drawing.Size(3, 3);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(2);
            this.label2.Size = new System.Drawing.Size(62, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F);
            this.label3.Location = new System.Drawing.Point(22, 173);
            this.label3.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Momento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft New Tai Lue", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(22, 228);
            this.label4.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 19);
            this.label4.TabIndex = 4;
            this.label4.Text = "Saludable?";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft New Tai Lue", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(22, 284);
            this.label5.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 19);
            this.label5.TabIndex = 6;
            this.label5.Text = "Ingredientes";
            // 
            // NombreReceta
            // 
            this.NombreReceta.Location = new System.Drawing.Point(154, 122);
            this.NombreReceta.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.NombreReceta.Multiline = true;
            this.NombreReceta.Name = "NombreReceta";
            this.NombreReceta.Size = new System.Drawing.Size(156, 26);
            this.NombreReceta.TabIndex = 10;
            // 
            // checkSaludable
            // 
            this.checkSaludable.AutoSize = true;
            this.checkSaludable.Location = new System.Drawing.Point(154, 224);
            this.checkSaludable.Name = "checkSaludable";
            this.checkSaludable.Size = new System.Drawing.Size(101, 23);
            this.checkSaludable.TabIndex = 11;
            this.checkSaludable.Text = "Tilda si lo es";
            this.checkSaludable.UseVisualStyleBackColor = true;
            // 
            // btn_crearReceta
            // 
            this.btn_crearReceta.Location = new System.Drawing.Point(42, 414);
            this.btn_crearReceta.Name = "btn_crearReceta";
            this.btn_crearReceta.Size = new System.Drawing.Size(161, 46);
            this.btn_crearReceta.TabIndex = 12;
            this.btn_crearReceta.Text = "Crear receta";
            this.btn_crearReceta.UseVisualStyleBackColor = true;
            this.btn_crearReceta.Click += new System.EventHandler(this.btn_crearReceta_Click);
            // 
            // btn_volverInicio
            // 
            this.btn_volverInicio.Location = new System.Drawing.Point(308, 414);
            this.btn_volverInicio.Name = "btn_volverInicio";
            this.btn_volverInicio.Size = new System.Drawing.Size(163, 47);
            this.btn_volverInicio.TabIndex = 13;
            this.btn_volverInicio.Text = "Volver";
            this.btn_volverInicio.UseVisualStyleBackColor = true;
            this.btn_volverInicio.Click += new System.EventHandler(this.btn_volverInicio_Click);
            // 
            // grillaProductos
            // 
            this.grillaProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AgregarProducto,
            this.cantidad});
            this.grillaProductos.Location = new System.Drawing.Point(154, 268);
            this.grillaProductos.Name = "grillaProductos";
            this.grillaProductos.RowHeadersWidth = 51;
            this.grillaProductos.RowTemplate.Height = 24;
            this.grillaProductos.Size = new System.Drawing.Size(327, 100);
            this.grillaProductos.TabIndex = 14;
            // 
            // AgregarProducto
            // 
            this.AgregarProducto.HeaderText = "Agregar Producto";
            this.AgregarProducto.Name = "AgregarProducto";
            // 
            // listaMomento
            // 
            this.listaMomento.FormattingEnabled = true;
            this.listaMomento.ItemHeight = 19;
            this.listaMomento.Items.AddRange(new object[] {
            "Desayuno",
            "Almuerzo",
            "Merienda",
            "Cena"});
            this.listaMomento.Location = new System.Drawing.Point(154, 173);
            this.listaMomento.Name = "listaMomento";
            this.listaMomento.Size = new System.Drawing.Size(156, 23);
            this.listaMomento.TabIndex = 15;
            this.listaMomento.SelectedIndexChanged += new System.EventHandler(this.listaMomento_SelectedIndexChanged);
            // 
            // cantidad
            // 
            this.cantidad.HeaderText = "Cantidad Producto";
            this.cantidad.Name = "cantidad";
            // 
            // AgregarReceta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 557);
            this.Controls.Add(this.listaMomento);
            this.Controls.Add(this.grillaProductos);
            this.Controls.Add(this.btn_volverInicio);
            this.Controls.Add(this.btn_crearReceta);
            this.Controls.Add(this.checkSaludable);
            this.Controls.Add(this.NombreReceta);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft New Tai Lue", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AgregarReceta";
            this.Text = "AgregarReceta";
            this.Load += new System.EventHandler(this.Principal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grillaProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox NombreReceta;
        private System.Windows.Forms.CheckBox checkSaludable;
        private System.Windows.Forms.Button btn_crearReceta;
        private System.Windows.Forms.Button btn_volverInicio;
        private System.Windows.Forms.DataGridView grillaProductos;
        private System.Windows.Forms.ListBox listaMomento;
        private System.Windows.Forms.DataGridViewCheckBoxColumn AgregarProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
    }
}