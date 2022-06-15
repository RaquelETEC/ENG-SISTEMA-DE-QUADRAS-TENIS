namespace sistemaclube
{
    partial class frusuario
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
            System.Windows.Forms.Label lOGINLabel;
            System.Windows.Forms.Label sENHALabel;
            System.Windows.Forms.Label fUNCAOLabel;
            System.Windows.Forms.Label bLOQUEADOLabel;
            System.Windows.Forms.Label label1;
            this.sistemaDataSet = new sistemaclube.sistemaDataSet();
            this.usuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usuarioTableAdapter = new sistemaclube.sistemaDataSetTableAdapters.usuarioTableAdapter();
            this.tableAdapterManager = new sistemaclube.sistemaDataSetTableAdapters.TableAdapterManager();
            this.lOGINTextBox = new System.Windows.Forms.TextBox();
            this.sENHATextBox = new System.Windows.Forms.TextBox();
            this.fUNCAOComboBox = new System.Windows.Forms.ComboBox();
            this.bLOQUEADOComboBox = new System.Windows.Forms.ComboBox();
            this.btsair2 = new System.Windows.Forms.Button();
            this.btexcluir = new System.Windows.Forms.Button();
            this.btcancelar = new System.Windows.Forms.Button();
            this.btsalvar = new System.Windows.Forms.Button();
            this.btinserir = new System.Windows.Forms.Button();
            this.usuarioDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textid = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            lOGINLabel = new System.Windows.Forms.Label();
            sENHALabel = new System.Windows.Forms.Label();
            fUNCAOLabel = new System.Windows.Forms.Label();
            bLOQUEADOLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // lOGINLabel
            // 
            lOGINLabel.AutoSize = true;
            lOGINLabel.BackColor = System.Drawing.Color.Transparent;
            lOGINLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            lOGINLabel.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lOGINLabel.ForeColor = System.Drawing.Color.Lime;
            lOGINLabel.Location = new System.Drawing.Point(39, 36);
            lOGINLabel.Name = "lOGINLabel";
            lOGINLabel.Size = new System.Drawing.Size(57, 15);
            lOGINLabel.TabIndex = 3;
            lOGINLabel.Text = "*E-mail:";
            // 
            // sENHALabel
            // 
            sENHALabel.AutoSize = true;
            sENHALabel.BackColor = System.Drawing.Color.Transparent;
            sENHALabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            sENHALabel.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            sENHALabel.ForeColor = System.Drawing.Color.Lime;
            sENHALabel.Location = new System.Drawing.Point(39, 87);
            sENHALabel.Name = "sENHALabel";
            sENHALabel.Size = new System.Drawing.Size(54, 15);
            sENHALabel.TabIndex = 5;
            sENHALabel.Text = "*Senha:";
            // 
            // fUNCAOLabel
            // 
            fUNCAOLabel.AutoSize = true;
            fUNCAOLabel.BackColor = System.Drawing.Color.Transparent;
            fUNCAOLabel.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            fUNCAOLabel.ForeColor = System.Drawing.Color.Lime;
            fUNCAOLabel.Location = new System.Drawing.Point(39, 191);
            fUNCAOLabel.Name = "fUNCAOLabel";
            fUNCAOLabel.Size = new System.Drawing.Size(62, 15);
            fUNCAOLabel.TabIndex = 9;
            fUNCAOLabel.Text = "*Função:";
            // 
            // bLOQUEADOLabel
            // 
            bLOQUEADOLabel.AutoSize = true;
            bLOQUEADOLabel.BackColor = System.Drawing.Color.Transparent;
            bLOQUEADOLabel.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            bLOQUEADOLabel.ForeColor = System.Drawing.Color.Lime;
            bLOQUEADOLabel.Location = new System.Drawing.Point(39, 138);
            bLOQUEADOLabel.Name = "bLOQUEADOLabel";
            bLOQUEADOLabel.Size = new System.Drawing.Size(83, 15);
            bLOQUEADOLabel.TabIndex = 10;
            bLOQUEADOLabel.Text = "*Bloqueado:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.Color.Transparent;
            label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            label1.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.ForeColor = System.Drawing.Color.Lime;
            label1.Location = new System.Drawing.Point(688, 36);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(87, 15);
            label1.TabIndex = 30;
            label1.Text = "ID (OCULTO)";
            label1.Visible = false;
            // 
            // sistemaDataSet
            // 
            this.sistemaDataSet.DataSetName = "sistemaDataSet";
            this.sistemaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usuarioBindingSource
            // 
            this.usuarioBindingSource.DataMember = "usuario";
            this.usuarioBindingSource.DataSource = this.sistemaDataSet;
            // 
            // usuarioTableAdapter
            // 
            this.usuarioTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.cad_quadraTableAdapter = null;
            this.tableAdapterManager.horariosTableAdapter = null;
            this.tableAdapterManager.reservaTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = sistemaclube.sistemaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.usuarioTableAdapter = this.usuarioTableAdapter;
            // 
            // lOGINTextBox
            // 
            this.lOGINTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "LOGIN", true));
            this.lOGINTextBox.Location = new System.Drawing.Point(42, 54);
            this.lOGINTextBox.Name = "lOGINTextBox";
            this.lOGINTextBox.Size = new System.Drawing.Size(547, 20);
            this.lOGINTextBox.TabIndex = 4;
            // 
            // sENHATextBox
            // 
            this.sENHATextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "SENHA", true));
            this.sENHATextBox.Location = new System.Drawing.Point(42, 103);
            this.sENHATextBox.Name = "sENHATextBox";
            this.sENHATextBox.Size = new System.Drawing.Size(121, 20);
            this.sENHATextBox.TabIndex = 6;
            // 
            // fUNCAOComboBox
            // 
            this.fUNCAOComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "FUNCAO", true));
            this.fUNCAOComboBox.FormattingEnabled = true;
            this.fUNCAOComboBox.Items.AddRange(new object[] {
            "Adiministrador(a)",
            "Zelador(a)"});
            this.fUNCAOComboBox.Location = new System.Drawing.Point(42, 209);
            this.fUNCAOComboBox.Name = "fUNCAOComboBox";
            this.fUNCAOComboBox.Size = new System.Drawing.Size(121, 21);
            this.fUNCAOComboBox.TabIndex = 10;
            // 
            // bLOQUEADOComboBox
            // 
            this.bLOQUEADOComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "BLOQUEADO", true));
            this.bLOQUEADOComboBox.FormattingEnabled = true;
            this.bLOQUEADOComboBox.Items.AddRange(new object[] {
            "S",
            "N"});
            this.bLOQUEADOComboBox.Location = new System.Drawing.Point(42, 156);
            this.bLOQUEADOComboBox.Name = "bLOQUEADOComboBox";
            this.bLOQUEADOComboBox.Size = new System.Drawing.Size(121, 21);
            this.bLOQUEADOComboBox.TabIndex = 11;
            // 
            // btsair2
            // 
            this.btsair2.BackColor = System.Drawing.Color.Red;
            this.btsair2.FlatAppearance.BorderSize = 0;
            this.btsair2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btsair2.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btsair2.ForeColor = System.Drawing.Color.White;
            this.btsair2.Location = new System.Drawing.Point(1309, 5);
            this.btsair2.Name = "btsair2";
            this.btsair2.Size = new System.Drawing.Size(28, 23);
            this.btsair2.TabIndex = 28;
            this.btsair2.Text = "X";
            this.btsair2.UseVisualStyleBackColor = false;
            this.btsair2.Click += new System.EventHandler(this.btsair2_Click);
            // 
            // btexcluir
            // 
            this.btexcluir.BackColor = System.Drawing.Color.Transparent;
            this.btexcluir.FlatAppearance.BorderColor = System.Drawing.Color.DarkGreen;
            this.btexcluir.FlatAppearance.BorderSize = 2;
            this.btexcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btexcluir.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btexcluir.ForeColor = System.Drawing.Color.White;
            this.btexcluir.Location = new System.Drawing.Point(1206, 204);
            this.btexcluir.Name = "btexcluir";
            this.btexcluir.Size = new System.Drawing.Size(105, 38);
            this.btexcluir.TabIndex = 27;
            this.btexcluir.Text = "Excluir";
            this.btexcluir.UseVisualStyleBackColor = false;
            this.btexcluir.Click += new System.EventHandler(this.btexcluir_Click);
            // 
            // btcancelar
            // 
            this.btcancelar.BackColor = System.Drawing.Color.Transparent;
            this.btcancelar.FlatAppearance.BorderColor = System.Drawing.Color.DarkGreen;
            this.btcancelar.FlatAppearance.BorderSize = 2;
            this.btcancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btcancelar.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btcancelar.ForeColor = System.Drawing.Color.White;
            this.btcancelar.Location = new System.Drawing.Point(1206, 150);
            this.btcancelar.Name = "btcancelar";
            this.btcancelar.Size = new System.Drawing.Size(105, 38);
            this.btcancelar.TabIndex = 26;
            this.btcancelar.Text = "Cancelar";
            this.btcancelar.UseVisualStyleBackColor = false;
            this.btcancelar.Click += new System.EventHandler(this.btcancelar_Click);
            // 
            // btsalvar
            // 
            this.btsalvar.BackColor = System.Drawing.Color.Transparent;
            this.btsalvar.FlatAppearance.BorderColor = System.Drawing.Color.DarkGreen;
            this.btsalvar.FlatAppearance.BorderSize = 2;
            this.btsalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btsalvar.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btsalvar.ForeColor = System.Drawing.Color.White;
            this.btsalvar.Location = new System.Drawing.Point(1206, 97);
            this.btsalvar.Name = "btsalvar";
            this.btsalvar.Size = new System.Drawing.Size(105, 38);
            this.btsalvar.TabIndex = 25;
            this.btsalvar.Text = "Salvar";
            this.btsalvar.UseVisualStyleBackColor = false;
            this.btsalvar.Click += new System.EventHandler(this.btsalvar_Click);
            // 
            // btinserir
            // 
            this.btinserir.BackColor = System.Drawing.Color.Transparent;
            this.btinserir.FlatAppearance.BorderColor = System.Drawing.Color.DarkGreen;
            this.btinserir.FlatAppearance.BorderSize = 2;
            this.btinserir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btinserir.Font = new System.Drawing.Font("Segoe UI Symbol", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btinserir.ForeColor = System.Drawing.Color.White;
            this.btinserir.Location = new System.Drawing.Point(1206, 44);
            this.btinserir.Name = "btinserir";
            this.btinserir.Size = new System.Drawing.Size(105, 38);
            this.btinserir.TabIndex = 24;
            this.btinserir.Text = "Inserir";
            this.btinserir.UseVisualStyleBackColor = false;
            this.btinserir.Click += new System.EventHandler(this.btinserir_Click);
            // 
            // usuarioDataGridView
            // 
            this.usuarioDataGridView.AllowUserToAddRows = false;
            this.usuarioDataGridView.AllowUserToDeleteRows = false;
            this.usuarioDataGridView.AutoGenerateColumns = false;
            this.usuarioDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usuarioDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.usuarioDataGridView.DataSource = this.usuarioBindingSource;
            this.usuarioDataGridView.GridColor = System.Drawing.Color.Silver;
            this.usuarioDataGridView.Location = new System.Drawing.Point(29, 266);
            this.usuarioDataGridView.Name = "usuarioDataGridView";
            this.usuarioDataGridView.ReadOnly = true;
            this.usuarioDataGridView.Size = new System.Drawing.Size(1266, 74);
            this.usuarioDataGridView.TabIndex = 28;
            this.usuarioDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.usuarioDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID_USUARIO";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "LOGIN";
            this.dataGridViewTextBoxColumn2.HeaderText = "Login";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 400;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "SENHA";
            this.dataGridViewTextBoxColumn3.HeaderText = "Senha";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 400;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "BLOQUEADO";
            this.dataGridViewTextBoxColumn4.HeaderText = "Bloqueado";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 102;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "FUNCAO";
            this.dataGridViewTextBoxColumn5.HeaderText = "Função";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 220;
            // 
            // textid
            // 
            this.textid.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "SENHA", true));
            this.textid.Location = new System.Drawing.Point(691, 54);
            this.textid.Name = "textid";
            this.textid.Size = new System.Drawing.Size(50, 20);
            this.textid.TabIndex = 29;
            this.textid.Visible = false;
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(29, 361);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1266, 150);
            this.listView1.TabIndex = 31;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // frusuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::sistemaclube.Properties.Resources.Clube_de_tênis_fundo;
            this.ClientSize = new System.Drawing.Size(1357, 647);
            this.Controls.Add(this.listView1);
            this.Controls.Add(label1);
            this.Controls.Add(this.textid);
            this.Controls.Add(this.usuarioDataGridView);
            this.Controls.Add(this.btsair2);
            this.Controls.Add(this.btexcluir);
            this.Controls.Add(this.btcancelar);
            this.Controls.Add(this.btsalvar);
            this.Controls.Add(this.btinserir);
            this.Controls.Add(bLOQUEADOLabel);
            this.Controls.Add(this.bLOQUEADOComboBox);
            this.Controls.Add(lOGINLabel);
            this.Controls.Add(this.lOGINTextBox);
            this.Controls.Add(sENHALabel);
            this.Controls.Add(this.sENHATextBox);
            this.Controls.Add(fUNCAOLabel);
            this.Controls.Add(this.fUNCAOComboBox);
            this.Name = "frusuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "Cadastros de usuario";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frusuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sistemaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private sistemaDataSet sistemaDataSet;
        private System.Windows.Forms.BindingSource usuarioBindingSource;
        private sistemaDataSetTableAdapters.usuarioTableAdapter usuarioTableAdapter;
        private sistemaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox lOGINTextBox;
        private System.Windows.Forms.TextBox sENHATextBox;
        private System.Windows.Forms.ComboBox fUNCAOComboBox;
        private System.Windows.Forms.ComboBox bLOQUEADOComboBox;
        private System.Windows.Forms.Button btsair2;
        private System.Windows.Forms.Button btexcluir;
        private System.Windows.Forms.Button btcancelar;
        private System.Windows.Forms.Button btsalvar;
        private System.Windows.Forms.Button btinserir;
        private System.Windows.Forms.DataGridView usuarioDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.TextBox textid;
        private System.Windows.Forms.ListView listView1;
    }
}