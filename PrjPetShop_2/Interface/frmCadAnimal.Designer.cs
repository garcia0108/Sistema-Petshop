namespace PrjPetShop_2
{
    partial class frmCadAnimal
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
            System.Windows.Forms.Label ani_codigoLabel;
            System.Windows.Forms.Label ani_nomeLabel;
            System.Windows.Forms.Label ani_sexoLabel;
            System.Windows.Forms.Label ani_agressivoLabel;
            System.Windows.Forms.Label ani_corLabel;
            System.Windows.Forms.Label ani_idadeLabel;
            System.Windows.Forms.Label ani_alergiaLabel;
            System.Windows.Forms.Label ani_clienteLabel;
            System.Windows.Forms.Label ani_racaLabel;
            System.Windows.Forms.Label ani_fotoLabel;
            this.gpbAnimal = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.ani_codigoLabel1 = new System.Windows.Forms.Label();
            this.animalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.masterDataSet = new PrjPetShop_2.masterDataSet();
            this.ani_nomeTextBox = new System.Windows.Forms.TextBox();
            this.ani_sexoComboBox = new System.Windows.Forms.ComboBox();
            this.ani_agressivoComboBox = new System.Windows.Forms.ComboBox();
            this.ani_corComboBox = new System.Windows.Forms.ComboBox();
            this.ani_idadeTextBox = new System.Windows.Forms.TextBox();
            this.ani_alergiaTextBox = new System.Windows.Forms.TextBox();
            this.ani_clienteComboBox = new System.Windows.Forms.ComboBox();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ani_racaComboBox = new System.Windows.Forms.ComboBox();
            this.racaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ani_fotoPictureBox = new System.Windows.Forms.PictureBox();
            this.animalTableAdapter = new PrjPetShop_2.masterDataSetTableAdapters.animalTableAdapter();
            this.tableAdapterManager = new PrjPetShop_2.masterDataSetTableAdapters.TableAdapterManager();
            this.animalBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.animalBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.btnEditar = new System.Windows.Forms.ToolStripButton();
            this.btnCancelar = new System.Windows.Forms.ToolStripButton();
            this.clienteTableAdapter = new PrjPetShop_2.masterDataSetTableAdapters.ClienteTableAdapter();
            this.racaTableAdapter = new PrjPetShop_2.masterDataSetTableAdapters.racaTableAdapter();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ani_codigoLabel = new System.Windows.Forms.Label();
            ani_nomeLabel = new System.Windows.Forms.Label();
            ani_sexoLabel = new System.Windows.Forms.Label();
            ani_agressivoLabel = new System.Windows.Forms.Label();
            ani_corLabel = new System.Windows.Forms.Label();
            ani_idadeLabel = new System.Windows.Forms.Label();
            ani_alergiaLabel = new System.Windows.Forms.Label();
            ani_clienteLabel = new System.Windows.Forms.Label();
            ani_racaLabel = new System.Windows.Forms.Label();
            ani_fotoLabel = new System.Windows.Forms.Label();
            this.gpbAnimal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.animalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.racaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ani_fotoPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.animalBindingNavigator)).BeginInit();
            this.animalBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // ani_codigoLabel
            // 
            ani_codigoLabel.AutoSize = true;
            ani_codigoLabel.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ani_codigoLabel.Location = new System.Drawing.Point(16, 37);
            ani_codigoLabel.Name = "ani_codigoLabel";
            ani_codigoLabel.Size = new System.Drawing.Size(73, 21);
            ani_codigoLabel.TabIndex = 0;
            ani_codigoLabel.Text = "Código:";
            // 
            // ani_nomeLabel
            // 
            ani_nomeLabel.AutoSize = true;
            ani_nomeLabel.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ani_nomeLabel.Location = new System.Drawing.Point(16, 68);
            ani_nomeLabel.Name = "ani_nomeLabel";
            ani_nomeLabel.Size = new System.Drawing.Size(46, 21);
            ani_nomeLabel.TabIndex = 2;
            ani_nomeLabel.Text = "Nome";
            // 
            // ani_sexoLabel
            // 
            ani_sexoLabel.AutoSize = true;
            ani_sexoLabel.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ani_sexoLabel.Location = new System.Drawing.Point(16, 104);
            ani_sexoLabel.Name = "ani_sexoLabel";
            ani_sexoLabel.Size = new System.Drawing.Size(55, 21);
            ani_sexoLabel.TabIndex = 4;
            ani_sexoLabel.Text = "Sexo:";
            // 
            // ani_agressivoLabel
            // 
            ani_agressivoLabel.AutoSize = true;
            ani_agressivoLabel.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ani_agressivoLabel.Location = new System.Drawing.Point(16, 143);
            ani_agressivoLabel.Name = "ani_agressivoLabel";
            ani_agressivoLabel.Size = new System.Drawing.Size(100, 21);
            ani_agressivoLabel.TabIndex = 6;
            ani_agressivoLabel.Text = "Agressivo:";
            // 
            // ani_corLabel
            // 
            ani_corLabel.AutoSize = true;
            ani_corLabel.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ani_corLabel.Location = new System.Drawing.Point(16, 182);
            ani_corLabel.Name = "ani_corLabel";
            ani_corLabel.Size = new System.Drawing.Size(46, 21);
            ani_corLabel.TabIndex = 8;
            ani_corLabel.Text = "Cor:";
            // 
            // ani_idadeLabel
            // 
            ani_idadeLabel.AutoSize = true;
            ani_idadeLabel.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ani_idadeLabel.Location = new System.Drawing.Point(16, 221);
            ani_idadeLabel.Name = "ani_idadeLabel";
            ani_idadeLabel.Size = new System.Drawing.Size(64, 21);
            ani_idadeLabel.TabIndex = 10;
            ani_idadeLabel.Text = "Idade:";
            // 
            // ani_alergiaLabel
            // 
            ani_alergiaLabel.AutoSize = true;
            ani_alergiaLabel.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ani_alergiaLabel.Location = new System.Drawing.Point(16, 257);
            ani_alergiaLabel.Name = "ani_alergiaLabel";
            ani_alergiaLabel.Size = new System.Drawing.Size(82, 21);
            ani_alergiaLabel.TabIndex = 12;
            ani_alergiaLabel.Text = "Alergia:";
            // 
            // ani_clienteLabel
            // 
            ani_clienteLabel.AutoSize = true;
            ani_clienteLabel.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ani_clienteLabel.Location = new System.Drawing.Point(7, 361);
            ani_clienteLabel.Name = "ani_clienteLabel";
            ani_clienteLabel.Size = new System.Drawing.Size(82, 21);
            ani_clienteLabel.TabIndex = 14;
            ani_clienteLabel.Text = "Cliente:";
            // 
            // ani_racaLabel
            // 
            ani_racaLabel.AutoSize = true;
            ani_racaLabel.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ani_racaLabel.Location = new System.Drawing.Point(7, 400);
            ani_racaLabel.Name = "ani_racaLabel";
            ani_racaLabel.Size = new System.Drawing.Size(55, 21);
            ani_racaLabel.TabIndex = 16;
            ani_racaLabel.Text = "Raça:";
            // 
            // ani_fotoLabel
            // 
            ani_fotoLabel.AutoSize = true;
            ani_fotoLabel.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ani_fotoLabel.Location = new System.Drawing.Point(450, 28);
            ani_fotoLabel.Name = "ani_fotoLabel";
            ani_fotoLabel.Size = new System.Drawing.Size(55, 21);
            ani_fotoLabel.TabIndex = 18;
            ani_fotoLabel.Text = "Foto:";
            // 
            // gpbAnimal
            // 
            this.gpbAnimal.Controls.Add(this.button1);
            this.gpbAnimal.Controls.Add(ani_codigoLabel);
            this.gpbAnimal.Controls.Add(this.ani_codigoLabel1);
            this.gpbAnimal.Controls.Add(ani_nomeLabel);
            this.gpbAnimal.Controls.Add(this.ani_nomeTextBox);
            this.gpbAnimal.Controls.Add(ani_sexoLabel);
            this.gpbAnimal.Controls.Add(this.ani_sexoComboBox);
            this.gpbAnimal.Controls.Add(ani_agressivoLabel);
            this.gpbAnimal.Controls.Add(this.ani_agressivoComboBox);
            this.gpbAnimal.Controls.Add(ani_corLabel);
            this.gpbAnimal.Controls.Add(this.ani_corComboBox);
            this.gpbAnimal.Controls.Add(ani_idadeLabel);
            this.gpbAnimal.Controls.Add(this.ani_idadeTextBox);
            this.gpbAnimal.Controls.Add(ani_alergiaLabel);
            this.gpbAnimal.Controls.Add(this.ani_alergiaTextBox);
            this.gpbAnimal.Controls.Add(ani_clienteLabel);
            this.gpbAnimal.Controls.Add(this.ani_clienteComboBox);
            this.gpbAnimal.Controls.Add(ani_racaLabel);
            this.gpbAnimal.Controls.Add(this.ani_racaComboBox);
            this.gpbAnimal.Controls.Add(ani_fotoLabel);
            this.gpbAnimal.Controls.Add(this.ani_fotoPictureBox);
            this.gpbAnimal.Enabled = false;
            this.gpbAnimal.Font = new System.Drawing.Font("Cascadia Mono", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbAnimal.Location = new System.Drawing.Point(24, 46);
            this.gpbAnimal.Name = "gpbAnimal";
            this.gpbAnimal.Size = new System.Drawing.Size(697, 444);
            this.gpbAnimal.TabIndex = 0;
            this.gpbAnimal.TabStop = false;
            this.gpbAnimal.Text = "Dados do Animal";
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::PrjPetShop_2.Properties.Resources.cao;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(511, 207);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(57, 53);
            this.button1.TabIndex = 20;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ani_codigoLabel1
            // 
            this.ani_codigoLabel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ani_codigoLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.animalBindingSource, "ani_codigo", true));
            this.ani_codigoLabel1.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ani_codigoLabel1.Location = new System.Drawing.Point(122, 28);
            this.ani_codigoLabel1.Name = "ani_codigoLabel1";
            this.ani_codigoLabel1.Size = new System.Drawing.Size(98, 32);
            this.ani_codigoLabel1.TabIndex = 1;
            // 
            // animalBindingSource
            // 
            this.animalBindingSource.DataMember = "animal";
            this.animalBindingSource.DataSource = this.masterDataSet;
            // 
            // masterDataSet
            // 
            this.masterDataSet.DataSetName = "masterDataSet";
            this.masterDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ani_nomeTextBox
            // 
            this.ani_nomeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.animalBindingSource, "ani_nome", true));
            this.ani_nomeTextBox.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ani_nomeTextBox.Location = new System.Drawing.Point(122, 65);
            this.ani_nomeTextBox.Name = "ani_nomeTextBox";
            this.ani_nomeTextBox.Size = new System.Drawing.Size(307, 26);
            this.ani_nomeTextBox.TabIndex = 3;
            // 
            // ani_sexoComboBox
            // 
            this.ani_sexoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.animalBindingSource, "ani_sexo", true));
            this.ani_sexoComboBox.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ani_sexoComboBox.FormattingEnabled = true;
            this.ani_sexoComboBox.Items.AddRange(new object[] {
            "F",
            "M"});
            this.ani_sexoComboBox.Location = new System.Drawing.Point(122, 101);
            this.ani_sexoComboBox.Name = "ani_sexoComboBox";
            this.ani_sexoComboBox.Size = new System.Drawing.Size(88, 29);
            this.ani_sexoComboBox.TabIndex = 5;
            // 
            // ani_agressivoComboBox
            // 
            this.ani_agressivoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.animalBindingSource, "ani_agressivo", true));
            this.ani_agressivoComboBox.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ani_agressivoComboBox.FormattingEnabled = true;
            this.ani_agressivoComboBox.Items.AddRange(new object[] {
            "S",
            "N"});
            this.ani_agressivoComboBox.Location = new System.Drawing.Point(122, 140);
            this.ani_agressivoComboBox.Name = "ani_agressivoComboBox";
            this.ani_agressivoComboBox.Size = new System.Drawing.Size(88, 29);
            this.ani_agressivoComboBox.TabIndex = 7;
            // 
            // ani_corComboBox
            // 
            this.ani_corComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.animalBindingSource, "ani_cor", true));
            this.ani_corComboBox.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ani_corComboBox.FormattingEnabled = true;
            this.ani_corComboBox.Items.AddRange(new object[] {
            "Branco ",
            "Preto",
            "Caramelo",
            "Outros"});
            this.ani_corComboBox.Location = new System.Drawing.Point(122, 179);
            this.ani_corComboBox.Name = "ani_corComboBox";
            this.ani_corComboBox.Size = new System.Drawing.Size(121, 29);
            this.ani_corComboBox.TabIndex = 9;
            // 
            // ani_idadeTextBox
            // 
            this.ani_idadeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.animalBindingSource, "ani_idade", true));
            this.ani_idadeTextBox.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ani_idadeTextBox.Location = new System.Drawing.Point(122, 218);
            this.ani_idadeTextBox.Name = "ani_idadeTextBox";
            this.ani_idadeTextBox.Size = new System.Drawing.Size(121, 26);
            this.ani_idadeTextBox.TabIndex = 11;
            // 
            // ani_alergiaTextBox
            // 
            this.ani_alergiaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.animalBindingSource, "ani_alergia", true));
            this.ani_alergiaTextBox.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ani_alergiaTextBox.Location = new System.Drawing.Point(122, 254);
            this.ani_alergiaTextBox.MaxLength = 100;
            this.ani_alergiaTextBox.Multiline = true;
            this.ani_alergiaTextBox.Name = "ani_alergiaTextBox";
            this.ani_alergiaTextBox.Size = new System.Drawing.Size(307, 98);
            this.ani_alergiaTextBox.TabIndex = 13;
            // 
            // ani_clienteComboBox
            // 
            this.ani_clienteComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.animalBindingSource, "ani_cliente", true));
            this.ani_clienteComboBox.DataSource = this.clienteBindingSource;
            this.ani_clienteComboBox.DisplayMember = "cli_nome";
            this.ani_clienteComboBox.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ani_clienteComboBox.FormattingEnabled = true;
            this.ani_clienteComboBox.Location = new System.Drawing.Point(122, 358);
            this.ani_clienteComboBox.Name = "ani_clienteComboBox";
            this.ani_clienteComboBox.Size = new System.Drawing.Size(307, 29);
            this.ani_clienteComboBox.TabIndex = 15;
            this.ani_clienteComboBox.ValueMember = "cli_codigo";
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataMember = "Cliente";
            this.clienteBindingSource.DataSource = this.masterDataSet;
            // 
            // ani_racaComboBox
            // 
            this.ani_racaComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.animalBindingSource, "ani_raca", true));
            this.ani_racaComboBox.DataSource = this.racaBindingSource;
            this.ani_racaComboBox.DisplayMember = "raca_nome";
            this.ani_racaComboBox.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ani_racaComboBox.FormattingEnabled = true;
            this.ani_racaComboBox.Location = new System.Drawing.Point(122, 397);
            this.ani_racaComboBox.Name = "ani_racaComboBox";
            this.ani_racaComboBox.Size = new System.Drawing.Size(307, 29);
            this.ani_racaComboBox.TabIndex = 17;
            this.ani_racaComboBox.ValueMember = "raca_codigo";
            // 
            // racaBindingSource
            // 
            this.racaBindingSource.DataMember = "raca";
            this.racaBindingSource.DataSource = this.masterDataSet;
            // 
            // ani_fotoPictureBox
            // 
            this.ani_fotoPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.animalBindingSource, "ani_foto", true));
            this.ani_fotoPictureBox.Location = new System.Drawing.Point(511, 28);
            this.ani_fotoPictureBox.Name = "ani_fotoPictureBox";
            this.ani_fotoPictureBox.Size = new System.Drawing.Size(167, 175);
            this.ani_fotoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ani_fotoPictureBox.TabIndex = 19;
            this.ani_fotoPictureBox.TabStop = false;
            // 
            // animalTableAdapter
            // 
            this.animalTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.agendamento_servicoTableAdapter = null;
            this.tableAdapterManager.agendamentoTableAdapter = null;
            this.tableAdapterManager.animalTableAdapter = this.animalTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClienteTableAdapter = null;
            this.tableAdapterManager.racaTableAdapter = null;
            this.tableAdapterManager.servicoTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = PrjPetShop_2.masterDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // animalBindingNavigator
            // 
            this.animalBindingNavigator.AddNewItem = null;
            this.animalBindingNavigator.BackColor = System.Drawing.Color.Transparent;
            this.animalBindingNavigator.BindingSource = this.animalBindingSource;
            this.animalBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.animalBindingNavigator.DeleteItem = null;
            this.animalBindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
            this.animalBindingNavigator.ImageScalingSize = new System.Drawing.Size(35, 35);
            this.animalBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.animalBindingNavigatorSaveItem,
            this.btnEditar,
            this.btnCancelar});
            this.animalBindingNavigator.Location = new System.Drawing.Point(110, 1);
            this.animalBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.animalBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.animalBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.animalBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.animalBindingNavigator.Name = "animalBindingNavigator";
            this.animalBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.animalBindingNavigator.Size = new System.Drawing.Size(470, 42);
            this.animalBindingNavigator.TabIndex = 1;
            this.animalBindingNavigator.Text = "bindingNavigator1";
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
            // animalBindingNavigatorSaveItem
            // 
            this.animalBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.animalBindingNavigatorSaveItem.Image = global::PrjPetShop_2.Properties.Resources.salvar;
            this.animalBindingNavigatorSaveItem.Name = "animalBindingNavigatorSaveItem";
            this.animalBindingNavigatorSaveItem.Size = new System.Drawing.Size(39, 39);
            this.animalBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.animalBindingNavigatorSaveItem.Click += new System.EventHandler(this.animalBindingNavigatorSaveItem_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Image = global::PrjPetShop_2.Properties.Resources.editar2;
            this.btnEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(39, 39);
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = global::PrjPetShop_2.Properties.Resources.cancelar1;
            this.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(39, 39);
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // clienteTableAdapter
            // 
            this.clienteTableAdapter.ClearBeforeFill = true;
            // 
            // racaTableAdapter
            // 
            this.racaTableAdapter.ClearBeforeFill = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Title = "Escolha a Foto ";
            // 
            // frmCadAnimal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleVioletRed;
            this.ClientSize = new System.Drawing.Size(744, 502);
            this.Controls.Add(this.animalBindingNavigator);
            this.Controls.Add(this.gpbAnimal);
            this.Font = new System.Drawing.Font("Cascadia Mono", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmCadAnimal";
            this.Text = "frmCadAnimal";
            this.Load += new System.EventHandler(this.frmCadAnimal_Load);
            this.gpbAnimal.ResumeLayout(false);
            this.gpbAnimal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.animalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.racaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ani_fotoPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.animalBindingNavigator)).EndInit();
            this.animalBindingNavigator.ResumeLayout(false);
            this.animalBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbAnimal;
        private masterDataSet masterDataSet;
        private System.Windows.Forms.BindingSource animalBindingSource;
        private masterDataSetTableAdapters.animalTableAdapter animalTableAdapter;
        private masterDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator animalBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton animalBindingNavigatorSaveItem;
        private System.Windows.Forms.Label ani_codigoLabel1;
        private System.Windows.Forms.TextBox ani_nomeTextBox;
        private System.Windows.Forms.ComboBox ani_sexoComboBox;
        private System.Windows.Forms.ComboBox ani_agressivoComboBox;
        private System.Windows.Forms.ComboBox ani_corComboBox;
        private System.Windows.Forms.TextBox ani_idadeTextBox;
        private System.Windows.Forms.TextBox ani_alergiaTextBox;
        private System.Windows.Forms.ComboBox ani_clienteComboBox;
        private System.Windows.Forms.ComboBox ani_racaComboBox;
        private System.Windows.Forms.PictureBox ani_fotoPictureBox;
        private System.Windows.Forms.ToolStripButton btnEditar;
        private System.Windows.Forms.ToolStripButton btnCancelar;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private masterDataSetTableAdapters.ClienteTableAdapter clienteTableAdapter;
        private System.Windows.Forms.BindingSource racaBindingSource;
        private masterDataSetTableAdapters.racaTableAdapter racaTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}