namespace sistemaclube
{
    partial class relat
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
            this.voltar = new System.Windows.Forms.Button();
            this.ll_exel = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // voltar
            // 
            this.voltar.BackColor = System.Drawing.Color.Blue;
            this.voltar.FlatAppearance.BorderSize = 0;
            this.voltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.voltar.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.voltar.ForeColor = System.Drawing.Color.White;
            this.voltar.Location = new System.Drawing.Point(1281, 12);
            this.voltar.Name = "voltar";
            this.voltar.Size = new System.Drawing.Size(42, 23);
            this.voltar.TabIndex = 0;
            this.voltar.Text = "<";
            this.voltar.UseVisualStyleBackColor = false;
            // 
            // ll_exel
            // 
            this.ll_exel.AutoSize = true;
            this.ll_exel.BackColor = System.Drawing.Color.Transparent;
            this.ll_exel.Font = new System.Drawing.Font("Segoe UI Symbol", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ll_exel.LinkColor = System.Drawing.Color.White;
            this.ll_exel.Location = new System.Drawing.Point(1031, 15);
            this.ll_exel.Name = "ll_exel";
            this.ll_exel.Size = new System.Drawing.Size(146, 20);
            this.ll_exel.TabIndex = 1;
            this.ll_exel.TabStop = true;
            this.ll_exel.Text = "Relatorios no exel";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::sistemaclube.Properties.Resources.LOGO;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 106);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // relat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::sistemaclube.Properties.Resources.clube_4;
            this.ClientSize = new System.Drawing.Size(1335, 598);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ll_exel);
            this.Controls.Add(this.voltar);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "relat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "relatórios";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button voltar;
        private System.Windows.Forms.LinkLabel ll_exel;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}