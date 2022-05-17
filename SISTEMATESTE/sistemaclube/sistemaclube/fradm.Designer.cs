namespace sistemaclube
{
    partial class fradm
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
            this.bt_quad = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bt_usuario = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bt_quad
            // 
            this.bt_quad.BackColor = System.Drawing.Color.White;
            this.bt_quad.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bt_quad.FlatAppearance.BorderSize = 0;
            this.bt_quad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_quad.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_quad.ForeColor = System.Drawing.Color.Black;
            this.bt_quad.Location = new System.Drawing.Point(201, 43);
            this.bt_quad.Name = "bt_quad";
            this.bt_quad.Size = new System.Drawing.Size(210, 51);
            this.bt_quad.TabIndex = 0;
            this.bt_quad.Text = "Cadastro de quadras ";
            this.bt_quad.UseVisualStyleBackColor = false;
            this.bt_quad.Click += new System.EventHandler(this.bt_quad_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(777, 475);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(216, 86);
            this.label3.TabIndex = 9;
            this.label3.Text = "TÊNIS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.ForestGreen;
            this.label2.Location = new System.Drawing.Point(656, 482);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 50);
            this.label2.TabIndex = 8;
            this.label2.Text = "DE";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(382, 475);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 86);
            this.label1.TabIndex = 7;
            this.label1.Text = "CLUBE";
            // 
            // bt_usuario
            // 
            this.bt_usuario.BackColor = System.Drawing.Color.White;
            this.bt_usuario.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bt_usuario.FlatAppearance.BorderSize = 0;
            this.bt_usuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_usuario.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_usuario.ForeColor = System.Drawing.Color.Black;
            this.bt_usuario.Location = new System.Drawing.Point(578, 43);
            this.bt_usuario.Name = "bt_usuario";
            this.bt_usuario.Size = new System.Drawing.Size(210, 51);
            this.bt_usuario.TabIndex = 1;
            this.bt_usuario.Text = "Cadastro de usuário";
            this.bt_usuario.UseVisualStyleBackColor = false;
            this.bt_usuario.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(954, 43);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(210, 51);
            this.button1.TabIndex = 10;
            this.button1.Text = "Relatórios";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // fradm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::sistemaclube.Properties.Resources.clube_4;
            this.ClientSize = new System.Drawing.Size(1291, 703);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_usuario);
            this.Controls.Add(this.bt_quad);
            this.Name = "fradm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "Clube de tênis";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_quad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bt_usuario;
        private System.Windows.Forms.Button button1;
    }
}