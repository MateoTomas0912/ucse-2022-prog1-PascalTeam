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
            this.Editar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreReceta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RegistroDeComida = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AgregarComida = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grillaComidas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label1.Font = new System.Drawing.Font("MV Boli", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(80, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 52);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tranqui";
            // 
            // btn_salir
            // 
            this.btn_salir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_salir.Location = new System.Drawing.Point(861, 345);
            this.btn_salir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(119, 47);
            this.btn_salir.TabIndex = 1;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = false;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // grillaComidas
            // 
            this.grillaComidas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaComidas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Editar,
            this.Eliminar,
            this.Codigo,
            this.NombreReceta,
            this.RegistroDeComida});
            this.grillaComidas.Location = new System.Drawing.Point(77, 116);
            this.grillaComidas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grillaComidas.Name = "grillaComidas";
            this.grillaComidas.RowHeadersWidth = 51;
            this.grillaComidas.RowTemplate.Height = 24;
            this.grillaComidas.Size = new System.Drawing.Size(903, 198);
            this.grillaComidas.TabIndex = 2;
            this.grillaComidas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grillaComidas_CellClick);
            // 
            // Editar
            // 
            this.Editar.HeaderText = "Editar Comida";
            this.Editar.MinimumWidth = 6;
            this.Editar.Name = "Editar";
            this.Editar.Text = "Editar ";
            this.Editar.Width = 125;
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "Eliminar Comida";
            this.Eliminar.MinimumWidth = 6;
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Text = "Eliminar";
            this.Eliminar.Width = 125;
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
            this.AgregarComida.Location = new System.Drawing.Point(77, 345);
            this.AgregarComida.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AgregarComida.Name = "AgregarComida";
            this.AgregarComida.Size = new System.Drawing.Size(151, 46);
            this.AgregarComida.TabIndex = 3;
            this.AgregarComida.Text = "Agregar Comida";
            this.AgregarComida.UseVisualStyleBackColor = false;
            this.AgregarComida.Click += new System.EventHandler(this.AgregarComida_Click);
            // 
            // LoQueHeComido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1172, 564);
            this.Controls.Add(this.AgregarComida);
            this.Controls.Add(this.grillaComidas);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
        private System.Windows.Forms.DataGridViewButtonColumn Editar;
        private System.Windows.Forms.DataGridViewButtonColumn Eliminar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreReceta;
        private System.Windows.Forms.DataGridViewTextBoxColumn RegistroDeComida;
    }
}