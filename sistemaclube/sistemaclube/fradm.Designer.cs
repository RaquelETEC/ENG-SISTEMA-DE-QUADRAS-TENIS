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
            this.bt_usuario = new System.Windows.Forms.Button();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // bt_quad
            // 
            this.bt_quad.BackColor = System.Drawing.Color.Transparent;
            this.bt_quad.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bt_quad.FlatAppearance.BorderSize = 0;
            this.bt_quad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_quad.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_quad.ForeColor = System.Drawing.Color.White;
            this.bt_quad.Location = new System.Drawing.Point(769, 12);
            this.bt_quad.Name = "bt_quad";
            this.bt_quad.Size = new System.Drawing.Size(165, 37);
            this.bt_quad.TabIndex = 0;
            this.bt_quad.Text = "Cadastro de quadras ";
            this.bt_quad.UseVisualStyleBackColor = false;
            this.bt_quad.Click += new System.EventHandler(this.bt_quad_Click);
            // 
            // bt_usuario
            // 
            this.bt_usuario.BackColor = System.Drawing.Color.Transparent;
            this.bt_usuario.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.bt_usuario.FlatAppearance.BorderSize = 0;
            this.bt_usuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_usuario.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_usuario.ForeColor = System.Drawing.Color.White;
            this.bt_usuario.Location = new System.Drawing.Point(954, 12);
            this.bt_usuario.Name = "bt_usuario";
            this.bt_usuario.Size = new System.Drawing.Size(165, 37);
            this.bt_usuario.TabIndex = 1;
            this.bt_usuario.Text = "Cadastro de usuário";
            this.bt_usuario.UseVisualStyleBackColor = false;
            this.bt_usuario.Click += new System.EventHandler(this.button2_Click);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(12, 60);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(1267, 631);
            this.webBrowser1.TabIndex = 10;
            this.webBrowser1.Url = new System.Uri("https://www.google.com.br/", System.UriKind.Absolute);
            // 
            // fradm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(1291, 703);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.bt_usuario);
            this.Controls.Add(this.bt_quad);
            this.Name = "fradm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "Clube de tênis";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_quad;
        private System.Windows.Forms.Button bt_usuario;
        private System.Windows.Forms.WebBrowser webBrowser1;
    }
}