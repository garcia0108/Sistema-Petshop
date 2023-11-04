namespace PrjPetShop_2
{
    partial class frmCadAgendamento
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
            System.Windows.Forms.Label ag_dataLabel;
            System.Windows.Forms.Label ag_horarioLabel;
            System.Windows.Forms.Label ag_situacaoLabel;
            System.Windows.Forms.Label ag_animalLabel;
            System.Windows.Forms.Label ag_totalLabel;
            System.Windows.Forms.Label ag_codigoLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gpbAgendamento = new System.Windows.Forms.GroupBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.ag_codigoTextBox = new System.Windows.Forms.TextBox();
            this.agendamentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.masterDataSet = new PrjPetShop_2.masterDataSet();
            this.ani_fotoPictureBox = new System.Windows.Forms.PictureBox();
            this.animalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ag_dataMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.ag_horarioMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.ag_situacaoComboBox = new System.Windows.Forms.ComboBox();
            this.ag_animalComboBox = new System.Windows.Forms.ComboBox();
            this.ag_totalTextBox = new System.Windows.Forms.TextBox();
            this.gpbServico = new System.Windows.Forms.GroupBox();
            this.txtCodServ = new System.Windows.Forms.MaskedTextBox();
            this.txtServico = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddServico = new System.Windows.Forms.Button();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.txtQtd = new System.Windows.Forms.TextBox();
            this.view_AgendamentoServicoDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.view_AgendamentoServicoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.agendamento_servicoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.agendamentoTableAdapter = new PrjPetShop_2.masterDataSetTableAdapters.agendamentoTableAdapter();
            this.tableAdapterManager = new PrjPetShop_2.masterDataSetTableAdapters.TableAdapterManager();
            this.animalTableAdapter = new PrjPetShop_2.masterDataSetTableAdapters.animalTableAdapter();
            this.agendamento_servicoTableAdapter = new PrjPetShop_2.masterDataSetTableAdapters.agendamento_servicoTableAdapter();
            this.view_AgendamentoServicoTableAdapter = new PrjPetShop_2.masterDataSetTableAdapters.View_AgendamentoServicoTableAdapter();
            this.agendamentoBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.racaBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.btnEditar = new System.Windows.Forms.ToolStripButton();
            this.btnCancelar = new System.Windows.Forms.ToolStripButton();
            this.btnFinalizar = new System.Windows.Forms.ToolStripButton();
            this.masterDataSet1 = new PrjPetShop_2.masterDataSet();
            this.servicoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.servicoTableAdapter = new PrjPetShop_2.masterDataSetTableAdapters.servicoTableAdapter();
            this.view_TotalServicoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.view_TotalServicoTableAdapter = new PrjPetShop_2.masterDataSetTableAdapters.View_TotalServicoTableAdapter();
            ag_dataLabel = new System.Windows.Forms.Label();
            ag_horarioLabel = new System.Windows.Forms.Label();
            ag_situacaoLabel = new System.Windows.Forms.Label();
            ag_animalLabel = new System.Windows.Forms.Label();
            ag_totalLabel = new System.Windows.Forms.Label();
            ag_codigoLabel = new System.Windows.Forms.Label();
            this.gpbAgendamento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.agendamentoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ani_fotoPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.animalBindingSource)).BeginInit();
            this.gpbServico.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.view_AgendamentoServicoDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_AgendamentoServicoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agendamento_servicoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agendamentoBindingNavigator)).BeginInit();
            this.agendamentoBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_TotalServicoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ag_dataLabel
            // 
            ag_dataLabel.AutoSize = true;
            ag_dataLabel.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ag_dataLabel.Location = new System.Drawing.Point(117, 27);
            ag_dataLabel.Name = "ag_dataLabel";
            ag_dataLabel.Size = new System.Drawing.Size(43, 17);
            ag_dataLabel.TabIndex = 2;
            ag_dataLabel.Text = "Data:";
            // 
            // ag_horarioLabel
            // 
            ag_horarioLabel.AutoSize = true;
            ag_horarioLabel.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ag_horarioLabel.Location = new System.Drawing.Point(251, 27);
            ag_horarioLabel.Name = "ag_horarioLabel";
            ag_horarioLabel.Size = new System.Drawing.Size(59, 17);
            ag_horarioLabel.TabIndex = 4;
            ag_horarioLabel.Text = "Horário:";
            // 
            // ag_situacaoLabel
            // 
            ag_situacaoLabel.AutoSize = true;
            ag_situacaoLabel.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ag_situacaoLabel.Location = new System.Drawing.Point(351, 27);
            ag_situacaoLabel.Name = "ag_situacaoLabel";
            ag_situacaoLabel.Size = new System.Drawing.Size(69, 17);
            ag_situacaoLabel.TabIndex = 6;
            ag_situacaoLabel.Text = "Situacao:";
            // 
            // ag_animalLabel
            // 
            ag_animalLabel.AutoSize = true;
            ag_animalLabel.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ag_animalLabel.Location = new System.Drawing.Point(31, 100);
            ag_animalLabel.Name = "ag_animalLabel";
            ag_animalLabel.Size = new System.Drawing.Size(56, 17);
            ag_animalLabel.TabIndex = 8;
            ag_animalLabel.Text = "Animal:";
            // 
            // ag_totalLabel
            // 
            ag_totalLabel.AutoSize = true;
            ag_totalLabel.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ag_totalLabel.Location = new System.Drawing.Point(608, 27);
            ag_totalLabel.Name = "ag_totalLabel";
            ag_totalLabel.Size = new System.Drawing.Size(42, 17);
            ag_totalLabel.TabIndex = 10;
            ag_totalLabel.Text = "Total:";
            // 
            // ag_codigoLabel
            // 
            ag_codigoLabel.AutoSize = true;
            ag_codigoLabel.Location = new System.Drawing.Point(13, 27);
            ag_codigoLabel.Name = "ag_codigoLabel";
            ag_codigoLabel.Size = new System.Drawing.Size(58, 17);
            ag_codigoLabel.TabIndex = 13;
            ag_codigoLabel.Text = "Código:";
            // 
            // gpbAgendamento
            // 
            this.gpbAgendamento.Controls.Add(this.btnPesquisar);
            this.gpbAgendamento.Controls.Add(ag_codigoLabel);
            this.gpbAgendamento.Controls.Add(this.ag_codigoTextBox);
            this.gpbAgendamento.Controls.Add(this.ani_fotoPictureBox);
            this.gpbAgendamento.Controls.Add(ag_dataLabel);
            this.gpbAgendamento.Controls.Add(this.ag_dataMaskedTextBox);
            this.gpbAgendamento.Controls.Add(ag_horarioLabel);
            this.gpbAgendamento.Controls.Add(this.ag_horarioMaskedTextBox);
            this.gpbAgendamento.Controls.Add(ag_situacaoLabel);
            this.gpbAgendamento.Controls.Add(this.ag_situacaoComboBox);
            this.gpbAgendamento.Controls.Add(ag_animalLabel);
            this.gpbAgendamento.Controls.Add(this.ag_animalComboBox);
            this.gpbAgendamento.Controls.Add(ag_totalLabel);
            this.gpbAgendamento.Controls.Add(this.ag_totalTextBox);
            this.gpbAgendamento.Enabled = false;
            this.gpbAgendamento.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbAgendamento.Location = new System.Drawing.Point(12, 45);
            this.gpbAgendamento.Name = "gpbAgendamento";
            this.gpbAgendamento.Size = new System.Drawing.Size(706, 189);
            this.gpbAgendamento.TabIndex = 0;
            this.gpbAgendamento.TabStop = false;
            this.gpbAgendamento.Text = "Dados dos Agendamentos";
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Image = global::PrjPetShop_2.Properties.Resources.lupa__1_;
            this.btnPesquisar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPesquisar.Location = new System.Drawing.Point(201, 151);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(98, 31);
            this.btnPesquisar.TabIndex = 15;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // ag_codigoTextBox
            // 
            this.ag_codigoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agendamentoBindingSource, "ag_codigo", true));
            this.ag_codigoTextBox.Enabled = false;
            this.ag_codigoTextBox.Location = new System.Drawing.Point(16, 54);
            this.ag_codigoTextBox.Name = "ag_codigoTextBox";
            this.ag_codigoTextBox.Size = new System.Drawing.Size(93, 25);
            this.ag_codigoTextBox.TabIndex = 14;
            this.ag_codigoTextBox.TextChanged += new System.EventHandler(this.ag_codigoTextBox_TextChanged);
            // 
            // agendamentoBindingSource
            // 
            this.agendamentoBindingSource.DataMember = "agendamento";
            this.agendamentoBindingSource.DataSource = this.masterDataSet;
            this.agendamentoBindingSource.PositionChanged += new System.EventHandler(this.agendamentoBindingSource_PositionChanged);
            // 
            // masterDataSet
            // 
            this.masterDataSet.DataSetName = "masterDataSet";
            this.masterDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ani_fotoPictureBox
            // 
            this.ani_fotoPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.animalBindingSource, "ani_foto", true));
            this.ani_fotoPictureBox.Location = new System.Drawing.Point(318, 85);
            this.ani_fotoPictureBox.Name = "ani_fotoPictureBox";
            this.ani_fotoPictureBox.Size = new System.Drawing.Size(100, 97);
            this.ani_fotoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ani_fotoPictureBox.TabIndex = 13;
            this.ani_fotoPictureBox.TabStop = false;
            // 
            // animalBindingSource
            // 
            this.animalBindingSource.DataMember = "animal";
            this.animalBindingSource.DataSource = this.masterDataSet;
            // 
            // ag_dataMaskedTextBox
            // 
            this.ag_dataMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agendamentoBindingSource, "ag_data", true));
            this.ag_dataMaskedTextBox.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ag_dataMaskedTextBox.Location = new System.Drawing.Point(122, 54);
            this.ag_dataMaskedTextBox.Mask = "00/00/0000";
            this.ag_dataMaskedTextBox.Name = "ag_dataMaskedTextBox";
            this.ag_dataMaskedTextBox.Size = new System.Drawing.Size(121, 25);
            this.ag_dataMaskedTextBox.TabIndex = 3;
            this.ag_dataMaskedTextBox.ValidatingType = typeof(System.DateTime);
            // 
            // ag_horarioMaskedTextBox
            // 
            this.ag_horarioMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agendamentoBindingSource, "ag_horario", true));
            this.ag_horarioMaskedTextBox.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ag_horarioMaskedTextBox.Location = new System.Drawing.Point(256, 54);
            this.ag_horarioMaskedTextBox.Mask = "00:00";
            this.ag_horarioMaskedTextBox.Name = "ag_horarioMaskedTextBox";
            this.ag_horarioMaskedTextBox.Size = new System.Drawing.Size(89, 25);
            this.ag_horarioMaskedTextBox.TabIndex = 5;
            this.ag_horarioMaskedTextBox.ValidatingType = typeof(System.DateTime);
            // 
            // ag_situacaoComboBox
            // 
            this.ag_situacaoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agendamentoBindingSource, "ag_situacao", true));
            this.ag_situacaoComboBox.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ag_situacaoComboBox.FormattingEnabled = true;
            this.ag_situacaoComboBox.Items.AddRange(new object[] {
            "Agendado",
            "Em Andamento",
            "Finalizado"});
            this.ag_situacaoComboBox.Location = new System.Drawing.Point(356, 54);
            this.ag_situacaoComboBox.Name = "ag_situacaoComboBox";
            this.ag_situacaoComboBox.Size = new System.Drawing.Size(216, 25);
            this.ag_situacaoComboBox.TabIndex = 7;
            // 
            // ag_animalComboBox
            // 
            this.ag_animalComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.agendamentoBindingSource, "ag_animal", true));
            this.ag_animalComboBox.DataSource = this.animalBindingSource;
            this.ag_animalComboBox.DisplayMember = "ani_nome";
            this.ag_animalComboBox.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ag_animalComboBox.FormattingEnabled = true;
            this.ag_animalComboBox.Location = new System.Drawing.Point(27, 120);
            this.ag_animalComboBox.Name = "ag_animalComboBox";
            this.ag_animalComboBox.Size = new System.Drawing.Size(272, 25);
            this.ag_animalComboBox.TabIndex = 9;
            this.ag_animalComboBox.ValueMember = "ani_codigo";
            // 
            // ag_totalTextBox
            // 
            this.ag_totalTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agendamentoBindingSource, "ag_total", true));
            this.ag_totalTextBox.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ag_totalTextBox.Location = new System.Drawing.Point(613, 54);
            this.ag_totalTextBox.Name = "ag_totalTextBox";
            this.ag_totalTextBox.Size = new System.Drawing.Size(73, 25);
            this.ag_totalTextBox.TabIndex = 11;
            // 
            // gpbServico
            // 
            this.gpbServico.Controls.Add(this.txtCodServ);
            this.gpbServico.Controls.Add(this.txtServico);
            this.gpbServico.Controls.Add(this.label4);
            this.gpbServico.Controls.Add(this.label3);
            this.gpbServico.Controls.Add(this.label2);
            this.gpbServico.Controls.Add(this.label1);
            this.gpbServico.Controls.Add(this.btnAddServico);
            this.gpbServico.Controls.Add(this.txtValor);
            this.gpbServico.Controls.Add(this.txtQtd);
            this.gpbServico.Controls.Add(this.view_AgendamentoServicoDataGridView);
            this.gpbServico.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbServico.Location = new System.Drawing.Point(12, 228);
            this.gpbServico.Name = "gpbServico";
            this.gpbServico.Size = new System.Drawing.Size(706, 281);
            this.gpbServico.TabIndex = 1;
            this.gpbServico.TabStop = false;
            this.gpbServico.Text = "Serviços";
            // 
            // txtCodServ
            // 
            this.txtCodServ.Location = new System.Drawing.Point(9, 53);
            this.txtCodServ.Mask = "000";
            this.txtCodServ.Name = "txtCodServ";
            this.txtCodServ.Size = new System.Drawing.Size(100, 25);
            this.txtCodServ.TabIndex = 7;
            this.txtCodServ.ValidatingType = typeof(int);
            this.txtCodServ.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCodServ_KeyDown);
            // 
            // txtServico
            // 
            this.txtServico.Location = new System.Drawing.Point(120, 53);
            this.txtServico.Name = "txtServico";
            this.txtServico.Size = new System.Drawing.Size(255, 25);
            this.txtServico.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(528, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Valor:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(389, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Quantidade:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(128, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Descrição:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Código:";
            // 
            // btnAddServico
            // 
            this.btnAddServico.Location = new System.Drawing.Point(653, 43);
            this.btnAddServico.Name = "btnAddServico";
            this.btnAddServico.Size = new System.Drawing.Size(45, 36);
            this.btnAddServico.TabIndex = 3;
            this.btnAddServico.Text = "+";
            this.btnAddServico.UseVisualStyleBackColor = true;
            this.btnAddServico.Click += new System.EventHandler(this.btnAddServico_Click);
            // 
            // txtValor
            // 
            this.txtValor.Location = new System.Drawing.Point(528, 53);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(100, 25);
            this.txtValor.TabIndex = 1;
            this.txtValor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtValor_KeyDown);
            // 
            // txtQtd
            // 
            this.txtQtd.Location = new System.Drawing.Point(392, 53);
            this.txtQtd.Name = "txtQtd";
            this.txtQtd.Size = new System.Drawing.Size(114, 25);
            this.txtQtd.TabIndex = 1;
            this.txtQtd.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtQtd_KeyDown);
            // 
            // view_AgendamentoServicoDataGridView
            // 
            this.view_AgendamentoServicoDataGridView.AllowUserToAddRows = false;
            this.view_AgendamentoServicoDataGridView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            this.view_AgendamentoServicoDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.view_AgendamentoServicoDataGridView.AutoGenerateColumns = false;
            this.view_AgendamentoServicoDataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.view_AgendamentoServicoDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.view_AgendamentoServicoDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.view_AgendamentoServicoDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.view_AgendamentoServicoDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.view_AgendamentoServicoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.view_AgendamentoServicoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.view_AgendamentoServicoDataGridView.DataSource = this.view_AgendamentoServicoBindingSource;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Pink;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Cascadia Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Plum;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.view_AgendamentoServicoDataGridView.DefaultCellStyle = dataGridViewCellStyle5;
            this.view_AgendamentoServicoDataGridView.EnableHeadersVisualStyles = false;
            this.view_AgendamentoServicoDataGridView.Location = new System.Drawing.Point(4, 85);
            this.view_AgendamentoServicoDataGridView.Name = "view_AgendamentoServicoDataGridView";
            this.view_AgendamentoServicoDataGridView.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.Empty;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Cascadia Mono", 10F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Empty;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Empty;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Empty;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.view_AgendamentoServicoDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.view_AgendamentoServicoDataGridView.RowHeadersVisible = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Cascadia Mono", 10F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            this.view_AgendamentoServicoDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle7;
            this.view_AgendamentoServicoDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.view_AgendamentoServicoDataGridView.Size = new System.Drawing.Size(694, 174);
            this.view_AgendamentoServicoDataGridView.TabIndex = 0;
            this.view_AgendamentoServicoDataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.view_AgendamentoServicoDataGridView_CellDoubleClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ag_serv_numero";
            this.dataGridViewTextBoxColumn1.HeaderText = "Número";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 87;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ag_serv_agendamento";
            this.dataGridViewTextBoxColumn2.HeaderText = "ag_serv_agendamento";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Visible = false;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "ag_serv_servico";
            this.dataGridViewTextBoxColumn3.HeaderText = "ag_serv_servico";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Visible = false;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "serv_descricao";
            this.dataGridViewTextBoxColumn4.HeaderText = "Descrição";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn5.DataPropertyName = "serv_tempo";
            this.dataGridViewTextBoxColumn5.HeaderText = "Tempo";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 78;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn6.DataPropertyName = "ag_serv_quantidade";
            this.dataGridViewTextBoxColumn6.HeaderText = "Qtd";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 60;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn7.DataPropertyName = "ag_serv_valor_unitario";
            dataGridViewCellStyle3.Format = "C2";
            dataGridViewCellStyle3.NullValue = null;
            this.dataGridViewTextBoxColumn7.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewTextBoxColumn7.HeaderText = "Valor Unitário";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 159;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.dataGridViewTextBoxColumn8.DataPropertyName = "SubTotal";
            dataGridViewCellStyle4.Format = "C2";
            dataGridViewCellStyle4.NullValue = null;
            this.dataGridViewTextBoxColumn8.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewTextBoxColumn8.HeaderText = "SubTotal";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Width = 105;
            // 
            // view_AgendamentoServicoBindingSource
            // 
            this.view_AgendamentoServicoBindingSource.DataMember = "View_AgendamentoServico";
            this.view_AgendamentoServicoBindingSource.DataSource = this.masterDataSet;
            // 
            // agendamento_servicoBindingSource
            // 
            this.agendamento_servicoBindingSource.DataMember = "agendamento_servico";
            this.agendamento_servicoBindingSource.DataSource = this.masterDataSet;
            // 
            // agendamentoTableAdapter
            // 
            this.agendamentoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.agendamento_servicoTableAdapter = null;
            this.tableAdapterManager.agendamentoTableAdapter = this.agendamentoTableAdapter;
            this.tableAdapterManager.animalTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClienteTableAdapter = null;
            this.tableAdapterManager.racaTableAdapter = null;
            this.tableAdapterManager.servicoTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = PrjPetShop_2.masterDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // animalTableAdapter
            // 
            this.animalTableAdapter.ClearBeforeFill = true;
            // 
            // agendamento_servicoTableAdapter
            // 
            this.agendamento_servicoTableAdapter.ClearBeforeFill = true;
            // 
            // view_AgendamentoServicoTableAdapter
            // 
            this.view_AgendamentoServicoTableAdapter.ClearBeforeFill = true;
            // 
            // agendamentoBindingNavigator
            // 
            this.agendamentoBindingNavigator.AddNewItem = null;
            this.agendamentoBindingNavigator.BackColor = System.Drawing.Color.Transparent;
            this.agendamentoBindingNavigator.BindingSource = this.agendamentoBindingSource;
            this.agendamentoBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.agendamentoBindingNavigator.DeleteItem = null;
            this.agendamentoBindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
            this.agendamentoBindingNavigator.ImageScalingSize = new System.Drawing.Size(35, 35);
            this.agendamentoBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.racaBindingNavigatorSaveItem,
            this.btnEditar,
            this.btnCancelar,
            this.btnFinalizar});
            this.agendamentoBindingNavigator.Location = new System.Drawing.Point(102, 0);
            this.agendamentoBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.agendamentoBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.agendamentoBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.agendamentoBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.agendamentoBindingNavigator.Name = "agendamentoBindingNavigator";
            this.agendamentoBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.agendamentoBindingNavigator.Size = new System.Drawing.Size(509, 42);
            this.agendamentoBindingNavigator.TabIndex = 2;
            this.agendamentoBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 39);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de itens";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = global::PrjPetShop_2.Properties.Resources.para_tras;
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(39, 39);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primeiro";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = global::PrjPetShop_2.Properties.Resources.seta_esquerda;
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(39, 39);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 42);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posição";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posição atual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 42);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = global::PrjPetShop_2.Properties.Resources.vire_a_direita_2;
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(39, 39);
            this.bindingNavigatorMoveNextItem.Text = "Mover próximo";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = global::PrjPetShop_2.Properties.Resources.pular;
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(39, 39);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 42);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = global::PrjPetShop_2.Properties.Resources.botao_adicionar;
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(39, 39);
            this.bindingNavigatorAddNewItem.Text = "Adicionar novo";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click_1);
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = global::PrjPetShop_2.Properties.Resources.lixo;
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(39, 39);
            this.bindingNavigatorDeleteItem.Text = "Excluir";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click_1);
            // 
            // racaBindingNavigatorSaveItem
            // 
            this.racaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.racaBindingNavigatorSaveItem.Image = global::PrjPetShop_2.Properties.Resources.salvar;
            this.racaBindingNavigatorSaveItem.Name = "racaBindingNavigatorSaveItem";
            this.racaBindingNavigatorSaveItem.Size = new System.Drawing.Size(39, 39);
            this.racaBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.racaBindingNavigatorSaveItem.Click += new System.EventHandler(this.racaBindingNavigatorSaveItem_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnEditar.Image = global::PrjPetShop_2.Properties.Resources.editar2;
            this.btnEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(39, 39);
            this.btnEditar.Text = "Editar";
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click_1);
            // 
            // btnCancelar
            // 
            this.btnCancelar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnCancelar.Image = global::PrjPetShop_2.Properties.Resources.cancelar1;
            this.btnCancelar.ImageTransparentColor = System.Drawing.Color.PaleVioletRed;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(39, 39);
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click_1);
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnFinalizar.Image = global::PrjPetShop_2.Properties.Resources.verifica;
            this.btnFinalizar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(39, 39);
            this.btnFinalizar.Text = "Finalizar";
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // masterDataSet1
            // 
            this.masterDataSet1.DataSetName = "masterDataSet";
            this.masterDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // servicoBindingSource
            // 
            this.servicoBindingSource.DataMember = "servico";
            this.servicoBindingSource.DataSource = this.masterDataSet1;
            // 
            // servicoTableAdapter
            // 
            this.servicoTableAdapter.ClearBeforeFill = true;
            // 
            // view_TotalServicoBindingSource
            // 
            this.view_TotalServicoBindingSource.DataMember = "View_TotalServico";
            this.view_TotalServicoBindingSource.DataSource = this.masterDataSet;
            // 
            // view_TotalServicoTableAdapter
            // 
            this.view_TotalServicoTableAdapter.ClearBeforeFill = true;
            // 
            // frmCadAgendamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.PaleVioletRed;
            this.ClientSize = new System.Drawing.Size(761, 502);
            this.Controls.Add(this.agendamentoBindingNavigator);
            this.Controls.Add(this.gpbServico);
            this.Controls.Add(this.gpbAgendamento);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCadAgendamento";
            this.Text = "frmCadAgendamento";
            this.Load += new System.EventHandler(this.frmCadAgendamento_Load);
            this.gpbAgendamento.ResumeLayout(false);
            this.gpbAgendamento.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.agendamentoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ani_fotoPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.animalBindingSource)).EndInit();
            this.gpbServico.ResumeLayout(false);
            this.gpbServico.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.view_AgendamentoServicoDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_AgendamentoServicoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agendamento_servicoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agendamentoBindingNavigator)).EndInit();
            this.agendamentoBindingNavigator.ResumeLayout(false);
            this.agendamentoBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_TotalServicoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbAgendamento;
        private System.Windows.Forms.GroupBox gpbServico;
        private masterDataSet masterDataSet;
        private System.Windows.Forms.BindingSource agendamentoBindingSource;
        private masterDataSetTableAdapters.agendamentoTableAdapter agendamentoTableAdapter;
        private masterDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.MaskedTextBox ag_dataMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox ag_horarioMaskedTextBox;
        private System.Windows.Forms.ComboBox ag_situacaoComboBox;
        private System.Windows.Forms.ComboBox ag_animalComboBox;
        private System.Windows.Forms.TextBox ag_totalTextBox;
        private System.Windows.Forms.BindingSource animalBindingSource;
        private masterDataSetTableAdapters.animalTableAdapter animalTableAdapter;
        private System.Windows.Forms.PictureBox ani_fotoPictureBox;
        private System.Windows.Forms.BindingSource agendamento_servicoBindingSource;
        private masterDataSetTableAdapters.agendamento_servicoTableAdapter agendamento_servicoTableAdapter;
        private System.Windows.Forms.BindingSource view_AgendamentoServicoBindingSource;
        private masterDataSetTableAdapters.View_AgendamentoServicoTableAdapter view_AgendamentoServicoTableAdapter;
        private System.Windows.Forms.DataGridView view_AgendamentoServicoDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.BindingNavigator agendamentoBindingNavigator;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton racaBindingNavigatorSaveItem;
        private System.Windows.Forms.ToolStripButton btnEditar;
        private System.Windows.Forms.ToolStripButton btnCancelar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddServico;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.TextBox txtQtd;
        private masterDataSet masterDataSet1;
        private System.Windows.Forms.BindingSource servicoBindingSource;
        private masterDataSetTableAdapters.servicoTableAdapter servicoTableAdapter;
        private System.Windows.Forms.MaskedTextBox txtCodServ;
        private System.Windows.Forms.TextBox txtServico;
        private System.Windows.Forms.TextBox ag_codigoTextBox;
        private System.Windows.Forms.ToolStripButton btnFinalizar;
        private System.Windows.Forms.BindingSource view_TotalServicoBindingSource;
        private masterDataSetTableAdapters.View_TotalServicoTableAdapter view_TotalServicoTableAdapter;
        private System.Windows.Forms.Button btnPesquisar;
    }
}