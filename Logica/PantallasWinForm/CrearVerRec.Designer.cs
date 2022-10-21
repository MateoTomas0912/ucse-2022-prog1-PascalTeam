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
            this.btn_Verrecetas = new System.Windows.Forms.Button();
            this.btn_Aggreceta = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Verrecetas
            // 
            this.btn_Verrecetas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Verrecetas.Location = new System.Drawing.Point(190, 293);
            this.btn_Verrecetas.Name = "btn_Verrecetas";
            this.btn_Verrecetas.Size = new System.Drawing.Size(154, 43);
            this.btn_Verrecetas.TabIndex = 0;
            this.btn_Verrecetas.Text = "Ver mis recetas";
            this.btn_Verrecetas.UseVisualStyleBackColor = true;
            this.btn_Verrecetas.Click += new System.EventHandler(this.btn_Verrecetas_Click);
            // 
            // btn_Aggreceta
            // 
            this.btn_Aggreceta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Aggreceta.Location = new System.Drawing.Point(418, 295);
            this.btn_Aggreceta.Name = "btn_Aggreceta";
            this.btn_Aggreceta.Size = new System.Drawing.Size(158, 41);
            this.btn_Aggreceta.TabIndex = 1;
            this.btn_Aggreceta.Text = "Agregar una receta";
            this.btn_Aggreceta.UseVisualStyleBackColor = true;
            this.btn_Aggreceta.Click += new System.EventHandler(this.btn_Aggreceta_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(176, 87);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(400, 157);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // CrearVerRec
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_Aggreceta);
            this.Controls.Add(this.btn_Verrecetas);
            this.Name = "CrearVerRec";
            this.Text = "CrearVerRec";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Verrecetas;
        private System.Windows.Forms.Button btn_Aggreceta;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}