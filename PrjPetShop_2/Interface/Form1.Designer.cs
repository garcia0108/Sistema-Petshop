namespace PrjPetShop_2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panelTopo = new System.Windows.Forms.Panel();
            this.panelLateral = new System.Windows.Forms.Panel();
            this.gpbAgendamento1 = new System.Windows.Forms.GroupBox();
            this.btnDetalhes = new System.Windows.Forms.Button();
            this.lblAgendado = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblAndamento = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAgendamento = new System.Windows.Forms.Button();
            this.btnServico = new System.Windows.Forms.Button();
            this.btnRaca = new System.Windows.Forms.Button();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.btnAnimal = new System.Windows.Forms.Button();
            this.btnCliente = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.masterDataSet = new PrjPetShop_2.masterDataSet();
            this.view_DetalhesAgendamentosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.view_DetalhesAgendamentosTableAdapter = new PrjPetShop_2.masterDataSetTableAdapters.View_DetalhesAgendamentosTableAdapter();
            this.tableAdapterManager = new PrjPetShop_2.masterDataSetTableAdapters.TableAdapterManager();
            this.panelCentral = new System.Windows.Forms.Panel();
            this.panelSelecao = new System.Windows.Forms.Panel();
            this.btnUsuario = new System.Windows.Forms.Button();
            this.btnMin = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.panelTopo.SuspendLayout();
            this.panelLateral.SuspendLayout();
            this.gpbAgendamento1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_DetalhesAgendamentosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panelTopo
            // 
            this.panelTopo.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panelTopo.Controls.Add(this.btnUsuario);
            this.panelTopo.Controls.Add(this.btnMin);
            this.panelTopo.Controls.Add(this.btnSair);
            this.panelTopo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopo.Location = new System.Drawing.Point(0, 0);
            this.panelTopo.Name = "panelTopo";
            this.panelTopo.Size = new System.Drawing.Size(930, 38);
            this.panelTopo.TabIndex = 0;
            // 
            // panelLateral
            // 
            this.panelLateral.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panelLateral.Controls.Add(this.gpbAgendamento1);
            this.panelLateral.Controls.Add(this.panelSelecao);
            this.panelLateral.Controls.Add(this.btnAgendamento);
            this.panelLateral.Controls.Add(this.btnServico);
            this.panelLateral.Controls.Add(this.btnRaca);
            this.panelLateral.Controls.Add(this.btnIniciar);
            this.panelLateral.Controls.Add(this.btnAnimal);
            this.panelLateral.Controls.Add(this.btnCliente);
            this.panelLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLateral.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelLateral.Location = new System.Drawing.Point(0, 38);
            this.panelLateral.Name = "panelLateral";
            this.panelLateral.Size = new System.Drawing.Size(186, 502);
            this.panelLateral.TabIndex = 1;
            // 
            // gpbAgendamento1
            // 
            this.gpbAgendamento1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.gpbAgendamento1.Controls.Add(this.btnDetalhes);
            this.gpbAgendamento1.Controls.Add(this.lblAgendado);
            this.gpbAgendamento1.Controls.Add(this.label2);
            this.gpbAgendamento1.Controls.Add(this.lblAndamento);
            this.gpbAgendamento1.Controls.Add(this.label1);
            this.gpbAgendamento1.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbAgendamento1.Location = new System.Drawing.Point(22, 378);
            this.gpbAgendamento1.Name = "gpbAgendamento1";
            this.gpbAgendamento1.Size = new System.Drawing.Size(158, 112);
            this.gpbAgendamento1.TabIndex = 2;
            this.gpbAgendamento1.TabStop = false;
            this.gpbAgendamento1.Text = "Agendamentos";
            // 
            // btnDetalhes
            // 
            this.btnDetalhes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnDetalhes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDetalhes.Font = new System.Drawing.Font("Cascadia Mono", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDetalhes.Location = new System.Drawing.Point(27, 74);
            this.btnDetalhes.Name = "btnDetalhes";
            this.btnDetalhes.Size = new System.Drawing.Size(96, 31);
            this.btnDetalhes.TabIndex = 1;
            this.btnDetalhes.Text = "Detalhes";
            this.btnDetalhes.UseVisualStyleBackColor = true;
            this.btnDetalhes.Click += new System.EventHandler(this.btnDetalhes_Click);
            // 
            // lblAgendado
            // 
            this.lblAgendado.AutoSize = true;
            this.lblAgendado.Font = new System.Drawing.Font("Cascadia Mono", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgendado.Location = new System.Drawing.Point(126, 51);
            this.lblAgendado.Name = "lblAgendado";
            this.lblAgendado.Size = new System.Drawing.Size(18, 20);
            this.lblAgendado.TabIndex = 0;
            this.lblAgendado.Text = "0";
            this.lblAgendado.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cascadia Mono", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Agendado";
            // 
            // lblAndamento
            // 
            this.lblAndamento.AutoSize = true;
            this.lblAndamento.Font = new System.Drawing.Font("Cascadia Mono", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAndamento.Location = new System.Drawing.Point(125, 22);
            this.lblAndamento.Name = "lblAndamento";
            this.lblAndamento.Size = new System.Drawing.Size(18, 20);
            this.lblAndamento.TabIndex = 0;
            this.lblAndamento.Text = "0";
            this.lblAndamento.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cascadia Mono", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Em Andamento";
            // 
            // btnAgendamento
            // 
            this.btnAgendamento.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnAgendamento.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnAgendamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgendamento.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgendamento.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAgendamento.Location = new System.Drawing.Point(49, 328);
            this.btnAgendamento.Name = "btnAgendamento";
            this.btnAgendamento.Size = new System.Drawing.Size(131, 44);
            this.btnAgendamento.TabIndex = 0;
            this.btnAgendamento.Text = "Agendamentos";
            this.btnAgendamento.UseVisualStyleBackColor = false;
            this.btnAgendamento.Click += new System.EventHandler(this.btnAgendamento_Click);
            // 
            // btnServico
            // 
            this.btnServico.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnServico.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnServico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnServico.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnServico.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnServico.Location = new System.Drawing.Point(49, 266);
            this.btnServico.Name = "btnServico";
            this.btnServico.Size = new System.Drawing.Size(131, 44);
            this.btnServico.TabIndex = 0;
            this.btnServico.Text = "Serviços";
            this.btnServico.UseVisualStyleBackColor = false;
            this.btnServico.Click += new System.EventHandler(this.btnServico_Click);
            // 
            // btnRaca
            // 
            this.btnRaca.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnRaca.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnRaca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRaca.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRaca.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnRaca.Location = new System.Drawing.Point(49, 147);
            this.btnRaca.Name = "btnRaca";
            this.btnRaca.Size = new System.Drawing.Size(131, 44);
            this.btnRaca.TabIndex = 0;
            this.btnRaca.Text = "Raças";
            this.btnRaca.UseVisualStyleBackColor = false;
            this.btnRaca.Click += new System.EventHandler(this.btnRaca_Click);
            // 
            // btnIniciar
            // 
            this.btnIniciar.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnIniciar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnIniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIniciar.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnIniciar.Location = new System.Drawing.Point(49, 23);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(131, 44);
            this.btnIniciar.TabIndex = 0;
            this.btnIniciar.Text = "Iniciar";
            this.btnIniciar.UseVisualStyleBackColor = false;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // btnAnimal
            // 
            this.btnAnimal.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnAnimal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnAnimal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnimal.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnimal.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnAnimal.Location = new System.Drawing.Point(49, 207);
            this.btnAnimal.Name = "btnAnimal";
            this.btnAnimal.Size = new System.Drawing.Size(131, 44);
            this.btnAnimal.TabIndex = 0;
            this.btnAnimal.Text = "Animais";
            this.btnAnimal.UseVisualStyleBackColor = false;
            this.btnAnimal.Click += new System.EventHandler(this.btnAnimal_Click);
            // 
            // btnCliente
            // 
            this.btnCliente.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCliente.Font = new System.Drawing.Font("Cascadia Mono", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCliente.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCliente.Location = new System.Drawing.Point(49, 87);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Size = new System.Drawing.Size(131, 44);
            this.btnCliente.TabIndex = 0;
            this.btnCliente.Text = "Clientes";
            this.btnCliente.UseVisualStyleBackColor = false;
            this.btnCliente.Click += new System.EventHandler(this.btnCliente_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // masterDataSet
            // 
            this.masterDataSet.DataSetName = "masterDataSet";
            this.masterDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // view_DetalhesAgendamentosBindingSource
            // 
            this.view_DetalhesAgendamentosBindingSource.DataMember = "View_DetalhesAgendamentos";
            this.view_DetalhesAgendamentosBindingSource.DataSource = this.masterDataSet;
            // 
            // view_DetalhesAgendamentosTableAdapter
            // 
            this.view_DetalhesAgendamentosTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.agendamento_servicoTableAdapter = null;
            this.tableAdapterManager.agendamentoTableAdapter = null;
            this.tableAdapterManager.animalTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClienteTableAdapter = null;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.racaTableAdapter = null;
            this.tableAdapterManager.servicoTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = PrjPetShop_2.masterDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UsuarioTableAdapter = null;
            // 
            // panelCentral
            // 
            this.panelCentral.BackgroundImage = global::PrjPetShop_2.Properties.Resources.Foto_tela_9;
            this.panelCentral.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelCentral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCentral.Font = new System.Drawing.Font("Cascadia Mono Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelCentral.Location = new System.Drawing.Point(186, 38);
            this.panelCentral.Name = "panelCentral";
            this.panelCentral.Size = new System.Drawing.Size(744, 502);
            this.panelCentral.TabIndex = 2;
            // 
            // panelSelecao
            // 
            this.panelSelecao.BackColor = System.Drawing.Color.Transparent;
            this.panelSelecao.BackgroundImage = global::PrjPetShop_2.Properties.Resources.apontando_para_a_direita;
            this.panelSelecao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelSelecao.Location = new System.Drawing.Point(3, 23);
            this.panelSelecao.Name = "panelSelecao";
            this.panelSelecao.Size = new System.Drawing.Size(40, 44);
            this.panelSelecao.TabIndex = 1;
            // 
            // btnUsuario
            // 
            this.btnUsuario.BackColor = System.Drawing.Color.Gray;
            this.btnUsuario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuario.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsuario.Image = global::PrjPetShop_2.Properties.Resources.comercial1;
            this.btnUsuario.Location = new System.Drawing.Point(9, 4);
            this.btnUsuario.Name = "btnUsuario";
            this.btnUsuario.Size = new System.Drawing.Size(100, 29);
            this.btnUsuario.TabIndex = 1;
            this.btnUsuario.Text = "  Usuário";
            this.btnUsuario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUsuario.UseVisualStyleBackColor = false;
            this.btnUsuario.Click += new System.EventHandler(this.btnUsuario_Click);
            // 
            // btnMin
            // 
            this.btnMin.BackgroundImage = global::PrjPetShop_2.Properties.Resources._9057029_minimize_alt_icon;
            this.btnMin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMin.FlatAppearance.BorderSize = 0;
            this.btnMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMin.Location = new System.Drawing.Point(828, 0);
            this.btnMin.Name = "btnMin";
            this.btnMin.Size = new System.Drawing.Size(48, 38);
            this.btnMin.TabIndex = 0;
            this.btnMin.UseVisualStyleBackColor = true;
            this.btnMin.Click += new System.EventHandler(this.btnMin_Click);
            // 
            // btnSair
            // 
            this.btnSair.BackgroundImage = global::PrjPetShop_2.Properties.Resources._8666595_x_icon;
            this.btnSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Location = new System.Drawing.Point(879, 0);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(48, 38);
            this.btnSair.TabIndex = 0;
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 540);
            this.Controls.Add(this.panelCentral);
            this.Controls.Add(this.panelLateral);
            this.Controls.Add(this.panelTopo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelTopo.ResumeLayout(false);
            this.panelLateral.ResumeLayout(false);
            this.gpbAgendamento1.ResumeLayout(false);
            this.gpbAgendamento1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_DetalhesAgendamentosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTopo;
        private System.Windows.Forms.Panel panelLateral;
        private System.Windows.Forms.Button btnAgendamento;
        private System.Windows.Forms.Button btnServico;
        private System.Windows.Forms.Button btnRaca;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.Button btnAnimal;
        private System.Windows.Forms.Button btnCliente;
        private System.Windows.Forms.Panel panelCentral;
        private System.Windows.Forms.Button btnMin;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Panel panelSelecao;
        private System.Windows.Forms.GroupBox gpbAgendamento1;
        private masterDataSet masterDataSet;
        private System.Windows.Forms.BindingSource view_DetalhesAgendamentosBindingSource;
        private masterDataSetTableAdapters.View_DetalhesAgendamentosTableAdapter view_DetalhesAgendamentosTableAdapter;
        private masterDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label lblAgendado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblAndamento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnDetalhes;
        private System.Windows.Forms.Button btnUsuario;
    }
}

