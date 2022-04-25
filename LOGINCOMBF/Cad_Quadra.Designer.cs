namespace LOGINCOMBF
{
    partial class Cad_Quadra
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
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Nome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_coberta = new System.Windows.Forms.ListBox();
            this.dgvDados = new System.Windows.Forms.ListView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_preco = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.BTN_CAD = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Coberta";
            // 
            // txt_Nome
            // 
            this.txt_Nome.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_Nome.Location = new System.Drawing.Point(12, 37);
            this.txt_Nome.Name = "txt_Nome";
            this.txt_Nome.Size = new System.Drawing.Size(203, 20);
            this.txt_Nome.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Nome Quadra";
            // 
            // txt_coberta
            // 
            this.txt_coberta.FormattingEnabled = true;
            this.txt_coberta.Items.AddRange(new object[] {
            "S",
            "N"});
            this.txt_coberta.Location = new System.Drawing.Point(15, 83);
            this.txt_coberta.Name = "txt_coberta";
            this.txt_coberta.Size = new System.Drawing.Size(18, 30);
            this.txt_coberta.TabIndex = 27;
            // 
            // dgvDados
            // 
            this.dgvDados.HideSelection = false;
            this.dgvDados.Location = new System.Drawing.Point(8, 200);
            this.dgvDados.Name = "dgvDados";
            this.dgvDados.OwnerDraw = true;
            this.dgvDados.Size = new System.Drawing.Size(939, 291);
            this.dgvDados.TabIndex = 31;
            this.dgvDados.TabStop = false;
            this.dgvDados.UseCompatibleStateImageBehavior = false;
            this.dgvDados.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(8, 174);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(203, 20);
            this.textBox1.TabIndex = 30;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(245, 171);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 29;
            this.button1.Text = "Pesquisar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Nome";
            // 
            // txt_preco
            // 
            this.txt_preco.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_preco.Location = new System.Drawing.Point(299, 37);
            this.txt_preco.Name = "txt_preco";
            this.txt_preco.Size = new System.Drawing.Size(203, 20);
            this.txt_preco.TabIndex = 33;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(296, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 32;
            this.label4.Text = "Preço";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(831, 116);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(116, 42);
            this.button4.TabIndex = 36;
            this.button4.Text = "Excluir";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(831, 65);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(116, 42);
            this.button3.TabIndex = 35;
            this.button3.Text = "Alterar";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // BTN_CAD
            // 
            this.BTN_CAD.Location = new System.Drawing.Point(831, 12);
            this.BTN_CAD.Name = "BTN_CAD";
            this.BTN_CAD.Size = new System.Drawing.Size(116, 42);
            this.BTN_CAD.TabIndex = 34;
            this.BTN_CAD.Text = "Cadastrar";
            this.BTN_CAD.UseVisualStyleBackColor = true;
            this.BTN_CAD.Click += new System.EventHandler(this.BTN_CAD_Click);
            // 
            // textBox2
            // 
            this.textBox2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBox2.Location = new System.Drawing.Point(299, 93);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(203, 20);
            this.textBox2.TabIndex = 37;
            this.textBox2.Visible = false;
            // 
            // Cad_Quadra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 503);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.BTN_CAD);
            this.Controls.Add(this.txt_preco);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvDados);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_coberta);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_Nome);
            this.Controls.Add(this.label1);
            this.Name = "Cad_Quadra";
            this.Text = "Cad_Quadra";
            this.Load += new System.EventHandler(this.Cad_Quadra_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Nome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox txt_coberta;
        private System.Windows.Forms.ListView dgvDados;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_preco;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button BTN_CAD;
        private System.Windows.Forms.TextBox textBox2;
    }
}