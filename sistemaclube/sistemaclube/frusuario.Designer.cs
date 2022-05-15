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
            System.Windows.Forms.Label iD_USUARIOLabel;
            System.Windows.Forms.Label lOGINLabel;
            System.Windows.Forms.Label sENHALabel;
            System.Windows.Forms.Label fUNCAOLabel;
            System.Windows.Forms.Label bLOQUEADOLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frusuario));
            this.sistemaDataSet = new sistemaclube.sistemaDataSet();
            this.usuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usuarioTableAdapter = new sistemaclube.sistemaDataSetTableAdapters.usuarioTableAdapter();
            this.tableAdapterManager = new sistemaclube.sistemaDataSetTableAdapters.TableAdapterManager();
            this.usuarioBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.usuarioBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.iD_USUARIOTextBox = new System.Windows.Forms.TextBox();
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
            iD_USUARIOLabel = new System.Windows.Forms.Label();
            lOGINLabel = new System.Windows.Forms.Label();
            sENHALabel = new System.Windows.Forms.Label();
            fUNCAOLabel = new System.Windows.Forms.Label();
            bLOQUEADOLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.sistemaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingNavigator)).BeginInit();
            this.usuarioBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // iD_USUARIOLabel
            // 
            iD_USUARIOLabel.AutoSize = true;
            iD_USUARIOLabel.Location = new System.Drawing.Point(42, 31);
            iD_USUARIOLabel.Name = "iD_USUARIOLabel";
            iD_USUARIOLabel.Size = new System.Drawing.Size(73, 13);
            iD_USUARIOLabel.TabIndex = 1;
            iD_USUARIOLabel.Text = "ID USUARIO:";
            // 
            // lOGINLabel
            // 
            lOGINLabel.AutoSize = true;
            lOGINLabel.Location = new System.Drawing.Point(42, 74);
            lOGINLabel.Name = "lOGINLabel";
            lOGINLabel.Size = new System.Drawing.Size(43, 13);
            lOGINLabel.TabIndex = 3;
            lOGINLabel.Text = "LOGIN:";
            // 
            // sENHALabel
            // 
            sENHALabel.AutoSize = true;
            sENHALabel.Location = new System.Drawing.Point(42, 118);
            sENHALabel.Name = "sENHALabel";
            sENHALabel.Size = new System.Drawing.Size(47, 13);
            sENHALabel.TabIndex = 5;
            sENHALabel.Text = "SENHA:";
            // 
            // fUNCAOLabel
            // 
            fUNCAOLabel.AutoSize = true;
            fUNCAOLabel.Location = new System.Drawing.Point(42, 207);
            fUNCAOLabel.Name = "fUNCAOLabel";
            fUNCAOLabel.Size = new System.Drawing.Size(54, 13);
            fUNCAOLabel.TabIndex = 9;
            fUNCAOLabel.Text = "FUNCAO:";
            // 
            // bLOQUEADOLabel
            // 
            bLOQUEADOLabel.AutoSize = true;
            bLOQUEADOLabel.Location = new System.Drawing.Point(42, 163);
            bLOQUEADOLabel.Name = "bLOQUEADOLabel";
            bLOQUEADOLabel.Size = new System.Drawing.Size(77, 13);
            bLOQUEADOLabel.TabIndex = 10;
            bLOQUEADOLabel.Text = "BLOQUEADO:";
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
            // usuarioBindingNavigator
            // 
            this.usuarioBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.usuarioBindingNavigator.BindingSource = this.usuarioBindingSource;
            this.usuarioBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.usuarioBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.usuarioBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.usuarioBindingNavigatorSaveItem});
            this.usuarioBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.usuarioBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.usuarioBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.usuarioBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.usuarioBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.usuarioBindingNavigator.Name = "usuarioBindingNavigator";
            this.usuarioBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.usuarioBindingNavigator.Size = new System.Drawing.Size(1357, 25);
            this.usuarioBindingNavigator.TabIndex = 0;
            this.usuarioBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Adicionar novo";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de itens";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Excluir";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primeiro";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posição";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posição atual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Mover próximo";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // usuarioBindingNavigatorSaveItem
            // 
            this.usuarioBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.usuarioBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("usuarioBindingNavigatorSaveItem.Image")));
            this.usuarioBindingNavigatorSaveItem.Name = "usuarioBindingNavigatorSaveItem";
            this.usuarioBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.usuarioBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.usuarioBindingNavigatorSaveItem.Click += new System.EventHandler(this.usuarioBindingNavigatorSaveItem_Click);
            // 
            // iD_USUARIOTextBox
            // 
            this.iD_USUARIOTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "ID_USUARIO", true));
            this.iD_USUARIOTextBox.Location = new System.Drawing.Point(125, 28);
            this.iD_USUARIOTextBox.Name = "iD_USUARIOTextBox";
            this.iD_USUARIOTextBox.Size = new System.Drawing.Size(121, 20);
            this.iD_USUARIOTextBox.TabIndex = 2;
            // 
            // lOGINTextBox
            // 
            this.lOGINTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "LOGIN", true));
            this.lOGINTextBox.Location = new System.Drawing.Point(125, 71);
            this.lOGINTextBox.Name = "lOGINTextBox";
            this.lOGINTextBox.Size = new System.Drawing.Size(547, 20);
            this.lOGINTextBox.TabIndex = 4;
            // 
            // sENHATextBox
            // 
            this.sENHATextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "SENHA", true));
            this.sENHATextBox.Location = new System.Drawing.Point(125, 115);
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
            "Zelador(a)",
            "Usuario"});
            this.fUNCAOComboBox.Location = new System.Drawing.Point(125, 204);
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
            this.bLOQUEADOComboBox.Location = new System.Drawing.Point(125, 160);
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
            // 
            // btexcluir
            // 
            this.btexcluir.BackColor = System.Drawing.Color.Transparent;
            this.btexcluir.FlatAppearance.BorderColor = System.Drawing.Color.Green;
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
            // 
            // btcancelar
            // 
            this.btcancelar.BackColor = System.Drawing.Color.Transparent;
            this.btcancelar.FlatAppearance.BorderColor = System.Drawing.Color.Green;
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
            // 
            // btsalvar
            // 
            this.btsalvar.BackColor = System.Drawing.Color.Transparent;
            this.btsalvar.FlatAppearance.BorderColor = System.Drawing.Color.Green;
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
            // 
            // btinserir
            // 
            this.btinserir.BackColor = System.Drawing.Color.Transparent;
            this.btinserir.FlatAppearance.BorderColor = System.Drawing.Color.Green;
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
            this.usuarioDataGridView.Location = new System.Drawing.Point(45, 270);
            this.usuarioDataGridView.Name = "usuarioDataGridView";
            this.usuarioDataGridView.ReadOnly = true;
            this.usuarioDataGridView.Size = new System.Drawing.Size(1266, 292);
            this.usuarioDataGridView.TabIndex = 28;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID_USUARIO";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID_USUARIO";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "LOGIN";
            this.dataGridViewTextBoxColumn2.HeaderText = "LOGIN";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "SENHA";
            this.dataGridViewTextBoxColumn3.HeaderText = "SENHA";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "BLOQUEADO";
            this.dataGridViewTextBoxColumn4.HeaderText = "BLOQUEADO";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "FUNCAO";
            this.dataGridViewTextBoxColumn5.HeaderText = "FUNCAO";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // frusuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::sistemaclube.Properties.Resources.Clube_de_tênis_fundo;
            this.ClientSize = new System.Drawing.Size(1357, 647);
            this.Controls.Add(this.usuarioDataGridView);
            this.Controls.Add(this.btsair2);
            this.Controls.Add(this.btexcluir);
            this.Controls.Add(this.btcancelar);
            this.Controls.Add(this.btsalvar);
            this.Controls.Add(this.btinserir);
            this.Controls.Add(bLOQUEADOLabel);
            this.Controls.Add(this.bLOQUEADOComboBox);
            this.Controls.Add(iD_USUARIOLabel);
            this.Controls.Add(this.iD_USUARIOTextBox);
            this.Controls.Add(lOGINLabel);
            this.Controls.Add(this.lOGINTextBox);
            this.Controls.Add(sENHALabel);
            this.Controls.Add(this.sENHATextBox);
            this.Controls.Add(fUNCAOLabel);
            this.Controls.Add(this.fUNCAOComboBox);
            this.Controls.Add(this.usuarioBindingNavigator);
            this.Name = "frusuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "Cadastros de usuario";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frusuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sistemaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingNavigator)).EndInit();
            this.usuarioBindingNavigator.ResumeLayout(false);
            this.usuarioBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private sistemaDataSet sistemaDataSet;
        private System.Windows.Forms.BindingSource usuarioBindingSource;
        private sistemaDataSetTableAdapters.usuarioTableAdapter usuarioTableAdapter;
        private sistemaDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator usuarioBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton usuarioBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox iD_USUARIOTextBox;
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
    }
}