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
            this.btn_cargaringrediente = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_cargaringrediente
            // 
            this.btn_cargaringrediente.Location = new System.Drawing.Point(0, 2);
            this.btn_cargaringrediente.Name = "btn_cargaringrediente";
            this.btn_cargaringrediente.Size = new System.Drawing.Size(172, 40);
            this.btn_cargaringrediente.TabIndex = 0;
            this.btn_cargaringrediente.Text = "Cargar un ingrediente";
            this.btn_cargaringrediente.UseVisualStyleBackColor = true;
            this.btn_cargaringrediente.Click += new System.EventHandler(this.btn_cargaringrediente_Click);
            // 
            // btn_salir
            // 
            this.btn_salir.Location = new System.Drawing.Point(419, 305);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(162, 40);
            this.btn_salir.TabIndex = 1;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 48);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(581, 251);
            this.dataGridView1.TabIndex = 2;
            // 
            // Despensa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 516);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.btn_cargaringrediente);
            this.Name = "Despensa";
            this.Text = "Despensa";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_cargaringrediente;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}