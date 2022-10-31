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
            this.btn_comprar = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.Button();
            this.eliminarFiltro = new System.Windows.Forms.Button();
            this.filtroBuscar = new System.Windows.Forms.Button();
            this.listaIngredientes = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.costoTotal = new System.Windows.Forms.Label();
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
            this.grillaSupermercado.Location = new System.Drawing.Point(59, 102);
            this.grillaSupermercado.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grillaSupermercado.Name = "grillaSupermercado";
            this.grillaSupermercado.RowHeadersWidth = 51;
            this.grillaSupermercado.RowTemplate.Height = 24;
            this.grillaSupermercado.Size = new System.Drawing.Size(665, 206);
            this.grillaSupermercado.TabIndex = 1;
            // 
            // btn_comprar
            // 
            this.btn_comprar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btn_comprar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_comprar.Location = new System.Drawing.Point(623, 364);
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
            this.btn_salir.Location = new System.Drawing.Point(59, 364);
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
            this.eliminarFiltro.Location = new System.Drawing.Point(623, 68);
            this.eliminarFiltro.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.filtroBuscar.Location = new System.Drawing.Point(623, 26);
            this.filtroBuscar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.listaIngredientes.Location = new System.Drawing.Point(371, 75);
            this.listaIngredientes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listaIngredientes.Name = "listaIngredientes";
            this.listaIngredientes.Size = new System.Drawing.Size(172, 20);
            this.listaIngredientes.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label3.Location = new System.Drawing.Point(367, 32);
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
            this.label2.Location = new System.Drawing.Point(365, 325);
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
            this.costoTotal.Location = new System.Drawing.Point(633, 325);
            this.costoTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.costoTotal.Name = "costoTotal";
            this.costoTotal.Size = new System.Drawing.Size(23, 25);
            this.costoTotal.TabIndex = 16;
            this.costoTotal.Text = "0";
            // 
            // Supermercado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(943, 450);
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
    }
}