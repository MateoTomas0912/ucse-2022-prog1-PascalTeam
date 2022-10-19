namespace PantallasWinForm
{
    partial class GrillaProductos
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.col_carne = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_pescado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_bebid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_fruta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_hort_verd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_lacteo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_panaderia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_queso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_volver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_carne,
            this.col_pescado,
            this.col_bebid,
            this.col_fruta,
            this.col_hort_verd,
            this.col_lacteo,
            this.col_panaderia,
            this.col_queso});
            this.dataGridView1.Location = new System.Drawing.Point(46, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1049, 427);
            this.dataGridView1.TabIndex = 0;
            // 
            // col_carne
            // 
            this.col_carne.HeaderText = "Carne";
            this.col_carne.MinimumWidth = 6;
            this.col_carne.Name = "col_carne";
            this.col_carne.Width = 125;
            // 
            // col_pescado
            // 
            this.col_pescado.HeaderText = "Pescado";
            this.col_pescado.MinimumWidth = 6;
            this.col_pescado.Name = "col_pescado";
            this.col_pescado.Width = 125;
            // 
            // col_bebid
            // 
            this.col_bebid.HeaderText = "Bebida";
            this.col_bebid.MinimumWidth = 6;
            this.col_bebid.Name = "col_bebid";
            this.col_bebid.Width = 125;
            // 
            // col_fruta
            // 
            this.col_fruta.HeaderText = "Fruta ";
            this.col_fruta.MinimumWidth = 6;
            this.col_fruta.Name = "col_fruta";
            this.col_fruta.Width = 125;
            // 
            // col_hort_verd
            // 
            this.col_hort_verd.HeaderText = "Hortaliza , verdura";
            this.col_hort_verd.MinimumWidth = 6;
            this.col_hort_verd.Name = "col_hort_verd";
            this.col_hort_verd.Width = 125;
            // 
            // col_lacteo
            // 
            this.col_lacteo.HeaderText = "Lacteo";
            this.col_lacteo.MinimumWidth = 6;
            this.col_lacteo.Name = "col_lacteo";
            this.col_lacteo.Width = 125;
            // 
            // col_panaderia
            // 
            this.col_panaderia.HeaderText = "Panaderia ";
            this.col_panaderia.MinimumWidth = 6;
            this.col_panaderia.Name = "col_panaderia";
            this.col_panaderia.Width = 125;
            // 
            // col_queso
            // 
            this.col_queso.HeaderText = "Queso ";
            this.col_queso.MinimumWidth = 6;
            this.col_queso.Name = "col_queso";
            this.col_queso.Width = 125;
            // 
            // btn_volver
            // 
            this.btn_volver.Location = new System.Drawing.Point(1014, 477);
            this.btn_volver.Name = "btn_volver";
            this.btn_volver.Size = new System.Drawing.Size(81, 37);
            this.btn_volver.TabIndex = 1;
            this.btn_volver.Text = "Volver ";
            this.btn_volver.UseVisualStyleBackColor = true;
            this.btn_volver.Click += new System.EventHandler(this.btn_volver_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1250, 671);
            this.Controls.Add(this.btn_volver);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form3";
            this.Text = "Comidas";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_carne;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_pescado;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_bebid;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_fruta;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_hort_verd;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_lacteo;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_panaderia;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_queso;
        private System.Windows.Forms.Button btn_volver;
    }
}