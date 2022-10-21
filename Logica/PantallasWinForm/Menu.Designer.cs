namespace PantallasWinForm
{
    partial class Menu
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnRecetas = new System.Windows.Forms.Button();
            this.btn_Supermercado = new System.Windows.Forms.Button();
            this.btnDespensa = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnComidas = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnRecetas
            // 
            this.BtnRecetas.Location = new System.Drawing.Point(181, 30);
            this.BtnRecetas.Margin = new System.Windows.Forms.Padding(4);
            this.BtnRecetas.Name = "BtnRecetas";
            this.BtnRecetas.Size = new System.Drawing.Size(140, 48);
            this.BtnRecetas.TabIndex = 1;
            this.BtnRecetas.Text = "Recetas";
            this.BtnRecetas.UseVisualStyleBackColor = true;
            this.BtnRecetas.Click += new System.EventHandler(this.BtnRecetas_Click);
            // 
            // btn_Supermercado
            // 
            this.btn_Supermercado.Location = new System.Drawing.Point(329, 31);
            this.btn_Supermercado.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Supermercado.Name = "btn_Supermercado";
            this.btn_Supermercado.Size = new System.Drawing.Size(140, 46);
            this.btn_Supermercado.TabIndex = 2;
            this.btn_Supermercado.Text = "Supermercado";
            this.btn_Supermercado.UseVisualStyleBackColor = true;
            this.btn_Supermercado.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnDespensa
            // 
            this.btnDespensa.Location = new System.Drawing.Point(477, 30);
            this.btnDespensa.Margin = new System.Windows.Forms.Padding(4);
            this.btnDespensa.Name = "btnDespensa";
            this.btnDespensa.Size = new System.Drawing.Size(139, 47);
            this.btnDespensa.TabIndex = 3;
            this.btnDespensa.Text = "Despensa";
            this.btnDespensa.UseVisualStyleBackColor = true;
            this.btnDespensa.Click += new System.EventHandler(this.btnDespensa_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(639, 28);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.Checked = true;
            this.archivoToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // btnComidas
            // 
            this.btnComidas.Location = new System.Drawing.Point(34, 30);
            this.btnComidas.Name = "btnComidas";
            this.btnComidas.Size = new System.Drawing.Size(140, 46);
            this.btnComidas.TabIndex = 5;
            this.btnComidas.Text = "Comidas";
            this.btnComidas.UseVisualStyleBackColor = true;
            this.btnComidas.Click += new System.EventHandler(this.btnComidas_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox1.Image = global::PantallasWinForm.Properties.Resources.istockphoto_1272631829_612x612__1_;
            this.pictureBox1.Location = new System.Drawing.Point(89, 85);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(473, 451);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 558);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnComidas);
            this.Controls.Add(this.btnDespensa);
            this.Controls.Add(this.btn_Supermercado);
            this.Controls.Add(this.BtnRecetas);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Menu";
            this.Text = "Inicio ";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnRecetas;
        private System.Windows.Forms.Button btn_Supermercado;
        private System.Windows.Forms.Button btnDespensa;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.Button btnComidas;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

