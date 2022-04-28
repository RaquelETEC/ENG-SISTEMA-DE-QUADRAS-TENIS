namespace cadhorario
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label ds_disponibilidadeLabel;
            System.Windows.Forms.Label ds_horaLabel;
            System.Windows.Forms.Label ds_dataLabel;
            this.cadastroDataSet = new cadhorario.cadastroDataSet();
            this.tb_horarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tb_horarioTableAdapter = new cadhorario.cadastroDataSetTableAdapters.tb_horarioTableAdapter();
            this.tableAdapterManager = new cadhorario.cadastroDataSetTableAdapters.TableAdapterManager();
            this.tb_quadrasTableAdapter = new cadhorario.cadastroDataSetTableAdapters.tb_quadrasTableAdapter();
            this.tb_quadrasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tb_quadrasBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.idComboBox = new System.Windows.Forms.ComboBox();
            this.tb_quadrasBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.ds_disponibilidadeComboBox = new System.Windows.Forms.ComboBox();
            this.ds_horaTextBox = new System.Windows.Forms.TextBox();
            this.ds_dataDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.tb_horarioDataGridView = new System.Windows.Forms.DataGridView();
            this.btsair2 = new System.Windows.Forms.Button();
            this.btexcluir = new System.Windows.Forms.Button();
            this.btcancelar = new System.Windows.Forms.Button();
            this.btsalvar = new System.Windows.Forms.Button();
            this.btinserir = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            idLabel = new System.Windows.Forms.Label();
            ds_disponibilidadeLabel = new System.Windows.Forms.Label();
            ds_horaLabel = new System.Windows.Forms.Label();
            ds_dataLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cadastroDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_horarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_quadrasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_quadrasBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_quadrasBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_horarioDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.BackColor = System.Drawing.Color.Transparent;
            idLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            idLabel.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            idLabel.ForeColor = System.Drawing.Color.White;
            idLabel.Location = new System.Drawing.Point(34, 49);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(93, 15);
            idLabel.TabIndex = 3;
            idLabel.Text = "N° de quadra:";
            // 
            // ds_disponibilidadeLabel
            // 
            ds_disponibilidadeLabel.AutoSize = true;
            ds_disponibilidadeLabel.BackColor = System.Drawing.Color.Transparent;
            ds_disponibilidadeLabel.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ds_disponibilidadeLabel.ForeColor = System.Drawing.Color.White;
            ds_disponibilidadeLabel.Location = new System.Drawing.Point(34, 89);
            ds_disponibilidadeLabel.Name = "ds_disponibilidadeLabel";
            ds_disponibilidadeLabel.Size = new System.Drawing.Size(108, 15);
            ds_disponibilidadeLabel.TabIndex = 5;
            ds_disponibilidadeLabel.Text = "Disponibilidade:";
            // 
            // ds_horaLabel
            // 
            ds_horaLabel.AutoSize = true;
            ds_horaLabel.BackColor = System.Drawing.Color.Transparent;
            ds_horaLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            ds_horaLabel.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ds_horaLabel.ForeColor = System.Drawing.Color.White;
            ds_horaLabel.Location = new System.Drawing.Point(34, 135);
            ds_horaLabel.Name = "ds_horaLabel";
            ds_horaLabel.Size = new System.Drawing.Size(126, 15);
            ds_horaLabel.TabIndex = 7;
            ds_horaLabel.Text = "Horario disponivel:";
            // 
            // ds_dataLabel
            // 
            ds_dataLabel.AutoSize = true;
            ds_dataLabel.BackColor = System.Drawing.Color.Transparent;
            ds_dataLabel.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ds_dataLabel.ForeColor = System.Drawing.Color.White;
            ds_dataLabel.Location = new System.Drawing.Point(34, 174);
            ds_dataLabel.Name = "ds_dataLabel";
            ds_dataLabel.Size = new System.Drawing.Size(39, 15);
            ds_dataLabel.TabIndex = 9;
            ds_dataLabel.Text = "Data:";
            // 
            // cadastroDataSet
            // 
            this.cadastroDataSet.DataSetName = "cadastroDataSet";
            this.cadastroDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tb_horarioBindingSource
            // 
            this.tb_horarioBindingSource.DataMember = "tb_horario";
            this.tb_horarioBindingSource.DataSource = this.cadastroDataSet;
            // 
            // tb_horarioTableAdapter
            // 
            this.tb_horarioTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tb_horarioTableAdapter = this.tb_horarioTableAdapter;
            this.tableAdapterManager.tb_quadrasTableAdapter = this.tb_quadrasTableAdapter;
            this.tableAdapterManager.UpdateOrder = cadhorario.cadastroDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tb_quadrasTableAdapter
            // 
            this.tb_quadrasTableAdapter.ClearBeforeFill = true;
            // 
            // tb_quadrasBindingSource
            // 
            this.tb_quadrasBindingSource.DataMember = "tb_quadras";
            this.tb_quadrasBindingSource.DataSource = this.cadastroDataSet;
            // 
            // tb_quadrasBindingSource1
            // 
            this.tb_quadrasBindingSource1.DataMember = "tb_quadras";
            this.tb_quadrasBindingSource1.DataSource = this.cadastroDataSet;
            // 
            // idComboBox
            // 
            this.idComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.tb_horarioBindingSource, "id", true));
            this.idComboBox.DataSource = this.tb_quadrasBindingSource2;
            this.idComboBox.DisplayMember = "ds_numquad";
            this.idComboBox.FormattingEnabled = true;
            this.idComboBox.Location = new System.Drawing.Point(166, 46);
            this.idComboBox.Name = "idComboBox";
            this.idComboBox.Size = new System.Drawing.Size(375, 21);
            this.idComboBox.TabIndex = 4;
            this.idComboBox.ValueMember = "ds_numquad";
            // 
            // tb_quadrasBindingSource2
            // 
            this.tb_quadrasBindingSource2.DataMember = "tb_quadras";
            this.tb_quadrasBindingSource2.DataSource = this.cadastroDataSet;
            // 
            // ds_disponibilidadeComboBox
            // 
            this.ds_disponibilidadeComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_horarioBindingSource, "ds_disponibilidade", true));
            this.ds_disponibilidadeComboBox.FormattingEnabled = true;
            this.ds_disponibilidadeComboBox.Items.AddRange(new object[] {
            "Disponivel ",
            "Indisponivel",
            "Em manutenção"});
            this.ds_disponibilidadeComboBox.Location = new System.Drawing.Point(166, 89);
            this.ds_disponibilidadeComboBox.Name = "ds_disponibilidadeComboBox";
            this.ds_disponibilidadeComboBox.Size = new System.Drawing.Size(375, 21);
            this.ds_disponibilidadeComboBox.TabIndex = 6;
            // 
            // ds_horaTextBox
            // 
            this.ds_horaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tb_horarioBindingSource, "ds_hora", true));
            this.ds_horaTextBox.Location = new System.Drawing.Point(166, 133);
            this.ds_horaTextBox.Name = "ds_horaTextBox";
            this.ds_horaTextBox.Size = new System.Drawing.Size(121, 20);
            this.ds_horaTextBox.TabIndex = 8;
            // 
            // ds_dataDateTimePicker
            // 
            this.ds_dataDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.tb_horarioBindingSource, "ds_data", true));
            this.ds_dataDateTimePicker.Location = new System.Drawing.Point(166, 170);
            this.ds_dataDateTimePicker.Name = "ds_dataDateTimePicker";
            this.ds_dataDateTimePicker.Size = new System.Drawing.Size(267, 20);
            this.ds_dataDateTimePicker.TabIndex = 10;
            // 
            // tb_horarioDataGridView
            // 
            this.tb_horarioDataGridView.AllowUserToAddRows = false;
            this.tb_horarioDataGridView.AllowUserToDeleteRows = false;
            this.tb_horarioDataGridView.AutoGenerateColumns = false;
            this.tb_horarioDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tb_horarioDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.tb_horarioDataGridView.DataSource = this.tb_horarioBindingSource;
            this.tb_horarioDataGridView.Location = new System.Drawing.Point(36, 267);
            this.tb_horarioDataGridView.Name = "tb_horarioDataGridView";
            this.tb_horarioDataGridView.ReadOnly = true;
            this.tb_horarioDataGridView.Size = new System.Drawing.Size(1290, 428);
            this.tb_horarioDataGridView.TabIndex = 11;
            // 
            // btsair2
            // 
            this.btsair2.BackColor = System.Drawing.Color.Red;
            this.btsair2.FlatAppearance.BorderSize = 0;
            this.btsair2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btsair2.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btsair2.ForeColor = System.Drawing.Color.White;
            this.btsair2.Location = new System.Drawing.Point(1324, 7);
            this.btsair2.Name = "btsair2";
            this.btsair2.Size = new System.Drawing.Size(28, 23);
            this.btsair2.TabIndex = 23;
            this.btsair2.Text = "X";
            this.btsair2.UseVisualStyleBackColor = false;
            this.btsair2.Click += new System.EventHandler(this.btsair2_Click);
            // 
            // btexcluir
            // 
            this.btexcluir.BackColor = System.Drawing.Color.Transparent;
            this.btexcluir.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.btexcluir.FlatAppearance.BorderSize = 2;
            this.btexcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btexcluir.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btexcluir.ForeColor = System.Drawing.Color.White;
            this.btexcluir.Location = new System.Drawing.Point(1221, 206);
            this.btexcluir.Name = "btexcluir";
            this.btexcluir.Size = new System.Drawing.Size(105, 38);
            this.btexcluir.TabIndex = 22;
            this.btexcluir.Text = "Excluir";
            this.btexcluir.UseVisualStyleBackColor = false;
            this.btexcluir.Click += new System.EventHandler(this.btexcluir_Click);
            // 
            // btcancelar
            // 
            this.btcancelar.BackColor = System.Drawing.Color.Transparent;
            this.btcancelar.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.btcancelar.FlatAppearance.BorderSize = 2;
            this.btcancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btcancelar.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btcancelar.ForeColor = System.Drawing.Color.White;
            this.btcancelar.Location = new System.Drawing.Point(1221, 152);
            this.btcancelar.Name = "btcancelar";
            this.btcancelar.Size = new System.Drawing.Size(105, 38);
            this.btcancelar.TabIndex = 21;
            this.btcancelar.Text = "Cancelar";
            this.btcancelar.UseVisualStyleBackColor = false;
            this.btcancelar.Click += new System.EventHandler(this.btcancelar_Click);
            // 
            // btsalvar
            // 
            this.btsalvar.BackColor = System.Drawing.Color.Transparent;
            this.btsalvar.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.btsalvar.FlatAppearance.BorderSize = 2;
            this.btsalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btsalvar.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btsalvar.ForeColor = System.Drawing.Color.White;
            this.btsalvar.Location = new System.Drawing.Point(1221, 99);
            this.btsalvar.Name = "btsalvar";
            this.btsalvar.Size = new System.Drawing.Size(105, 38);
            this.btsalvar.TabIndex = 20;
            this.btsalvar.Text = "Salvar";
            this.btsalvar.UseVisualStyleBackColor = false;
            this.btsalvar.Click += new System.EventHandler(this.btsalvar_Click);
            // 
            // btinserir
            // 
            this.btinserir.BackColor = System.Drawing.Color.Transparent;
            this.btinserir.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.btinserir.FlatAppearance.BorderSize = 2;
            this.btinserir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btinserir.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btinserir.ForeColor = System.Drawing.Color.White;
            this.btinserir.Location = new System.Drawing.Point(1221, 46);
            this.btinserir.Name = "btinserir";
            this.btinserir.Size = new System.Drawing.Size(105, 38);
            this.btinserir.TabIndex = 19;
            this.btinserir.Text = "Inserir";
            this.btinserir.UseVisualStyleBackColor = false;
            this.btinserir.Click += new System.EventHandler(this.btinserir_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id_horario";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 146;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn2.HeaderText = "N° de quadra";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 200;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "ds_disponibilidade";
            this.dataGridViewTextBoxColumn3.HeaderText = "Disponibilidade";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 400;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "ds_hora";
            this.dataGridViewTextBoxColumn4.HeaderText = "Horario disponivel";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 250;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "ds_data";
            this.dataGridViewTextBoxColumn5.HeaderText = "Data";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 250;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::cadhorario.Properties.Resources.Clube_de_tênis_fundo;
            this.ClientSize = new System.Drawing.Size(1356, 700);
            this.Controls.Add(this.btsair2);
            this.Controls.Add(this.btexcluir);
            this.Controls.Add(this.btcancelar);
            this.Controls.Add(this.btsalvar);
            this.Controls.Add(this.btinserir);
            this.Controls.Add(this.tb_horarioDataGridView);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idComboBox);
            this.Controls.Add(ds_disponibilidadeLabel);
            this.Controls.Add(this.ds_disponibilidadeComboBox);
            this.Controls.Add(ds_horaLabel);
            this.Controls.Add(this.ds_horaTextBox);
            this.Controls.Add(ds_dataLabel);
            this.Controls.Add(this.ds_dataDateTimePicker);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "frmcadhorario";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cadastroDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_horarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_quadrasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_quadrasBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_quadrasBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tb_horarioDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private cadastroDataSet cadastroDataSet;
        private System.Windows.Forms.BindingSource tb_horarioBindingSource;
        private cadastroDataSetTableAdapters.tb_horarioTableAdapter tb_horarioTableAdapter;
        private cadastroDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private cadastroDataSetTableAdapters.tb_quadrasTableAdapter tb_quadrasTableAdapter;
        private System.Windows.Forms.BindingSource tb_quadrasBindingSource;
        private System.Windows.Forms.BindingSource tb_quadrasBindingSource1;
        private System.Windows.Forms.ComboBox idComboBox;
        private System.Windows.Forms.BindingSource tb_quadrasBindingSource2;
        private System.Windows.Forms.ComboBox ds_disponibilidadeComboBox;
        private System.Windows.Forms.TextBox ds_horaTextBox;
        private System.Windows.Forms.DateTimePicker ds_dataDateTimePicker;
        private System.Windows.Forms.DataGridView tb_horarioDataGridView;
        private System.Windows.Forms.Button btsair2;
        private System.Windows.Forms.Button btexcluir;
        private System.Windows.Forms.Button btcancelar;
        private System.Windows.Forms.Button btsalvar;
        private System.Windows.Forms.Button btinserir;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}

