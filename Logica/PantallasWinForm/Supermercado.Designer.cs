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
            this.label1 = new System.Windows.Forms.Label();
            this.grillaSupermercado = new System.Windows.Forms.DataGridView();
            this.btn_comprar = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grillaSupermercado)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
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
            this.grillaSupermercado.Location = new System.Drawing.Point(44, 80);
            this.grillaSupermercado.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grillaSupermercado.Name = "grillaSupermercado";
            this.grillaSupermercado.RowHeadersWidth = 51;
            this.grillaSupermercado.RowTemplate.Height = 24;
            this.grillaSupermercado.Size = new System.Drawing.Size(458, 167);
            this.grillaSupermercado.TabIndex = 1;
            // 
            // btn_comprar
            // 
            this.btn_comprar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_comprar.Location = new System.Drawing.Point(425, 266);
            this.btn_comprar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_comprar.Name = "btn_comprar";
            this.btn_comprar.Size = new System.Drawing.Size(76, 33);
            this.btn_comprar.TabIndex = 2;
            this.btn_comprar.Text = "Comprar";
            this.btn_comprar.UseVisualStyleBackColor = true;
            this.btn_comprar.Click += new System.EventHandler(this.btn_comprar_Click);
            // 
            // btn_salir
            // 
            this.btn_salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_salir.Location = new System.Drawing.Point(44, 266);
            this.btn_salir.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(77, 33);
            this.btn_salir.TabIndex = 3;
            this.btn_salir.Text = "Salir";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // Supermercado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.btn_comprar);
            this.Controls.Add(this.grillaSupermercado);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Supermercado";
            this.Text = "Supermercado";
            ((System.ComponentModel.ISupportInitialize)(this.grillaSupermercado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView grillaSupermercado;
        private System.Windows.Forms.Button btn_comprar;
        private System.Windows.Forms.Button btn_salir;
    }
}