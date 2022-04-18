namespace LOGINCOMBF
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1_LOGIN = new System.Windows.Forms.TextBox();
            this.textBox2_SENHA = new System.Windows.Forms.TextBox();
            this.button1_logar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "LOGIN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "SENHA";
            // 
            // textBox1_LOGIN
            // 
            this.textBox1_LOGIN.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1_LOGIN.Location = new System.Drawing.Point(149, 70);
            this.textBox1_LOGIN.Name = "textBox1_LOGIN";
            this.textBox1_LOGIN.Size = new System.Drawing.Size(140, 31);
            this.textBox1_LOGIN.TabIndex = 2;
            // 
            // textBox2_SENHA
            // 
            this.textBox2_SENHA.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2_SENHA.Location = new System.Drawing.Point(149, 156);
            this.textBox2_SENHA.Name = "textBox2_SENHA";
            this.textBox2_SENHA.Size = new System.Drawing.Size(140, 31);
            this.textBox2_SENHA.TabIndex = 3;
            // 
            // button1_logar
            // 
            this.button1_logar.Location = new System.Drawing.Point(80, 215);
            this.button1_logar.Name = "button1_logar";
            this.button1_logar.Size = new System.Drawing.Size(186, 69);
            this.button1_logar.TabIndex = 4;
            this.button1_logar.Text = "LOGAR";
            this.button1_logar.UseVisualStyleBackColor = true;
            this.button1_logar.Click += new System.EventHandler(this.button1_logar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 327);
            this.Controls.Add(this.button1_logar);
            this.Controls.Add(this.textBox2_SENHA);
            this.Controls.Add(this.textBox1_LOGIN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1_LOGIN;
        private System.Windows.Forms.TextBox textBox2_SENHA;
        private System.Windows.Forms.Button button1_logar;
    }
}

