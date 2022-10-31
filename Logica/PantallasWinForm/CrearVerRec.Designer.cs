namespace PantallasWinForm
{
    partial class CrearVerRec
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CrearVerRec));
            this.btn_Verrecetas = new System.Windows.Forms.Button();
            this.btn_Aggreceta = new System.Windows.Forms.Button();
            this.btn_volver = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Verrecetas
            // 
            this.btn_Verrecetas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Verrecetas.Location = new System.Drawing.Point(297, 203);
            this.btn_Verrecetas.Name = "btn_Verrecetas";
            this.btn_Verrecetas.Size = new System.Drawing.Size(177, 43);
            this.btn_Verrecetas.TabIndex = 0;
            this.btn_Verrecetas.Text = "Ver mis recetas";
            this.btn_Verrecetas.UseVisualStyleBackColor = true;
            this.btn_Verrecetas.Click += new System.EventHandler(this.btn_Verrecetas_Click);
            // 
            // btn_Aggreceta
            // 
            this.btn_Aggreceta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Aggreceta.Location = new System.Drawing.Point(297, 117);
            this.btn_Aggreceta.Name = "btn_Aggreceta";
            this.btn_Aggreceta.Size = new System.Drawing.Size(177, 41);
            this.btn_Aggreceta.TabIndex = 1;
            this.btn_Aggreceta.Text = "Agregar una receta";
            this.btn_Aggreceta.UseVisualStyleBackColor = true;
            this.btn_Aggreceta.Click += new System.EventHandler(this.btn_Aggreceta_Click);
            // 
            // btn_volver
            // 
            this.btn_volver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_volver.Location = new System.Drawing.Point(297, 292);
            this.btn_volver.Name = "btn_volver";
            this.btn_volver.Size = new System.Drawing.Size(177, 44);
            this.btn_volver.TabIndex = 2;
            this.btn_volver.Text = "Volver";
            this.btn_volver.UseVisualStyleBackColor = true;
            this.btn_volver.Click += new System.EventHandler(this.btn_volver_Click);
            // 
            // CrearVerRec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(829, 450);
            this.Controls.Add(this.btn_volver);
            this.Controls.Add(this.btn_Aggreceta);
            this.Controls.Add(this.btn_Verrecetas);
            this.Name = "CrearVerRec";
            this.Text = "CrearVerRec";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Verrecetas;
        private System.Windows.Forms.Button btn_Aggreceta;
        private System.Windows.Forms.Button btn_volver;
    }
}