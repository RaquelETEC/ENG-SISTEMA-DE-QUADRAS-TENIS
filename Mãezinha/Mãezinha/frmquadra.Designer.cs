namespace Mãezinha
{
    partial class frmquadra
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label n__de_quadraLabel;
            System.Windows.Forms.Label quadraLabel;
            System.Windows.Forms.Label tipoLabel;
            System.Windows.Forms.Label valorLabel;
            System.Windows.Forms.Label dataLabel;
            this.cadastroDataSet = new Mãezinha.cadastroDataSet();
            this.cadastroquadraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cadastroquadraTableAdapter = new Mãezinha.cadastroDataSetTableAdapters.CadastroquadraTableAdapter();
            this.tableAdapterManager = new Mãezinha.cadastroDataSetTableAdapters.TableAdapterManager();
            this.n__de_quadraTextBox = new System.Windows.Forms.TextBox();
            this.quadraTextBox = new System.Windows.Forms.TextBox();
            this.tipoTextBox = new System.Windows.Forms.TextBox();
            this.valorTextBox = new System.Windows.Forms.TextBox();
            this.dataDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.cadastroquadraDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btinserir = new System.Windows.Forms.Button();
            this.btsalvar = new System.Windows.Forms.Button();
            this.btcancelar = new System.Windows.Forms.Button();
            this.btexcluir = new System.Windows.Forms.Button();
            this.btsair2 = new System.Windows.Forms.Button();
            n__de_quadraLabel = new System.Windows.Forms.Label();
            quadraLabel = new System.Windows.Forms.Label();
            tipoLabel = new System.Windows.Forms.Label();
            valorLabel = new System.Windows.Forms.Label();
            dataLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cadastroDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadastroquadraBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadastroquadraDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // n__de_quadraLabel
            // 
            n__de_quadraLabel.AutoSize = true;
            n__de_quadraLabel.BackColor = System.Drawing.Color.Transparent;
            n__de_quadraLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            n__de_quadraLabel.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            n__de_quadraLabel.ForeColor = System.Drawing.Color.White;
            n__de_quadraLabel.Location = new System.Drawing.Point(30, 45);
            n__de_quadraLabel.Name = "n__de_quadraLabel";
            n__de_quadraLabel.Size = new System.Drawing.Size(93, 15);
            n__de_quadraLabel.TabIndex = 3;
            n__de_quadraLabel.Text = "N° de quadra:";
            n__de_quadraLabel.Click += new System.EventHandler(this.n__de_quadraLabel_Click);
            // 
            // quadraLabel
            // 
            quadraLabel.AutoSize = true;
            quadraLabel.BackColor = System.Drawing.Color.Transparent;
            quadraLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            quadraLabel.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            quadraLabel.ForeColor = System.Drawing.Color.White;
            quadraLabel.Location = new System.Drawing.Point(30, 82);
            quadraLabel.Name = "quadraLabel";
            quadraLabel.Size = new System.Drawing.Size(56, 15);
            quadraLabel.TabIndex = 5;
            quadraLabel.Text = "Quadra:";
            // 
            // tipoLabel
            // 
            tipoLabel.AutoSize = true;
            tipoLabel.BackColor = System.Drawing.Color.Transparent;
            tipoLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            tipoLabel.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tipoLabel.ForeColor = System.Drawing.Color.White;
            tipoLabel.Location = new System.Drawing.Point(30, 119);
            tipoLabel.Name = "tipoLabel";
            tipoLabel.Size = new System.Drawing.Size(39, 15);
            tipoLabel.TabIndex = 7;
            tipoLabel.Text = "Tipo:";
            // 
            // valorLabel
            // 
            valorLabel.AutoSize = true;
            valorLabel.BackColor = System.Drawing.Color.Transparent;
            valorLabel.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            valorLabel.ForeColor = System.Drawing.Color.White;
            valorLabel.Location = new System.Drawing.Point(30, 157);
            valorLabel.Name = "valorLabel";
            valorLabel.Size = new System.Drawing.Size(43, 15);
            valorLabel.TabIndex = 9;
            valorLabel.Text = "Valor:";
            // 
            // dataLabel
            // 
            dataLabel.AutoSize = true;
            dataLabel.BackColor = System.Drawing.Color.Transparent;
            dataLabel.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataLabel.ForeColor = System.Drawing.Color.White;
            dataLabel.Location = new System.Drawing.Point(30, 196);
            dataLabel.Name = "dataLabel";
            dataLabel.Size = new System.Drawing.Size(39, 15);
            dataLabel.TabIndex = 11;
            dataLabel.Text = "Data:";
            // 
            // cadastroDataSet
            // 
            this.cadastroDataSet.DataSetName = "cadastroDataSet";
            this.cadastroDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cadastroquadraBindingSource
            // 
            this.cadastroquadraBindingSource.DataMember = "Cadastroquadra";
            this.cadastroquadraBindingSource.DataSource = this.cadastroDataSet;
            // 
            // cadastroquadraTableAdapter
            // 
            this.cadastroquadraTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CadastroquadraTableAdapter = this.cadastroquadraTableAdapter;
            this.tableAdapterManager.UpdateOrder = Mãezinha.cadastroDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // n__de_quadraTextBox
            // 
            this.n__de_quadraTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cadastroquadraBindingSource, "N° de quadra", true));
            this.n__de_quadraTextBox.Location = new System.Drawing.Point(129, 45);
            this.n__de_quadraTextBox.Name = "n__de_quadraTextBox";
            this.n__de_quadraTextBox.Size = new System.Drawing.Size(97, 20);
            this.n__de_quadraTextBox.TabIndex = 4;
            // 
            // quadraTextBox
            // 
            this.quadraTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cadastroquadraBindingSource, "Quadra", true));
            this.quadraTextBox.Location = new System.Drawing.Point(129, 77);
            this.quadraTextBox.Name = "quadraTextBox";
            this.quadraTextBox.Size = new System.Drawing.Size(997, 20);
            this.quadraTextBox.TabIndex = 6;
            // 
            // tipoTextBox
            // 
            this.tipoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cadastroquadraBindingSource, "Tipo", true));
            this.tipoTextBox.Location = new System.Drawing.Point(129, 116);
            this.tipoTextBox.Name = "tipoTextBox";
            this.tipoTextBox.Size = new System.Drawing.Size(997, 20);
            this.tipoTextBox.TabIndex = 8;
            // 
            // valorTextBox
            // 
            this.valorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cadastroquadraBindingSource, "Valor", true));
            this.valorTextBox.Location = new System.Drawing.Point(129, 151);
            this.valorTextBox.Name = "valorTextBox";
            this.valorTextBox.Size = new System.Drawing.Size(97, 20);
            this.valorTextBox.TabIndex = 10;
            // 
            // dataDateTimePicker
            // 
            this.dataDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.cadastroquadraBindingSource, "Data", true));
            this.dataDateTimePicker.Location = new System.Drawing.Point(129, 191);
            this.dataDateTimePicker.Name = "dataDateTimePicker";
            this.dataDateTimePicker.Size = new System.Drawing.Size(233, 20);
            this.dataDateTimePicker.TabIndex = 12;
            // 
            // cadastroquadraDataGridView
            // 
            this.cadastroquadraDataGridView.AllowUserToAddRows = false;
            this.cadastroquadraDataGridView.AllowUserToDeleteRows = false;
            this.cadastroquadraDataGridView.AutoGenerateColumns = false;
            this.cadastroquadraDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.cadastroquadraDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cadastroquadraDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.cadastroquadraDataGridView.DataSource = this.cadastroquadraBindingSource;
            this.cadastroquadraDataGridView.Location = new System.Drawing.Point(33, 273);
            this.cadastroquadraDataGridView.Name = "cadastroquadraDataGridView";
            this.cadastroquadraDataGridView.ReadOnly = true;
            this.cadastroquadraDataGridView.Size = new System.Drawing.Size(1295, 389);
            this.cadastroquadraDataGridView.TabIndex = 13;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 50;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "N° de quadra";
            this.dataGridViewTextBoxColumn2.HeaderText = "N° de quadra";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Quadra";
            this.dataGridViewTextBoxColumn3.HeaderText = "Quadra";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 427;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Tipo";
            this.dataGridViewTextBoxColumn4.HeaderText = "Tipo";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 420;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Valor";
            this.dataGridViewTextBoxColumn5.HeaderText = "Valor";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Data";
            this.dataGridViewTextBoxColumn6.HeaderText = "Data";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 154;
            // 
            // btinserir
            // 
            this.btinserir.BackColor = System.Drawing.Color.Transparent;
            this.btinserir.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.btinserir.FlatAppearance.BorderSize = 2;
            this.btinserir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btinserir.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btinserir.ForeColor = System.Drawing.Color.White;
            this.btinserir.Location = new System.Drawing.Point(1223, 45);
            this.btinserir.Name = "btinserir";
            this.btinserir.Size = new System.Drawing.Size(105, 38);
            this.btinserir.TabIndex = 14;
            this.btinserir.Text = "Inserir";
            this.btinserir.UseVisualStyleBackColor = false;
            this.btinserir.Click += new System.EventHandler(this.btinserir_Click);
            // 
            // btsalvar
            // 
            this.btsalvar.BackColor = System.Drawing.Color.Transparent;
            this.btsalvar.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.btsalvar.FlatAppearance.BorderSize = 2;
            this.btsalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btsalvar.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btsalvar.ForeColor = System.Drawing.Color.White;
            this.btsalvar.Location = new System.Drawing.Point(1223, 98);
            this.btsalvar.Name = "btsalvar";
            this.btsalvar.Size = new System.Drawing.Size(105, 38);
            this.btsalvar.TabIndex = 15;
            this.btsalvar.Text = "Salvar";
            this.btsalvar.UseVisualStyleBackColor = false;
            this.btsalvar.Click += new System.EventHandler(this.btsalvar_Click);
            // 
            // btcancelar
            // 
            this.btcancelar.BackColor = System.Drawing.Color.Transparent;
            this.btcancelar.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.btcancelar.FlatAppearance.BorderSize = 2;
            this.btcancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btcancelar.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btcancelar.ForeColor = System.Drawing.Color.White;
            this.btcancelar.Location = new System.Drawing.Point(1223, 151);
            this.btcancelar.Name = "btcancelar";
            this.btcancelar.Size = new System.Drawing.Size(105, 38);
            this.btcancelar.TabIndex = 16;
            this.btcancelar.Text = "Cancelar";
            this.btcancelar.UseVisualStyleBackColor = false;
            this.btcancelar.Click += new System.EventHandler(this.btcancelar_Click);
            // 
            // btexcluir
            // 
            this.btexcluir.BackColor = System.Drawing.Color.Transparent;
            this.btexcluir.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.btexcluir.FlatAppearance.BorderSize = 2;
            this.btexcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btexcluir.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btexcluir.ForeColor = System.Drawing.Color.White;
            this.btexcluir.Location = new System.Drawing.Point(1223, 205);
            this.btexcluir.Name = "btexcluir";
            this.btexcluir.Size = new System.Drawing.Size(105, 38);
            this.btexcluir.TabIndex = 17;
            this.btexcluir.Text = "Excluir";
            this.btexcluir.UseVisualStyleBackColor = false;
            this.btexcluir.Click += new System.EventHandler(this.btexcluir_Click);
            // 
            // btsair2
            // 
            this.btsair2.BackColor = System.Drawing.Color.Red;
            this.btsair2.FlatAppearance.BorderSize = 0;
            this.btsair2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btsair2.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btsair2.ForeColor = System.Drawing.Color.White;
            this.btsair2.Location = new System.Drawing.Point(1326, 6);
            this.btsair2.Name = "btsair2";
            this.btsair2.Size = new System.Drawing.Size(28, 23);
            this.btsair2.TabIndex = 18;
            this.btsair2.Text = "X";
            this.btsair2.UseVisualStyleBackColor = false;
            this.btsair2.Click += new System.EventHandler(this.btsair2_Click);
            // 
            // frmquadra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Mãezinha.Properties.Resources.Clube_de_tênis_fundo;
            this.ClientSize = new System.Drawing.Size(1366, 674);
            this.Controls.Add(this.btsair2);
            this.Controls.Add(this.btexcluir);
            this.Controls.Add(this.btcancelar);
            this.Controls.Add(this.btsalvar);
            this.Controls.Add(this.btinserir);
            this.Controls.Add(this.cadastroquadraDataGridView);
            this.Controls.Add(n__de_quadraLabel);
            this.Controls.Add(this.n__de_quadraTextBox);
            this.Controls.Add(quadraLabel);
            this.Controls.Add(this.quadraTextBox);
            this.Controls.Add(tipoLabel);
            this.Controls.Add(this.tipoTextBox);
            this.Controls.Add(valorLabel);
            this.Controls.Add(this.valorTextBox);
            this.Controls.Add(dataLabel);
            this.Controls.Add(this.dataDateTimePicker);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmquadra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "Cadastro de quadra";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmquadra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cadastroDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadastroquadraBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cadastroquadraDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private cadastroDataSet cadastroDataSet;
        private System.Windows.Forms.BindingSource cadastroquadraBindingSource;
        private cadastroDataSetTableAdapters.CadastroquadraTableAdapter cadastroquadraTableAdapter;
        private cadastroDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox n__de_quadraTextBox;
        private System.Windows.Forms.TextBox quadraTextBox;
        private System.Windows.Forms.TextBox tipoTextBox;
        private System.Windows.Forms.TextBox valorTextBox;
        private System.Windows.Forms.DateTimePicker dataDateTimePicker;
        private System.Windows.Forms.DataGridView cadastroquadraDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.Button btinserir;
        private System.Windows.Forms.Button btsalvar;
        private System.Windows.Forms.Button btcancelar;
        private System.Windows.Forms.Button btexcluir;
        private System.Windows.Forms.Button btsair2;
    }
}