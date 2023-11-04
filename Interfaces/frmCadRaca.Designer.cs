namespace PrjPetShop_2
{
    partial class frmCadRaca
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
            System.Windows.Forms.Label raca_codigoLabel;
            System.Windows.Forms.Label raca_nomeLabel;
            System.Windows.Forms.Label raca_pais_origemLabel;
            this.gpbRaca = new System.Windows.Forms.GroupBox();
            this.raca_codigoLabel1 = new System.Windows.Forms.Label();
            this.racaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.masterDataSet = new PrjPetShop_2.masterDataSet();
            this.raca_nomeTextBox = new System.Windows.Forms.TextBox();
            this.raca_pais_origemTextBox = new System.Windows.Forms.TextBox();
            this.racaTableAdapter = new PrjPetShop_2.masterDataSetTableAdapters.racaTableAdapter();
            this.tableAdapterManager = new PrjPetShop_2.masterDataSetTableAdapters.TableAdapterManager();
            this.racaBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            raca_codigoLabel = new System.Windows.Forms.Label();
            raca_nomeLabel = new System.Windows.Forms.Label();
            raca_pais_origemLabel = new System.Windows.Forms.Label();
            this.gpbRaca.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.racaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.racaBindingNavigator)).BeginInit();
            this.racaBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // raca_codigoLabel
            // 
            raca_codigoLabel.AutoSize = true;
            raca_codigoLabel.Font = new System.Drawing.Font("Cascadia Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            raca_codigoLabel.Location = new System.Drawing.Point(16, 74);
            raca_codigoLabel.Name = "raca_codigoLabel";
            raca_codigoLabel.Size = new System.Drawing.Size(89, 25);
            raca_codigoLabel.TabIndex = 0;
            raca_codigoLabel.Text = "Código:";
            // 
            // raca_nomeLabel
            // 
            raca_nomeLabel.AutoSize = true;
            raca_nomeLabel.Font = new System.Drawing.Font("Cascadia Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            raca_nomeLabel.Location = new System.Drawing.Point(16, 120);
            raca_nomeLabel.Name = "raca_nomeLabel";
            raca_nomeLabel.Size = new System.Drawing.Size(155, 25);
            raca_nomeLabel.TabIndex = 2;
            raca_nomeLabel.Text = "Nome da Raça:";
            // 
            // raca_pais_origemLabel
            // 
            raca_pais_origemLabel.AutoSize = true;
            raca_pais_origemLabel.Font = new System.Drawing.Font("Cascadia Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            raca_pais_origemLabel.Location = new System.Drawing.Point(16, 169);
            raca_pais_origemLabel.Name = "raca_pais_origemLabel";
            raca_pais_origemLabel.Size = new System.Drawing.Size(177, 25);
            raca_pais_origemLabel.TabIndex = 4;
            raca_pais_origemLabel.Text = "País de origem:";
            // 
            // gpbRaca
            // 
            this.gpbRaca.BackColor = System.Drawing.Color.PaleVioletRed;
            this.gpbRaca.Controls.Add(raca_codigoLabel);
            this.gpbRaca.Controls.Add(this.raca_codigoLabel1);
            this.gpbRaca.Controls.Add(raca_nomeLabel);
            this.gpbRaca.Controls.Add(this.raca_nomeTextBox);
            this.gpbRaca.Controls.Add(raca_pais_origemLabel);
            this.gpbRaca.Controls.Add(this.raca_pais_origemTextBox);
            this.gpbRaca.Enabled = false;
            this.gpbRaca.Font = new System.Drawing.Font("Cascadia Mono", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbRaca.Location = new System.Drawing.Point(33, 52);
            this.gpbRaca.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gpbRaca.Name = "gpbRaca";
            this.gpbRaca.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gpbRaca.Size = new System.Drawing.Size(677, 424);
            this.gpbRaca.TabIndex = 0;
            this.gpbRaca.TabStop = false;
            this.gpbRaca.Text = "Dados da raça";
            // 
            // raca_codigoLabel1
            // 
            this.raca_codigoLabel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.raca_codigoLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.racaBindingSource, "raca_codigo", true));
            this.raca_codigoLabel1.Font = new System.Drawing.Font("Cascadia Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.raca_codigoLabel1.Location = new System.Drawing.Point(198, 60);
            this.raca_codigoLabel1.Name = "raca_codigoLabel1";
            this.raca_codigoLabel1.Size = new System.Drawing.Size(100, 39);
            this.raca_codigoLabel1.TabIndex = 1;
            // 
            // racaBindingSource
            // 
            this.racaBindingSource.DataMember = "raca";
            this.racaBindingSource.DataSource = this.masterDataSet;
            // 
            // masterDataSet
            // 
            this.masterDataSet.DataSetName = "masterDataSet";
            this.masterDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // raca_nomeTextBox
            // 
            this.raca_nomeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.racaBindingSource, "raca_nome", true));
            this.raca_nomeTextBox.Font = new System.Drawing.Font("Cascadia Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.raca_nomeTextBox.Location = new System.Drawing.Point(198, 117);
            this.raca_nomeTextBox.Name = "raca_nomeTextBox";
            this.raca_nomeTextBox.Size = new System.Drawing.Size(360, 30);
            this.raca_nomeTextBox.TabIndex = 3;
            // 
            // raca_pais_origemTextBox
            // 
            this.raca_pais_origemTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.racaBindingSource, "raca_pais_origem", true));
            this.raca_pais_origemTextBox.Font = new System.Drawing.Font("Cascadia Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.raca_pais_origemTextBox.Location = new System.Drawing.Point(198, 163);
            this.raca_pais_origemTextBox.Name = "raca_pais_origemTextBox";
            this.raca_pais_origemTextBox.Size = new System.Drawing.Size(360, 30);
            this.raca_pais_origemTextBox.TabIndex = 5;
            // 
            // racaTableAdapter
            // 
            this.racaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.agendamento_servicoTableAdapter = null;
            this.tableAdapterManager.agendamentoTableAdapter = null;
            this.tableAdapterManager.animalTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClienteTableAdapter = null;
            this.tableAdapterManager.racaTableAdapter = this.racaTableAdapter;
            this.tableAdapterManager.servicoTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = PrjPetShop_2.masterDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // racaBindingNavigator
            // 
            this.racaBindingNavigator.AddNewItem = null;
            this.racaBindingNavigator.BackColor = System.Drawing.Color.Transparent;
            this.racaBindingNavigator.BindingSource = this.racaBindingSource;
            this.racaBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.racaBindingNavigator.DeleteItem = null;
            this.racaBindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
            this.racaBindingNavigator.ImageScalingSize = new System.Drawing.Size(35, 35);
            this.racaBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.btnCancelar});
            this.racaBindingNavigator.Location = new System.Drawing.Point(90, 7);
            this.racaBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.racaBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.racaBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.racaBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.racaBindingNavigator.Name = "racaBindingNavigator";
            this.racaBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.racaBindingNavigator.Size = new System.Drawing.Size(501, 42);
            this.racaBindingNavigator.TabIndex = 1;
            this.racaBindingNavigator.Text = "bindingNavigator1";
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
            // frmCadRaca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleVioletRed;
            this.ClientSize = new System.Drawing.Size(744, 502);
            this.Controls.Add(this.racaBindingNavigator);
            this.Controls.Add(this.gpbRaca);
            this.Font = new System.Drawing.Font("Cascadia Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmCadRaca";
            this.Text = "frmCadRaca";
            this.Load += new System.EventHandler(this.frmCadRaca_Load);
            this.gpbRaca.ResumeLayout(false);
            this.gpbRaca.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.racaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.racaBindingNavigator)).EndInit();
            this.racaBindingNavigator.ResumeLayout(false);
            this.racaBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbRaca;
        private masterDataSet masterDataSet;
        private System.Windows.Forms.BindingSource racaBindingSource;
        private masterDataSetTableAdapters.racaTableAdapter racaTableAdapter;
        private masterDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator racaBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton racaBindingNavigatorSaveItem;
        private System.Windows.Forms.Label raca_codigoLabel1;
        private System.Windows.Forms.TextBox raca_nomeTextBox;
        private System.Windows.Forms.TextBox raca_pais_origemTextBox;
        private System.Windows.Forms.ToolStripButton btnEditar;
        private System.Windows.Forms.ToolStripButton btnCancelar;
    }
}