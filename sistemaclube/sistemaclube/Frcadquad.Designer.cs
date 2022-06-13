namespace sistemaclube
{
    partial class Frcadquad
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
            System.Windows.Forms.Label nUM_QUADRALabel;
            System.Windows.Forms.Label nOME_QUADRALabel;
            System.Windows.Forms.Label cOBERTALabel;
            System.Windows.Forms.Label aRQUIBANCADALabel;
            System.Windows.Forms.Label bANCOLabel;
            System.Windows.Forms.Label bLOQUEADOLabel;
            System.Windows.Forms.Label data_cadLabel;
            this.cad_quadraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sistemaDataSet = new sistemaclube.sistemaDataSet();
            this.nUM_QUADRATextBox = new System.Windows.Forms.TextBox();
            this.nOME_QUADRATextBox = new System.Windows.Forms.TextBox();
            this.cOBERTAComboBox = new System.Windows.Forms.ComboBox();
            this.aRQUIBANCADAComboBox = new System.Windows.Forms.ComboBox();
            this.bANCOComboBox = new System.Windows.Forms.ComboBox();
            this.bLOQUEADOComboBox = new System.Windows.Forms.ComboBox();
            this.data_cadDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.cad_quadraTableAdapter = new sistemaclube.sistemaDataSetTableAdapters.cad_quadraTableAdapter();
            this.tableAdapterManager = new sistemaclube.sistemaDataSetTableAdapters.TableAdapterManager();
            this.cad_quadraDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btsair2 = new System.Windows.Forms.Button();
            this.btexcluir = new System.Windows.Forms.Button();
            this.btcancelar = new System.Windows.Forms.Button();
            this.btsalvar = new System.Windows.Forms.Button();
            this.btinserir = new System.Windows.Forms.Button();
            this.btvoltar = new System.Windows.Forms.Button();
            nUM_QUADRALabel = new System.Windows.Forms.Label();
            nOME_QUADRALabel = new System.Windows.Forms.Label();
            cOBERTALabel = new System.Windows.Forms.Label();
            aRQUIBANCADALabel = new System.Windows.Forms.Label();
            bANCOLabel = new System.Windows.Forms.Label();
            bLOQUEADOLabel = new System.Windows.Forms.Label();
            data_cadLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.cad_quadraBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cad_quadraDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // nUM_QUADRALabel
            // 
            nUM_QUADRALabel.AutoSize = true;
            nUM_QUADRALabel.BackColor = System.Drawing.Color.Transparent;
            nUM_QUADRALabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            nUM_QUADRALabel.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nUM_QUADRALabel.ForeColor = System.Drawing.Color.Lime;
            nUM_QUADRALabel.Location = new System.Drawing.Point(41, 30);
            nUM_QUADRALabel.Name = "nUM_QUADRALabel";
            nUM_QUADRALabel.Size = new System.Drawing.Size(80, 15);
            nUM_QUADRALabel.TabIndex = 5;
            nUM_QUADRALabel.Text = "*N° quadra:";
            // 
            // nOME_QUADRALabel
            // 
            nOME_QUADRALabel.AutoSize = true;
            nOME_QUADRALabel.BackColor = System.Drawing.Color.Transparent;
            nOME_QUADRALabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            nOME_QUADRALabel.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nOME_QUADRALabel.ForeColor = System.Drawing.Color.Lime;
            nOME_QUADRALabel.Location = new System.Drawing.Point(40, 78);
            nOME_QUADRALabel.Name = "nOME_QUADRALabel";
            nOME_QUADRALabel.Size = new System.Drawing.Size(111, 15);
            nOME_QUADRALabel.TabIndex = 7;
            nOME_QUADRALabel.Text = "*Tipo de quadra:";
            // 
            // cOBERTALabel
            // 
            cOBERTALabel.AutoSize = true;
            cOBERTALabel.BackColor = System.Drawing.Color.Transparent;
            cOBERTALabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            cOBERTALabel.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cOBERTALabel.ForeColor = System.Drawing.Color.Lime;
            cOBERTALabel.Location = new System.Drawing.Point(41, 121);
            cOBERTALabel.Name = "cOBERTALabel";
            cOBERTALabel.Size = new System.Drawing.Size(66, 15);
            cOBERTALabel.TabIndex = 9;
            cOBERTALabel.Text = "*Coberta:";
            // 
            // aRQUIBANCADALabel
            // 
            aRQUIBANCADALabel.AutoSize = true;
            aRQUIBANCADALabel.BackColor = System.Drawing.Color.Transparent;
            aRQUIBANCADALabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            aRQUIBANCADALabel.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            aRQUIBANCADALabel.ForeColor = System.Drawing.Color.Lime;
            aRQUIBANCADALabel.Location = new System.Drawing.Point(196, 123);
            aRQUIBANCADALabel.Name = "aRQUIBANCADALabel";
            aRQUIBANCADALabel.Size = new System.Drawing.Size(103, 15);
            aRQUIBANCADALabel.TabIndex = 11;
            aRQUIBANCADALabel.Text = "*Arquibancada:";
            // 
            // bANCOLabel
            // 
            bANCOLabel.AutoSize = true;
            bANCOLabel.BackColor = System.Drawing.Color.Transparent;
            bANCOLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            bANCOLabel.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            bANCOLabel.ForeColor = System.Drawing.Color.Lime;
            bANCOLabel.Location = new System.Drawing.Point(41, 170);
            bANCOLabel.Name = "bANCOLabel";
            bANCOLabel.Size = new System.Drawing.Size(55, 15);
            bANCOLabel.TabIndex = 13;
            bANCOLabel.Text = "*Banco:";
            // 
            // bLOQUEADOLabel
            // 
            bLOQUEADOLabel.AutoSize = true;
            bLOQUEADOLabel.BackColor = System.Drawing.Color.Transparent;
            bLOQUEADOLabel.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            bLOQUEADOLabel.ForeColor = System.Drawing.Color.Lime;
            bLOQUEADOLabel.Location = new System.Drawing.Point(205, 170);
            bLOQUEADOLabel.Name = "bLOQUEADOLabel";
            bLOQUEADOLabel.Size = new System.Drawing.Size(83, 15);
            bLOQUEADOLabel.TabIndex = 15;
            bLOQUEADOLabel.Text = "*Bloqueado:";
            bLOQUEADOLabel.Click += new System.EventHandler(this.bLOQUEADOLabel_Click);
            // 
            // data_cadLabel
            // 
            data_cadLabel.AutoSize = true;
            data_cadLabel.BackColor = System.Drawing.Color.Transparent;
            data_cadLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            data_cadLabel.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            data_cadLabel.ForeColor = System.Drawing.Color.Lime;
            data_cadLabel.Location = new System.Drawing.Point(41, 215);
            data_cadLabel.Name = "data_cadLabel";
            data_cadLabel.Size = new System.Drawing.Size(121, 15);
            data_cadLabel.TabIndex = 17;
            data_cadLabel.Text = "*Data de cadastro:";
            // 
            // cad_quadraBindingSource
            // 
            this.cad_quadraBindingSource.DataMember = "cad_quadra";
            this.cad_quadraBindingSource.DataSource = this.sistemaDataSet;
            // 
            // sistemaDataSet
            // 
            this.sistemaDataSet.DataSetName = "sistemaDataSet";
            this.sistemaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nUM_QUADRATextBox
            // 
            this.nUM_QUADRATextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cad_quadraBindingSource, "NUM_QUADRA", true));
            this.nUM_QUADRATextBox.Location = new System.Drawing.Point(151, 28);
            this.nUM_QUADRATextBox.Name = "nUM_QUADRATextBox";
            this.nUM_QUADRATextBox.Size = new System.Drawing.Size(590, 20);
            this.nUM_QUADRATextBox.TabIndex = 6;
            // 
            // nOME_QUADRATextBox
            // 
            this.nOME_QUADRATextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cad_quadraBindingSource, "NOME_QUADRA", true));
            this.nOME_QUADRATextBox.Location = new System.Drawing.Point(151, 75);
            this.nOME_QUADRATextBox.Name = "nOME_QUADRATextBox";
            this.nOME_QUADRATextBox.Size = new System.Drawing.Size(590, 20);
            this.nOME_QUADRATextBox.TabIndex = 8;
            // 
            // cOBERTAComboBox
            // 
            this.cOBERTAComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cad_quadraBindingSource, "COBERTA", true));
            this.cOBERTAComboBox.FormattingEnabled = true;
            this.cOBERTAComboBox.Items.AddRange(new object[] {
            "S",
            "N"});
            this.cOBERTAComboBox.Location = new System.Drawing.Point(128, 118);
            this.cOBERTAComboBox.Name = "cOBERTAComboBox";
            this.cOBERTAComboBox.Size = new System.Drawing.Size(53, 21);
            this.cOBERTAComboBox.TabIndex = 10;
            // 
            // aRQUIBANCADAComboBox
            // 
            this.aRQUIBANCADAComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cad_quadraBindingSource, "ARQUIBANCADA", true));
            this.aRQUIBANCADAComboBox.FormattingEnabled = true;
            this.aRQUIBANCADAComboBox.Items.AddRange(new object[] {
            "S",
            "N"});
            this.aRQUIBANCADAComboBox.Location = new System.Drawing.Point(299, 121);
            this.aRQUIBANCADAComboBox.Name = "aRQUIBANCADAComboBox";
            this.aRQUIBANCADAComboBox.Size = new System.Drawing.Size(53, 21);
            this.aRQUIBANCADAComboBox.TabIndex = 12;
            // 
            // bANCOComboBox
            // 
            this.bANCOComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cad_quadraBindingSource, "BANCO", true));
            this.bANCOComboBox.FormattingEnabled = true;
            this.bANCOComboBox.Items.AddRange(new object[] {
            "S",
            "N"});
            this.bANCOComboBox.Location = new System.Drawing.Point(127, 168);
            this.bANCOComboBox.Name = "bANCOComboBox";
            this.bANCOComboBox.Size = new System.Drawing.Size(53, 21);
            this.bANCOComboBox.TabIndex = 14;
            // 
            // bLOQUEADOComboBox
            // 
            this.bLOQUEADOComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cad_quadraBindingSource, "BLOQUEADO", true));
            this.bLOQUEADOComboBox.FormattingEnabled = true;
            this.bLOQUEADOComboBox.Items.AddRange(new object[] {
            "S",
            "N"});
            this.bLOQUEADOComboBox.Location = new System.Drawing.Point(298, 168);
            this.bLOQUEADOComboBox.Name = "bLOQUEADOComboBox";
            this.bLOQUEADOComboBox.Size = new System.Drawing.Size(53, 21);
            this.bLOQUEADOComboBox.TabIndex = 16;
            this.bLOQUEADOComboBox.SelectedIndexChanged += new System.EventHandler(this.bLOQUEADOComboBox_SelectedIndexChanged);
            // 
            // data_cadDateTimePicker
            // 
            this.data_cadDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.cad_quadraBindingSource, "Data_cad", true));
            this.data_cadDateTimePicker.Location = new System.Drawing.Point(162, 212);
            this.data_cadDateTimePicker.Name = "data_cadDateTimePicker";
            this.data_cadDateTimePicker.Size = new System.Drawing.Size(226, 20);
            this.data_cadDateTimePicker.TabIndex = 18;
            // 
            // cad_quadraTableAdapter
            // 
            this.cad_quadraTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.cad_quadraTableAdapter = this.cad_quadraTableAdapter;
            this.tableAdapterManager.horariosTableAdapter = null;
            this.tableAdapterManager.reservaTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = sistemaclube.sistemaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.usuarioTableAdapter = null;
            // 
            // cad_quadraDataGridView
            // 
            this.cad_quadraDataGridView.AllowUserToAddRows = false;
            this.cad_quadraDataGridView.AllowUserToDeleteRows = false;
            this.cad_quadraDataGridView.AutoGenerateColumns = false;
            this.cad_quadraDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cad_quadraDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.cad_quadraDataGridView.DataSource = this.cad_quadraBindingSource;
            this.cad_quadraDataGridView.Location = new System.Drawing.Point(43, 270);
            this.cad_quadraDataGridView.Name = "cad_quadraDataGridView";
            this.cad_quadraDataGridView.ReadOnly = true;
            this.cad_quadraDataGridView.Size = new System.Drawing.Size(1284, 401);
            this.cad_quadraDataGridView.TabIndex = 18;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID_QUADRA";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "NUM_QUADRA";
            this.dataGridViewTextBoxColumn2.HeaderText = "N° quadra";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "NOME_QUADRA";
            this.dataGridViewTextBoxColumn3.HeaderText = "Tipo de quadra";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 240;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "COBERTA";
            this.dataGridViewTextBoxColumn4.HeaderText = "Coberta";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 150;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "ARQUIBANCADA";
            this.dataGridViewTextBoxColumn5.HeaderText = "Arquibancada";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 150;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "BANCO";
            this.dataGridViewTextBoxColumn6.HeaderText = "Banco";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 150;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "BLOQUEADO";
            this.dataGridViewTextBoxColumn7.HeaderText = "Bloqueado";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 150;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Data_cad";
            this.dataGridViewTextBoxColumn8.HeaderText = "Data de cadastro";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Width = 150;
            // 
            // btsair2
            // 
            this.btsair2.BackColor = System.Drawing.Color.Red;
            this.btsair2.FlatAppearance.BorderSize = 0;
            this.btsair2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btsair2.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btsair2.ForeColor = System.Drawing.Color.White;
            this.btsair2.Location = new System.Drawing.Point(1325, 6);
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
            this.btexcluir.Location = new System.Drawing.Point(1222, 205);
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
            this.btcancelar.Location = new System.Drawing.Point(1222, 151);
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
            this.btsalvar.Location = new System.Drawing.Point(1222, 98);
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
            this.btinserir.Location = new System.Drawing.Point(1222, 45);
            this.btinserir.Name = "btinserir";
            this.btinserir.Size = new System.Drawing.Size(105, 38);
            this.btinserir.TabIndex = 19;
            this.btinserir.Text = "Inserir";
            this.btinserir.UseVisualStyleBackColor = false;
            this.btinserir.Click += new System.EventHandler(this.btinserir_Click);
            // 
            // btvoltar
            // 
            this.btvoltar.Location = new System.Drawing.Point(1289, 6);
            this.btvoltar.Name = "btvoltar";
            this.btvoltar.Size = new System.Drawing.Size(30, 23);
            this.btvoltar.TabIndex = 24;
            this.btvoltar.Text = "<";
            this.btvoltar.UseVisualStyleBackColor = true;
            this.btvoltar.Click += new System.EventHandler(this.btvoltar_Click);
            // 
            // Frcadquad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::sistemaclube.Properties.Resources.Clube_de_tênis_fundo;
            this.ClientSize = new System.Drawing.Size(1366, 719);
            this.Controls.Add(this.btvoltar);
            this.Controls.Add(this.btsair2);
            this.Controls.Add(this.btexcluir);
            this.Controls.Add(this.btcancelar);
            this.Controls.Add(this.btsalvar);
            this.Controls.Add(this.btinserir);
            this.Controls.Add(this.cad_quadraDataGridView);
            this.Controls.Add(nUM_QUADRALabel);
            this.Controls.Add(this.nUM_QUADRATextBox);
            this.Controls.Add(nOME_QUADRALabel);
            this.Controls.Add(this.nOME_QUADRATextBox);
            this.Controls.Add(cOBERTALabel);
            this.Controls.Add(this.cOBERTAComboBox);
            this.Controls.Add(aRQUIBANCADALabel);
            this.Controls.Add(this.aRQUIBANCADAComboBox);
            this.Controls.Add(bANCOLabel);
            this.Controls.Add(this.bANCOComboBox);
            this.Controls.Add(bLOQUEADOLabel);
            this.Controls.Add(this.bLOQUEADOComboBox);
            this.Controls.Add(data_cadLabel);
            this.Controls.Add(this.data_cadDateTimePicker);
            this.ForeColor = System.Drawing.Color.Lime;
            this.Name = "Frcadquad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "cadastros de quadra";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Frcadquad_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cad_quadraBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cad_quadraDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private sistemaDataSet sistemaDataSet;
        private System.Windows.Forms.BindingSource cad_quadraBindingSource;
        private sistemaDataSetTableAdapters.cad_quadraTableAdapter cad_quadraTableAdapter;
        private sistemaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox nUM_QUADRATextBox;
        private System.Windows.Forms.TextBox nOME_QUADRATextBox;
        private System.Windows.Forms.ComboBox cOBERTAComboBox;
        private System.Windows.Forms.ComboBox aRQUIBANCADAComboBox;
        private System.Windows.Forms.ComboBox bANCOComboBox;
        private System.Windows.Forms.ComboBox bLOQUEADOComboBox;
        private System.Windows.Forms.DateTimePicker data_cadDateTimePicker;
        private System.Windows.Forms.DataGridView cad_quadraDataGridView;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.Button btvoltar;
    }
}