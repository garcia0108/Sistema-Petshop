using PrjPetShop_2.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;

namespace PrjPetShop_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desaje mesmo sair", "PetShop", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                //Application.Exit();

                frmEntLogin login = new frmEntLogin();
                login.Show();
                this.Hide();
            }
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            //Vamos instâciar o formulário frmCadCliente
            frmCadCliente cliente = new frmCadCliente();

            cliente.TopLevel = false; //Para não sobrepor o formulário principal
            cliente.Dock = DockStyle.Fill; //Para preenchimento do painel central
            panelCentral.Controls.Clear(); //Para limpar o form
            panelCentral.Controls.Add(cliente); //Para adicionar o form no painel central
            cliente.Show(); //Para chamar o form

            //Aplicar a posição do eixo X do painel Seleção
            panelSelecao.Top = btnCliente.Top;
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            panelCentral.Controls.Clear();

            //Aplicar a posição do eixo X do painel Seleção
            panelSelecao.Top = btnIniciar.Top;  
        }

        private void btnRaca_Click(object sender, EventArgs e)
        {
            //Vamos instâncior o formulário frmCadRaca
            frmCadRaca raca = new frmCadRaca(); 

            raca.TopLevel = false; //Para não sobrepor o formulário principal
            raca.Dock = DockStyle.Fill; //Para preenchimento do painel central
            panelCentral.Controls.Clear(); //Para limpar o form
            panelCentral.Controls.Add(raca); //Para adicionar o form no painel central
            raca.Show(); //Para chamar o form

            //Aplicar a posiç~so do eixo X do painel Seleção
            panelSelecao.Top = btnRaca.Top;
        }

        private void btnServico_Click(object sender, EventArgs e)
        {
            //Vamos instânciar o fomulário frmCadServico
            frmCadServico servico = new frmCadServico();

            servico.TopLevel = false; //Para não sobrepor o formulário principal
            servico.Dock = DockStyle.Fill; // Para preenchimento do painel central
            panelCentral.Controls.Clear(); // Para limpra o form
            panelCentral.Controls.Add(servico); //Para adicionar o form
            servico.Show(); //Para chamar o form

            //Aplicar a posição do eixo X do paneil Seleção
            panelSelecao.Top = btnServico.Top;
        }

        private void btnAnimal_Click(object sender, EventArgs e)
        {
            //Vamos instânciar o fomrulário frmCadAnimal
            frmCadAnimal animal = new frmCadAnimal();

            animal.TopLevel = false; //Para não sobrepor o formulário principal
            animal.Dock = DockStyle.Fill; //Para preenchimento do painel central
            panelCentral.Controls.Clear(); //Para limpar o form
            panelCentral.Controls.Add(animal); //Para adicionar o form
            animal.Show(); //Para chamar o form

            //Aplicar a posição do eixo X do painel Seleção
            panelSelecao.Top = btnAnimal.Top;
        }

        private void btnAgendamento_Click(object sender, EventArgs e)
        {
            //Vamos instânciar o formulário frmCadAgendamento
            frmCadAgendamento agendamento = new frmCadAgendamento();

            agendamento.TopLevel = false; //Para não sobrepor o formulário principal
            agendamento.Dock = DockStyle.Fill; //Para preenchimento do painel central
            panelCentral.Controls.Clear(); //Para limpra o form
            panelCentral.Controls.Add(agendamento); //Para adicionar o form
            agendamento.Show(); //Para chamar o form

            //Aplicar a posição do eixo X do painel Seleção
            panelSelecao.Top = btnAgendamento.Top;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'masterDataSet.View_DetalhesAgendamentos'. Você pode movê-la ou removê-la conforme necessário.
            //this.view_DetalhesAgendamentosTableAdapter.Fill(this.masterDataSet.View_DetalhesAgendamentos);

            using (SqlConnection novaConexao = new SqlConnection(Conexao.stringConexao))
            {
                try //Tente realizar as linhas de comandos dentro das chaves.
                {
                    novaConexao.Open(); //Abre a conexão com o banco de dados
                    MessageBox.Show("Conexão ao Banco de Dados" + ",\nrealizada com sucesso!", "Banco de Dados"); //Mostra a caixa de mensagem com o texto "Conectou!".
                }
                catch (Exception) //Se houver algum erro no bloco try, o programa captura o mesmo e realiza a ação entre as chaves.
                {

                    MessageBox.Show("Não conectou!", "PetShop");
                }
                finally //Por finm ele realiza a ação informada entre chaves, com ou se erro.
                {
                    MessageBox.Show("Olá, garcia0108" + ",\nBem-vindo ao Sistema de PetShop!", "PetShop");
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //Recarregar os dados na view
            view_DetalhesAgendamentosTableAdapter.Fill(masterDataSet.View_DetalhesAgendamentos);

            //Para filtrar a data atual e a situação Em Andamento
            view_DetalhesAgendamentosBindingSource.Filter = "ag_data = '" + DateTime.Now.ToShortDateString() + "' and ag_situacao like 'Em Andamento'";
            int QTDandamento = int.Parse(view_DetalhesAgendamentosBindingSource.Count.ToString());

            //Remover o filtro anterior
            view_DetalhesAgendamentosBindingSource.RemoveFilter();

            //Para fitrar a data e a situação Agendado
            view_DetalhesAgendamentosBindingSource.Filter = "ag_data = '" + DateTime.Now.ToShortDateString() + "' and ag_situacao like 'Agendado'";
            int QTDagendado = int.Parse(view_DetalhesAgendamentosBindingSource.Count.ToString());

            lblAndamento.Text = QTDandamento.ToString();
            lblAgendado.Text = QTDagendado.ToString();
        }

        private void btnDetalhes_Click(object sender, EventArgs e)
        {
            frmDetalehsAgendamentos detalhes = new frmDetalehsAgendamentos();

            detalhes.TopLevel = false;
            detalhes.Dock = DockStyle.Fill;
            panelCentral.Controls.Clear();
            panelCentral.Controls.Add(detalhes);
            detalhes.Show();

        
        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            frmCadUsuario usuario = new frmCadUsuario();
            usuario.Show();
        }
    }
}
