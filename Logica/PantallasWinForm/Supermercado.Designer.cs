namespace PantallasWinForm
{
    partial class Supermercado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Supermercado));
            this.label1 = new System.Windows.Forms.Label();
            this.grillaSupermercado = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_comprar = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.Button();
            this.eliminarFiltro = new System.Windows.Forms.Button();
            this.filtroBuscar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.costoTotal = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.precioText = new System.Windows.Forms.TextBox();
            this.quitarPrecio = new System.Windows.Forms.Button();
            this.buscarPrecio = new System.Windows.Forms.Button();
            this.quitarCantidad = new System.Windows.Forms.Button();
            this.cantidadButton = new System.Windows.Forms.Button();
            this.cantidadText = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.listaIngredientes = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.grillaSupermercado)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label1.Font = new System.Drawing.Font("Tw Cen MT", 28.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(38, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "Carrefour";
            // 
            // grillaSupermercado
            // 
            this.grillaSupermercado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaSupermercado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Nombre,
            this.Precio});
            this.grillaSupermercado.Location = new System.Drawing.Point(44, 83);
            this.grillaSupermercado.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grillaSupermercado.Name = "grillaSupermercado";
            this.grillaSupermercado.RowHeadersWidth = 51;
            this.grillaSupermercado.RowTemplate.Height = 24;
            this.grillaSupermercado.Size = new System.Drawing.Size(499, 167);
            this.grillaSupermercado.TabIndex = 1;
            // 
            // Codigo
            // 
            this.Codigo.DataPropertyName = "Codigo";
            this.Codigo.HeaderText = "Codigo Producto";
            this.Codigo.MinimumWidth = 6;
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            this.Codigo.Width = 125;
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.HeaderText = "Nombre Producto";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 125;
            // 
            // Precio
            // 
            this.Precio.DataPropertyName = "Precio";
            this.Precio.HeaderText = "Precio";
            this.Precio.MinimumWidth = 6;
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            this.Precio.Width = 125;
            // 
            // btn_comprar
            // 
            this.btn_comprar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_comprar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_comprar.Location = new System.Drawing.Point(619, 40);
            this.btn_comprar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_comprar.Name = "btn_comprar";
            this.btn_comprar.Size = new System.Drawing.Size(76, 33);
            this.btn_comprar.TabIndex = 2;
            this.btn_comprar.Text = "Comprar";
            this.btn_comprar.UseVisualStyleBackColor = false;
            this.btn_comprar.Click += new System.EventHandler(this.btn_comprar_Click);
            // 
            // btn_salir
            // 
            this.btn_salir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_salir.Location = new System.Drawing.Point(910, 308);
            this.btn_salir.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(77, 33);
            this.btn_salir.TabIndex = 3;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = false;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // eliminarFiltro
            // 
            this.eliminarFiltro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.eliminarFiltro.Location = new System.Drawing.Point(199, 302);
            this.eliminarFiltro.Name = "eliminarFiltro";
            this.eliminarFiltro.Size = new System.Drawing.Size(75, 23);
            this.eliminarFiltro.TabIndex = 14;
            this.eliminarFiltro.Text = "Quitar Filtro";
            this.eliminarFiltro.UseVisualStyleBackColor = false;
            this.eliminarFiltro.Click += new System.EventHandler(this.eliminarFiltro_Click);
            // 
            // filtroBuscar
            // 
            this.filtroBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.filtroBuscar.Location = new System.Drawing.Point(199, 271);
            this.filtroBuscar.Name = "filtroBuscar";
            this.filtroBuscar.Size = new System.Drawing.Size(75, 23);
            this.filtroBuscar.TabIndex = 13;
            this.filtroBuscar.Text = "Buscar";
            this.filtroBuscar.UseVisualStyleBackColor = false;
            this.filtroBuscar.Click += new System.EventHandler(this.filtroBuscar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label3.Location = new System.Drawing.Point(41, 271);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Busque por ingrediente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(332, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "El costo de su compra es: ";
            // 
            // costoTotal
            // 
            this.costoTotal.AutoSize = true;
            this.costoTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.costoTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.costoTotal.Location = new System.Drawing.Point(557, 45);
            this.costoTotal.Name = "costoTotal";
            this.costoTotal.Size = new System.Drawing.Size(18, 20);
            this.costoTotal.TabIndex = 16;
            this.costoTotal.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label4.Location = new System.Drawing.Point(308, 271);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Busque por precio";
            // 
            // precioText
            // 
            this.precioText.Location = new System.Drawing.Point(311, 305);
            this.precioText.Name = "precioText";
            this.precioText.Size = new System.Drawing.Size(90, 20);
            this.precioText.TabIndex = 18;
            // 
            // quitarPrecio
            // 
            this.quitarPrecio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.quitarPrecio.Location = new System.Drawing.Point(416, 302);
            this.quitarPrecio.Name = "quitarPrecio";
            this.quitarPrecio.Size = new System.Drawing.Size(75, 23);
            this.quitarPrecio.TabIndex = 20;
            this.quitarPrecio.Text = "Quitar Filtro";
            this.quitarPrecio.UseVisualStyleBackColor = false;
            this.quitarPrecio.Click += new System.EventHandler(this.quitarPrecio_Click);
            // 
            // buscarPrecio
            // 
            this.buscarPrecio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buscarPrecio.Location = new System.Drawing.Point(416, 271);
            this.buscarPrecio.Name = "buscarPrecio";
            this.buscarPrecio.Size = new System.Drawing.Size(75, 23);
            this.buscarPrecio.TabIndex = 19;
            this.buscarPrecio.Text = "Buscar";
            this.buscarPrecio.UseVisualStyleBackColor = false;
            this.buscarPrecio.Click += new System.EventHandler(this.buscarPrecio_Click);
            // 
            // quitarCantidad
            // 
            this.quitarCantidad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.quitarCantidad.Location = new System.Drawing.Point(679, 303);
            this.quitarCantidad.Name = "quitarCantidad";
            this.quitarCantidad.Size = new System.Drawing.Size(75, 23);
            this.quitarCantidad.TabIndex = 24;
            this.quitarCantidad.Text = "Quitar Filtro";
            this.quitarCantidad.UseVisualStyleBackColor = false;
            this.quitarCantidad.Click += new System.EventHandler(this.button1_Click);
            // 
            // cantidadButton
            // 
            this.cantidadButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.cantidadButton.Location = new System.Drawing.Point(679, 271);
            this.cantidadButton.Name = "cantidadButton";
            this.cantidadButton.Size = new System.Drawing.Size(75, 23);
            this.cantidadButton.TabIndex = 23;
            this.cantidadButton.Text = "Buscar";
            this.cantidadButton.UseVisualStyleBackColor = false;
            this.cantidadButton.Click += new System.EventHandler(this.cantidadButton_Click);
            // 
            // cantidadText
            // 
            this.cantidadText.Location = new System.Drawing.Point(515, 305);
            this.cantidadText.Name = "cantidadText";
            this.cantidadText.Size = new System.Drawing.Size(90, 20);
            this.cantidadText.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label5.Location = new System.Drawing.Point(512, 271);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Busque por cantidad minima";
            // 
            // listaIngredientes
            // 
            this.listaIngredientes.FormattingEnabled = true;
            this.listaIngredientes.Items.AddRange(new object[] {
            "Hortalizas y verduras",
            "Bebidas",
            "Panaderia",
            "Carnes",
            "Pescados",
            "Quesos",
            "Lacteos",
            "Frutas"});
            this.listaIngredientes.Location = new System.Drawing.Point(44, 304);
            this.listaIngredientes.Name = "listaIngredientes";
            this.listaIngredientes.Size = new System.Drawing.Size(121, 21);
            this.listaIngredientes.TabIndex = 26;
            // 
            // Supermercado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(983, 366);
            this.Controls.Add(this.listaIngredientes);
            this.Controls.Add(this.quitarCantidad);
            this.Controls.Add(this.cantidadButton);
            this.Controls.Add(this.cantidadText);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.quitarPrecio);
            this.Controls.Add(this.buscarPrecio);
            this.Controls.Add(this.precioText);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.costoTotal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.eliminarFiltro);
            this.Controls.Add(this.filtroBuscar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.btn_comprar);
            this.Controls.Add(this.grillaSupermercado);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Supermercado";
            this.Text = "Supermercado";
            this.Load += new System.EventHandler(this.Principal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grillaSupermercado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView grillaSupermercado;
        private System.Windows.Forms.Button btn_comprar;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.Button eliminarFiltro;
        private System.Windows.Forms.Button filtroBuscar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label costoTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox precioText;
        private System.Windows.Forms.Button quitarPrecio;
        private System.Windows.Forms.Button buscarPrecio;
        private System.Windows.Forms.Button quitarCantidad;
        private System.Windows.Forms.Button cantidadButton;
        private System.Windows.Forms.TextBox cantidadText;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox listaIngredientes;
    }
}