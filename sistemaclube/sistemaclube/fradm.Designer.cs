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
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bt_quad
            // 
            this.bt_quad.Location = new System.Drawing.Point(719, 12);
            this.bt_quad.Name = "bt_quad";
            this.bt_quad.Size = new System.Drawing.Size(121, 23);
            this.bt_quad.TabIndex = 0;
            this.bt_quad.Text = "cadastro de quadras ";
            this.bt_quad.UseVisualStyleBackColor = true;
            this.bt_quad.Click += new System.EventHandler(this.bt_quad_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(846, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(116, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "cadastro de usuario";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // fradm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::sistemaclube.Properties.Resources.clube_4;
            this.ClientSize = new System.Drawing.Size(1291, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.bt_quad);
            this.Name = "fradm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "Clube de tênis";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_quad;
        private System.Windows.Forms.Button button2;
    }
}