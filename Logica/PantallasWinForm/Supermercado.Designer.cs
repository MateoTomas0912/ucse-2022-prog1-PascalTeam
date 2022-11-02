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
            this.listaIngredientes = new System.Windows.Forms.ListBox();
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
            this.boxIngredientes = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.grillaSupermercado)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label1.Font = new System.Drawing.Font("Tw Cen MT", 28.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(51, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 54);
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
            this.grillaSupermercado.Location = new System.Drawing.Point(59, 102);
            this.grillaSupermercado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grillaSupermercado.Name = "grillaSupermercado";
            this.grillaSupermercado.RowHeadersWidth = 51;
            this.grillaSupermercado.RowTemplate.Height = 24;
            this.grillaSupermercado.Size = new System.Drawing.Size(665, 206);
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
            this.btn_comprar.Location = new System.Drawing.Point(825, 49);
            this.btn_comprar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_comprar.Name = "btn_comprar";
            this.btn_comprar.Size = new System.Drawing.Size(101, 41);
            this.btn_comprar.TabIndex = 2;
            this.btn_comprar.Text = "Comprar";
            this.btn_comprar.UseVisualStyleBackColor = false;
            this.btn_comprar.Click += new System.EventHandler(this.btn_comprar_Click);
            // 
            // btn_salir
            // 
            this.btn_salir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_salir.Location = new System.Drawing.Point(1213, 379);
            this.btn_salir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(103, 41);
            this.btn_salir.TabIndex = 3;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = false;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // eliminarFiltro
            // 
            this.eliminarFiltro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.eliminarFiltro.Location = new System.Drawing.Point(265, 372);
            this.eliminarFiltro.Margin = new System.Windows.Forms.Padding(4);
            this.eliminarFiltro.Name = "eliminarFiltro";
            this.eliminarFiltro.Size = new System.Drawing.Size(100, 28);
            this.eliminarFiltro.TabIndex = 14;
            this.eliminarFiltro.Text = "Quitar Filtro";
            this.eliminarFiltro.UseVisualStyleBackColor = false;
            this.eliminarFiltro.Click += new System.EventHandler(this.eliminarFiltro_Click);
            // 
            // filtroBuscar
            // 
            this.filtroBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.filtroBuscar.Location = new System.Drawing.Point(265, 334);
            this.filtroBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.filtroBuscar.Name = "filtroBuscar";
            this.filtroBuscar.Size = new System.Drawing.Size(100, 28);
            this.filtroBuscar.TabIndex = 13;
            this.filtroBuscar.Text = "Buscar";
            this.filtroBuscar.UseVisualStyleBackColor = false;
            this.filtroBuscar.Click += new System.EventHandler(this.filtroBuscar_Click);
            // 
            // listaIngredientes
            // 
            this.listaIngredientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.listaIngredientes.FormattingEnabled = true;
            this.listaIngredientes.ItemHeight = 16;
            this.listaIngredientes.Items.AddRange(new object[] {
            "Hortalizas y verduras ",
            "Frutas",
            "Quesos",
            "Lácteos",
            "Carnes",
            "Pescados",
            "Panadería",
            "Bebidas "});
            this.listaIngredientes.Location = new System.Drawing.Point(59, 379);
            this.listaIngredientes.Margin = new System.Windows.Forms.Padding(4);
            this.listaIngredientes.Name = "listaIngredientes";
            this.listaIngredientes.Size = new System.Drawing.Size(172, 20);
            this.listaIngredientes.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label3.Location = new System.Drawing.Point(55, 334);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Busque por ingrediente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(443, 55);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(241, 25);
            this.label2.TabIndex = 15;
            this.label2.Text = "El costo de su compra es: ";
            // 
            // costoTotal
            // 
            this.costoTotal.AutoSize = true;
            this.costoTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.costoTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.costoTotal.Location = new System.Drawing.Point(743, 55);
            this.costoTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.costoTotal.Name = "costoTotal";
            this.costoTotal.Size = new System.Drawing.Size(23, 25);
            this.costoTotal.TabIndex = 16;
            this.costoTotal.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label4.Location = new System.Drawing.Point(411, 334);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 16);
            this.label4.TabIndex = 17;
            this.label4.Text = "Busque por precio";
            // 
            // precioText
            // 
            this.precioText.Location = new System.Drawing.Point(415, 375);
            this.precioText.Margin = new System.Windows.Forms.Padding(4);
            this.precioText.Name = "precioText";
            this.precioText.Size = new System.Drawing.Size(119, 22);
            this.precioText.TabIndex = 18;
            // 
            // quitarPrecio
            // 
            this.quitarPrecio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.quitarPrecio.Location = new System.Drawing.Point(555, 372);
            this.quitarPrecio.Margin = new System.Windows.Forms.Padding(4);
            this.quitarPrecio.Name = "quitarPrecio";
            this.quitarPrecio.Size = new System.Drawing.Size(100, 28);
            this.quitarPrecio.TabIndex = 20;
            this.quitarPrecio.Text = "Quitar Filtro";
            this.quitarPrecio.UseVisualStyleBackColor = false;
            this.quitarPrecio.Click += new System.EventHandler(this.quitarPrecio_Click);
            // 
            // buscarPrecio
            // 
            this.buscarPrecio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.buscarPrecio.Location = new System.Drawing.Point(555, 334);
            this.buscarPrecio.Margin = new System.Windows.Forms.Padding(4);
            this.buscarPrecio.Name = "buscarPrecio";
            this.buscarPrecio.Size = new System.Drawing.Size(100, 28);
            this.buscarPrecio.TabIndex = 19;
            this.buscarPrecio.Text = "Buscar";
            this.buscarPrecio.UseVisualStyleBackColor = false;
            this.buscarPrecio.Click += new System.EventHandler(this.buscarPrecio_Click);
            // 
            // quitarCantidad
            // 
            this.quitarCantidad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.quitarCantidad.Location = new System.Drawing.Point(905, 373);
            this.quitarCantidad.Margin = new System.Windows.Forms.Padding(4);
            this.quitarCantidad.Name = "quitarCantidad";
            this.quitarCantidad.Size = new System.Drawing.Size(100, 28);
            this.quitarCantidad.TabIndex = 24;
            this.quitarCantidad.Text = "Quitar Filtro";
            this.quitarCantidad.UseVisualStyleBackColor = false;
            this.quitarCantidad.Click += new System.EventHandler(this.button1_Click);
            // 
            // cantidadButton
            // 
            this.cantidadButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.cantidadButton.Location = new System.Drawing.Point(905, 334);
            this.cantidadButton.Margin = new System.Windows.Forms.Padding(4);
            this.cantidadButton.Name = "cantidadButton";
            this.cantidadButton.Size = new System.Drawing.Size(100, 28);
            this.cantidadButton.TabIndex = 23;
            this.cantidadButton.Text = "Buscar";
            this.cantidadButton.UseVisualStyleBackColor = false;
            this.cantidadButton.Click += new System.EventHandler(this.cantidadButton_Click);
            // 
            // cantidadText
            // 
            this.cantidadText.Location = new System.Drawing.Point(687, 375);
            this.cantidadText.Margin = new System.Windows.Forms.Padding(4);
            this.cantidadText.Name = "cantidadText";
            this.cantidadText.Size = new System.Drawing.Size(119, 22);
            this.cantidadText.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label5.Location = new System.Drawing.Point(683, 334);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(177, 16);
            this.label5.TabIndex = 21;
            this.label5.Text = "Busque por cantidad minima";
            // 
            // boxIngredientes
            // 
            this.boxIngredientes.FormattingEnabled = true;
            this.boxIngredientes.Items.AddRange(new object[] {
            "Hortalizas y verduras ",
            "Frutas",
            "Quesos",
            "Lácteos",
            "Carnes",
            "Pescados",
            "Panadería",
            "Bebidas "});
            this.boxIngredientes.Location = new System.Drawing.Point(60, 414);
            this.boxIngredientes.Name = "boxIngredientes";
            this.boxIngredientes.Size = new System.Drawing.Size(171, 24);
            this.boxIngredientes.TabIndex = 25;
            // 
            // Supermercado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1311, 450);
            this.Controls.Add(this.boxIngredientes);
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
            this.Controls.Add(this.listaIngredientes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.btn_comprar);
            this.Controls.Add(this.grillaSupermercado);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
        private System.Windows.Forms.ListBox listaIngredientes;
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
        private System.Windows.Forms.ComboBox boxIngredientes;
    }
}