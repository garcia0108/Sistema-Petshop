namespace PrjPetShop_2
{
    partial class frmCadServico
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
            System.Windows.Forms.Label serv_codigoLabel;
            System.Windows.Forms.Label serv_descricaoLabel;
            System.Windows.Forms.Label serv_precoLabel1;
            System.Windows.Forms.Label serv_tempoLabel;
            this.gpbServico = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.serv_tempoTextBox = new System.Windows.Forms.TextBox();
            this.servicoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.masterDataSet = new PrjPetShop_2.masterDataSet();
            this.serv_precoTextBox = new System.Windows.Forms.TextBox();
            this.serv_codigoLabel1 = new System.Windows.Forms.Label();
            this.serv_descricaoTextBox = new System.Windows.Forms.TextBox();
            this.servicoTableAdapter = new PrjPetShop_2.masterDataSetTableAdapters.servicoTableAdapter();
            this.tableAdapterManager = new PrjPetShop_2.masterDataSetTableAdapters.TableAdapterManager();
            this.servicoBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.servicoBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.btnEditar = new System.Windows.Forms.ToolStripButton();
            this.btnCancelar = new System.Windows.Forms.ToolStripButton();
            serv_codigoLabel = new System.Windows.Forms.Label();
            serv_descricaoLabel = new System.Windows.Forms.Label();
            serv_precoLabel1 = new System.Windows.Forms.Label();
            serv_tempoLabel = new System.Windows.Forms.Label();
            this.gpbServico.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.servicoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicoBindingNavigator)).BeginInit();
            this.servicoBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // serv_codigoLabel
            // 
            serv_codigoLabel.AutoSize = true;
            serv_codigoLabel.Location = new System.Drawing.Point(21, 59);
            serv_codigoLabel.Name = "serv_codigoLabel";
            serv_codigoLabel.Size = new System.Drawing.Size(96, 28);
            serv_codigoLabel.TabIndex = 0;
            serv_codigoLabel.Text = "Código:";
            // 
            // serv_descricaoLabel
            // 
            serv_descricaoLabel.AutoSize = true;
            serv_descricaoLabel.Location = new System.Drawing.Point(21, 187);
            serv_descricaoLabel.Name = "serv_descricaoLabel";
            serv_descricaoLabel.Size = new System.Drawing.Size(132, 28);
            serv_descricaoLabel.TabIndex = 2;
            serv_descricaoLabel.Text = "Descricao:";
            // 
            // serv_precoLabel1
            // 
            serv_precoLabel1.AutoSize = true;
            serv_precoLabel1.Location = new System.Drawing.Point(21, 103);
            serv_precoLabel1.Name = "serv_precoLabel1";
            serv_precoLabel1.Size = new System.Drawing.Size(84, 28);
            serv_precoLabel1.TabIndex = 7;
            serv_precoLabel1.Text = "Preço:";
            // 
            // serv_tempoLabel
            // 
            serv_tempoLabel.AutoSize = true;
            serv_tempoLabel.Location = new System.Drawing.Point(21, 143);
            serv_tempoLabel.Name = "serv_tempoLabel";
            serv_tempoLabel.Size = new System.Drawing.Size(84, 28);
            serv_tempoLabel.TabIndex = 8;
            serv_tempoLabel.Text = "Tempo:";
            // 
            // gpbServico
            // 
            this.gpbServico.Controls.Add(this.label2);
            this.gpbServico.Controls.Add(this.label1);
            this.gpbServico.Controls.Add(serv_tempoLabel);
            this.gpbServico.Controls.Add(this.serv_tempoTextBox);
            this.gpbServico.Controls.Add(serv_precoLabel1);
            this.gpbServico.Controls.Add(this.serv_precoTextBox);
            this.gpbServico.Controls.Add(serv_codigoLabel);
            this.gpbServico.Controls.Add(this.serv_codigoLabel1);
            this.gpbServico.Controls.Add(serv_descricaoLabel);
            this.gpbServico.Controls.Add(this.serv_descricaoTextBox);
            this.gpbServico.Enabled = false;
            this.gpbServico.Font = new System.Drawing.Font("Cascadia Mono", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbServico.Location = new System.Drawing.Point(31, 52);
            this.gpbServico.Name = "gpbServico";
            this.gpbServico.Size = new System.Drawing.Size(661, 378);
            this.gpbServico.TabIndex = 0;
            this.gpbServico.TabStop = false;
            this.gpbServico.Text = "Serviços realizados";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(324, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 28);
            this.label2.TabIndex = 11;
            this.label2.Text = "minutos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(129, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 28);
            this.label1.TabIndex = 10;
            this.label1.Text = "R$";
            // 
            // serv_tempoTextBox
            // 
            this.serv_tempoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.servicoBindingSource, "serv_tempo", true));
            this.serv_tempoTextBox.Location = new System.Drawing.Point(171, 143);
            this.serv_tempoTextBox.Name = "serv_tempoTextBox";
            this.serv_tempoTextBox.Size = new System.Drawing.Size(147, 32);
            this.serv_tempoTextBox.TabIndex = 9;
            // 
            // servicoBindingSource
            // 
            this.servicoBindingSource.DataMember = "servico";
            this.servicoBindingSource.DataSource = this.masterDataSet;
            // 
            // masterDataSet
            // 
            this.masterDataSet.DataSetName = "masterDataSet";
            this.masterDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // serv_precoTextBox
            // 
            this.serv_precoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.servicoBindingSource, "serv_preco", true));
            this.serv_precoTextBox.Location = new System.Drawing.Point(171, 99);
            this.serv_precoTextBox.Name = "serv_precoTextBox";
            this.serv_precoTextBox.Size = new System.Drawing.Size(147, 32);
            this.serv_precoTextBox.TabIndex = 8;
            // 
            // serv_codigoLabel1
            // 
            this.serv_codigoLabel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.serv_codigoLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.servicoBindingSource, "serv_codigo", true));
            this.serv_codigoLabel1.Location = new System.Drawing.Point(171, 50);
            this.serv_codigoLabel1.Name = "serv_codigoLabel1";
            this.serv_codigoLabel1.Size = new System.Drawing.Size(110, 37);
            this.serv_codigoLabel1.TabIndex = 1;
            // 
            // serv_descricaoTextBox
            // 
            this.serv_descricaoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.servicoBindingSource, "serv_descricao", true));
            this.serv_descricaoTextBox.Location = new System.Drawing.Point(171, 187);
            this.serv_descricaoTextBox.MaxLength = 150;
            this.serv_descricaoTextBox.Multiline = true;
            this.serv_descricaoTextBox.Name = "serv_descricaoTextBox";
            this.serv_descricaoTextBox.Size = new System.Drawing.Size(379, 168);
            this.serv_descricaoTextBox.TabIndex = 3;
            // 
            // servicoTableAdapter
            // 
            this.servicoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.agendamento_servicoTableAdapter = null;
            this.tableAdapterManager.agendamentoTableAdapter = null;
            this.tableAdapterManager.animalTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClienteTableAdapter = null;
            this.tableAdapterManager.racaTableAdapter = null;
            this.tableAdapterManager.servicoTableAdapter = this.servicoTableAdapter;
            this.tableAdapterManager.UpdateOrder = PrjPetShop_2.masterDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // servicoBindingNavigator
            // 
            this.servicoBindingNavigator.AddNewItem = null;
            this.servicoBindingNavigator.BackColor = System.Drawing.Color.Transparent;
            this.servicoBindingNavigator.BindingSource = this.servicoBindingSource;
            this.servicoBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.servicoBindingNavigator.DeleteItem = null;
            this.servicoBindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
            this.servicoBindingNavigator.ImageScalingSize = new System.Drawing.Size(35, 35);
            this.servicoBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.servicoBindingNavigatorSaveItem,
            this.btnEditar,
            this.btnCancelar});
            this.servicoBindingNavigator.Location = new System.Drawing.Point(118, 7);
            this.servicoBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.servicoBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.servicoBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.servicoBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.servicoBindingNavigator.Name = "servicoBindingNavigator";
            this.servicoBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.servicoBindingNavigator.Size = new System.Drawing.Size(501, 42);
            this.servicoBindingNavigator.TabIndex = 1;
            this.servicoBindingNavigator.Text = "bindingNavigator1";
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
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = global::PrjPetShop_2.Properties.Resources.lixo;
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(39, 39);
            this.bindingNavigatorDeleteItem.Text = "Excluir";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // servicoBindingNavigatorSaveItem
            // 
            this.servicoBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.servicoBindingNavigatorSaveItem.Image = global::PrjPetShop_2.Properties.Resources.salvar;
            this.servicoBindingNavigatorSaveItem.Name = "servicoBindingNavigatorSaveItem";
            this.servicoBindingNavigatorSaveItem.Size = new System.Drawing.Size(39, 39);
            this.servicoBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.servicoBindingNavigatorSaveItem.Click += new System.EventHandler(this.servicoBindingNavigatorSaveItem_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnEditar.Image = global::PrjPetShop_2.Properties.Resources.editar2;
            this.btnEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(39, 39);
            this.btnEditar.Text = "Editar";
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnCancelar.Image = global::PrjPetShop_2.Properties.Resources.cancelar1;
            this.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(39, 39);
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // frmCadServico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleVioletRed;
            this.ClientSize = new System.Drawing.Size(744, 502);
            this.Controls.Add(this.servicoBindingNavigator);
            this.Controls.Add(this.gpbServico);
            this.Font = new System.Drawing.Font("Cascadia Mono", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCadServico";
            this.Text = "frmCadServico";
            this.Load += new System.EventHandler(this.frmCadServico_Load);
            this.gpbServico.ResumeLayout(false);
            this.gpbServico.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.servicoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicoBindingNavigator)).EndInit();
            this.servicoBindingNavigator.ResumeLayout(false);
            this.servicoBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbServico;
        private masterDataSet masterDataSet;
        private System.Windows.Forms.BindingSource servicoBindingSource;
        private masterDataSetTableAdapters.servicoTableAdapter servicoTableAdapter;
        private masterDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator servicoBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton servicoBindingNavigatorSaveItem;
        private System.Windows.Forms.Label serv_codigoLabel1;
        private System.Windows.Forms.TextBox serv_descricaoTextBox;
        private System.Windows.Forms.ToolStripButton btnEditar;
        private System.Windows.Forms.ToolStripButton btnCancelar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox serv_tempoTextBox;
        private System.Windows.Forms.TextBox serv_precoTextBox;
        private System.Windows.Forms.Label label2;
    }
}