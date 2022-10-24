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
            this.grillaDespensa = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.grillaDespensa)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_cargaringrediente
            // 
            this.btn_cargaringrediente.Location = new System.Drawing.Point(0, 2);
            this.btn_cargaringrediente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_cargaringrediente.Name = "btn_cargaringrediente";
            this.btn_cargaringrediente.Size = new System.Drawing.Size(129, 32);
            this.btn_cargaringrediente.TabIndex = 0;
            this.btn_cargaringrediente.Text = "Cargar un ingrediente";
            this.btn_cargaringrediente.UseVisualStyleBackColor = true;
            this.btn_cargaringrediente.Click += new System.EventHandler(this.btn_cargaringrediente_Click);
            // 
            // btn_salir
            // 
            this.btn_salir.Location = new System.Drawing.Point(314, 248);
            this.btn_salir.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(122, 32);
            this.btn_salir.TabIndex = 1;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // grillaDespensa
            // 
            this.grillaDespensa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaDespensa.Location = new System.Drawing.Point(0, 39);
            this.grillaDespensa.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grillaDespensa.Name = "grillaDespensa";
            this.grillaDespensa.RowHeadersWidth = 51;
            this.grillaDespensa.RowTemplate.Height = 24;
            this.grillaDespensa.Size = new System.Drawing.Size(436, 204);
            this.grillaDespensa.TabIndex = 2;
            this.Load += new System.EventHandler(this.Principal_Load);
            // 
            // Despensa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 419);
            this.Controls.Add(this.grillaDespensa);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.btn_cargaringrediente);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Despensa";
            this.Text = "Despensa";
            ((System.ComponentModel.ISupportInitialize)(this.grillaDespensa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_cargaringrediente;
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.DataGridView grillaDespensa;


    }
}