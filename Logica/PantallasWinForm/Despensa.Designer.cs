namespace PantallasWinForm
{
    partial class Despensa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Despensa));
            this.btn_cargaringrediente = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.Button();
            this.grillaDespensa = new System.Windows.Forms.DataGridView();
            this.Editar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grillaDespensa)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_cargaringrediente
            // 
            this.btn_cargaringrediente.Location = new System.Drawing.Point(0, 2);
            this.btn_cargaringrediente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_cargaringrediente.Name = "btn_cargaringrediente";
            this.btn_cargaringrediente.Size = new System.Drawing.Size(172, 39);
            this.btn_cargaringrediente.TabIndex = 0;
            this.btn_cargaringrediente.Text = "Cargar un ingrediente";
            this.btn_cargaringrediente.UseVisualStyleBackColor = true;
            this.btn_cargaringrediente.Click += new System.EventHandler(this.btn_cargaringrediente_Click);
            // 
            // btn_salir
            // 
            this.btn_salir.Location = new System.Drawing.Point(930, 352);
            this.btn_salir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(163, 39);
            this.btn_salir.TabIndex = 1;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // grillaDespensa
            // 
            this.grillaDespensa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaDespensa.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Editar,
            this.Eliminar});
            this.grillaDespensa.Location = new System.Drawing.Point(0, 65);
            this.grillaDespensa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grillaDespensa.Name = "grillaDespensa";
            this.grillaDespensa.RowHeadersWidth = 51;
            this.grillaDespensa.RowTemplate.Height = 24;
            this.grillaDespensa.Size = new System.Drawing.Size(1093, 251);
            this.grillaDespensa.TabIndex = 2;
            this.grillaDespensa.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grillaDespensa_CellClick);
            // 
            // Editar
            // 
            this.Editar.HeaderText = "Editar";
            this.Editar.MinimumWidth = 6;
            this.Editar.Name = "Editar";
            this.Editar.Width = 125;
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.MinimumWidth = 6;
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Width = 125;
            // 
            // Despensa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1352, 536);
            this.Controls.Add(this.grillaDespensa);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.btn_cargaringrediente);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Despensa";
            this.Text = "Despensa";
            this.Load += new System.EventHandler(this.Principal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grillaDespensa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_cargaringrediente;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.DataGridView grillaDespensa;
        private System.Windows.Forms.DataGridViewButtonColumn Editar;
        private System.Windows.Forms.DataGridViewButtonColumn Eliminar;
    }
}