namespace PantallasWinForm
{
    partial class MisRecetas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MisRecetas));
            this.grillaRecetas = new System.Windows.Forms.DataGridView();
            this.Editar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_salir = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.filtroBuscar = new System.Windows.Forms.Button();
            this.eliminarFiltro = new System.Windows.Forms.Button();
            this.btn_volver = new System.Windows.Forms.Button();
            this.listaMomentos = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.grillaRecetas)).BeginInit();
            this.SuspendLayout();
            // 
            // grillaRecetas
            // 
            this.grillaRecetas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaRecetas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Editar,
            this.Eliminar});
            this.grillaRecetas.Location = new System.Drawing.Point(68, 141);
            this.grillaRecetas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grillaRecetas.Name = "grillaRecetas";
            this.grillaRecetas.RowHeadersWidth = 51;
            this.grillaRecetas.RowTemplate.Height = 24;
            this.grillaRecetas.Size = new System.Drawing.Size(758, 157);
            this.grillaRecetas.TabIndex = 0;
            this.grillaRecetas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grillaRecetas_CellClick);
            this.grillaRecetas.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.grillaRecetas_DataBindingComplete);
            // 
            // Editar
            // 
            this.Editar.HeaderText = "Editar Receta";
            this.Editar.MinimumWidth = 6;
            this.Editar.Name = "Editar";
            this.Editar.Width = 125;
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "Eliminar Receta";
            this.Eliminar.MinimumWidth = 6;
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Width = 125;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(62, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(423, 46);
            this.label1.TabIndex = 1;
            this.label1.Text = "Recetas del chef Linguini";
            // 
            // btn_salir
            // 
            this.btn_salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_salir.Location = new System.Drawing.Point(753, 391);
            this.btn_salir.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(71, 33);
            this.btn_salir.TabIndex = 2;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 336);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Busque por momento";
            // 
            // filtroBuscar
            // 
            this.filtroBuscar.Location = new System.Drawing.Point(252, 336);
            this.filtroBuscar.Name = "filtroBuscar";
            this.filtroBuscar.Size = new System.Drawing.Size(75, 23);
            this.filtroBuscar.TabIndex = 5;
            this.filtroBuscar.Text = "Buscar";
            this.filtroBuscar.UseVisualStyleBackColor = true;
            this.filtroBuscar.Click += new System.EventHandler(this.filtroBuscar_Click);
            // 
            // eliminarFiltro
            // 
            this.eliminarFiltro.Location = new System.Drawing.Point(252, 379);
            this.eliminarFiltro.Name = "eliminarFiltro";
            this.eliminarFiltro.Size = new System.Drawing.Size(75, 23);
            this.eliminarFiltro.TabIndex = 6;
            this.eliminarFiltro.Text = "Quitar Filtro";
            this.eliminarFiltro.UseVisualStyleBackColor = true;
            this.eliminarFiltro.Click += new System.EventHandler(this.eliminarFiltro_Click);
            // 
            // btn_volver
            // 
            this.btn_volver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_volver.Location = new System.Drawing.Point(642, 391);
            this.btn_volver.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_volver.Name = "btn_volver";
            this.btn_volver.Size = new System.Drawing.Size(72, 33);
            this.btn_volver.TabIndex = 7;
            this.btn_volver.Text = "Volver";
            this.btn_volver.UseVisualStyleBackColor = true;
            this.btn_volver.Click += new System.EventHandler(this.btn_volver_Click);
            // 
            // listaMomentos
            // 
            this.listaMomentos.FormattingEnabled = true;
            this.listaMomentos.Items.AddRange(new object[] {
            "Desayuno",
            "Almuerzo",
            "Merienda",
            "Cena"});
            this.listaMomentos.Location = new System.Drawing.Point(68, 379);
            this.listaMomentos.Name = "listaMomentos";
            this.listaMomentos.Size = new System.Drawing.Size(121, 21);
            this.listaMomentos.TabIndex = 8;
            // 
            // MisRecetas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(833, 462);
            this.Controls.Add(this.listaMomentos);
            this.Controls.Add(this.btn_volver);
            this.Controls.Add(this.eliminarFiltro);
            this.Controls.Add(this.filtroBuscar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grillaRecetas);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MisRecetas";
            this.Text = "MisRecetas";
            this.Load += new System.EventHandler(this.Principal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grillaRecetas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grillaRecetas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.DataGridViewButtonColumn Editar;
        private System.Windows.Forms.DataGridViewButtonColumn Eliminar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button filtroBuscar;
        private System.Windows.Forms.Button eliminarFiltro;
        private System.Windows.Forms.Button btn_volver;
        private System.Windows.Forms.ComboBox listaMomentos;
    }
}