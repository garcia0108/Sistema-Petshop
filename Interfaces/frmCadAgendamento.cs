using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrjPetShop_2
{
    public partial class frmCadAgendamento : Form
    {
        public frmCadAgendamento()
        {
            InitializeComponent();
        }

       

        private void frmCadAgendamento_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'masterDataSet.View_TotalServico'. Você pode movê-la ou removê-la conforme necessário.
            this.view_TotalServicoTableAdapter.Fill(this.masterDataSet.View_TotalServico);
            // TODO: esta linha de código carrega dados na tabela 'masterDataSet1.servico'. Você pode movê-la ou removê-la conforme necessário.
            this.servicoTableAdapter.Fill(this.masterDataSet1.servico);
            // TODO: esta linha de código carrega dados na tabela 'masterDataSet.View_AgendamentoServico'. Você pode movê-la ou removê-la conforme necessário.
            this.view_AgendamentoServicoTableAdapter.Fill(this.masterDataSet.View_AgendamentoServico);
            // TODO: esta linha de código carrega dados na tabela 'masterDataSet.agendamento_servico'. Você pode movê-la ou removê-la conforme necessário.
            this.agendamento_servicoTableAdapter.Fill(this.masterDataSet.agendamento_servico);
            // TODO: esta linha de código carrega dados na tabela 'masterDataSet.animal'. Você pode movê-la ou removê-la conforme necessário.
            this.animalTableAdapter.Fill(this.masterDataSet.animal);
            // TODO: esta linha de código carrega dados na tabela 'masterDataSet.agendamento'. Você pode movê-la ou removê-la conforme necessário.
            this.agendamentoTableAdapter.Fill(this.masterDataSet.agendamento);

        }

        private void bindingNavigatorAddNewItem_Click_1(object sender, EventArgs e)
        {
            agendamentoBindingSource.AddNew();
            ag_situacaoComboBox.Text = "Agendado";
            ag_dataMaskedTextBox.Text = DateTime.Now.ToShortDateString();
            ag_horarioMaskedTextBox.Text = DateTime.Now.ToShortTimeString();
            ag_totalTextBox.Text = "0,00";

            gpbAgendamento.Enabled = true;
        }

        private void racaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.agendamentoBindingSource.EndEdit();
                agendamentoTableAdapter.Update(masterDataSet.agendamento);
                gpbAgendamento.Enabled = false;

                MessageBox.Show("Agendamento salvo, informe o serviços!", "PetShop");
                txtCodServ.Focus();
            }
            catch (Exception)
            {

                MessageBox.Show("Ocorreu um erro, verifique os valores informado!", "PetShop");
            }
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            gpbAgendamento.Enabled = false;
            agendamentoBindingSource.CancelEdit();
        }

        private void btnEditar_Click_1(object sender, EventArgs e)
        {
            gpbAgendamento.Enabled = true;
        }

        private void bindingNavigatorDeleteItem_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Deseja mesmo excluir esse registro?", "PetShop", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    agendamentoBindingSource.RemoveCurrent();
                    agendamentoTableAdapter.Update(masterDataSet.agendamento);
                }
            }
            catch (Exception)
            {

                agendamentoTableAdapter.Fill(masterDataSet.agendamento);
                MessageBox.Show("O registro não pode ser excluído!", "PetShop");
            }

            
        }

        private void txtCodServ_KeyDown(object sender, KeyEventArgs e)
        {
            //Se o usuário der Enter
            if (e.KeyCode==Keys.Enter && txtCodServ.Text != "")
            {
                servicoBindingSource.Filter = "serv_codigo =" + txtCodServ.Text;
                if (servicoBindingSource.Count == 1)//Encotra um regitro
                {
                    //Cria uma variavél com todos os dados encontrado
                    DataRowView ServicoEncontrado = (DataRowView)servicoBindingSource.Current;
                    txtServico.Text = ServicoEncontrado["serv_descricao"].ToString();
                    txtValor.Text = ServicoEncontrado["serv_preco"].ToString();

                    txtQtd.Text = "1";
                    txtQtd.SelectAll();
                    txtQtd.Focus();
                }
                else //Abrir o Cadastro pra ele localizar
                {
                    frmCadServico serv = new frmCadServico();   
                    serv.ShowDialog(); //Jogar os valores no textbox
                }
            }
           
        }

        private void btnAddServico_Click(object sender, EventArgs e)
        {
            try
            {
                agendamento_servicoTableAdapter.InserirServico(int.Parse(ag_codigoTextBox.Text), int.Parse(txtCodServ.Text), int.Parse(txtQtd.Text), decimal.Parse(txtValor.Text));

                //Limpar os textbox
                txtCodServ.Clear();
                txtServico.Clear();
                txtQtd.Clear();
                txtValor.Clear();
                txtCodServ.Focus();

                //Atualzar
                Atualizar_Grid();

            }
            catch (Exception)
            {

                MessageBox.Show("Insira os valores!", "PetShop");
            }

            Total();
        }

        private void Atualizar_Grid()
        {
            try //Pesquisar
            {
                if (ag_codigoTextBox.Text != "")
                {
                    //Recarregar os dados
                    view_AgendamentoServicoTableAdapter.Fill(masterDataSet.View_AgendamentoServico);

                    //filtra pelo código do agendamento
                    view_AgendamentoServicoBindingSource.Filter = "ag_serv_agendamento =" + ag_codigoTextBox.Text;
                }
            }
            catch (Exception)
            {

                
            }
        }

        private void ag_codigoTextBox_TextChanged(object sender, EventArgs e)
        {
            Atualizar_Grid();
            
        }

        private void txtQtd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Enter && txtQtd.Text !="")
            {
                txtValor.SelectAll();
                txtValor.Focus();
            }
        }

        private void txtValor_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode==Keys.Enter && txtValor.Text !="")
            {
                btnAddServico_Click(sender, e);
            } 
        }

        private void view_AgendamentoServicoDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int Codigo = 0;

                Codigo = int.Parse(view_AgendamentoServicoDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString());
                
                agendamento_servicoTableAdapter.RemoverServico(Codigo);
            }
            catch (Exception)
            {

               
            }

            Atualizar_Grid();
            Total();
            
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Após finalizado, o agendamento não poderá mais ser alterado!", "PetShop", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ag_situacaoComboBox.Text = "Finalizado"; //Mundar i texto da combo
                agendamentoBindingSource.EndEdit(); //Finalizar edição
                agendamentoTableAdapter.Update(masterDataSet.agendamento); // Salvar alterações
                MessageBox.Show("Agendamento finalizado com sucesso", "PetShop", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Finalizado(); //Bloquear se tiver finalizado
            }

            
        }

        private void Finalizado()
        {
            if (ag_situacaoComboBox.Text == "Finalizado")
            {
               
                racaBindingNavigatorSaveItem.Enabled = false;
                btnEditar.Enabled = false;
                btnCancelar.Enabled = false;
                btnFinalizar.Enabled = false;
                bindingNavigatorDeleteItem.Enabled = false;
                gpbServico.Enabled = false;
            }
            else
            {
                
                racaBindingNavigatorSaveItem.Enabled = true;
                btnEditar.Enabled = true;
                btnCancelar.Enabled = true;
                btnFinalizar.Enabled = true;
                bindingNavigatorDeleteItem.Enabled = true;
                gpbServico.Enabled = true;
            }
        }

        private void agendamentoBindingSource_PositionChanged(object sender, EventArgs e)
        {
            Finalizado();
        }

        private void Total()
        {
            if (ag_codigoTextBox.Text != "")
            {
                view_TotalServicoTableAdapter.Fill(masterDataSet.View_TotalServico);
                view_TotalServicoBindingSource.Filter = "ag_serv_agendamento =" + ag_codigoTextBox.Text;
                    if (view_TotalServicoBindingSource.Count ==1)
                    {
                        DataRowView Resultado = (DataRowView)view_TotalServicoBindingSource.Current;

                        ag_totalTextBox.Text = Resultado["Total"].ToString();
                        agendamentoTableAdapter.Update(masterDataSet.agendamento);
                    }
                    else
                    {
                        ag_totalTextBox.Text = "0,00";
                        agendamentoTableAdapter.Update(masterDataSet.agendamento);
                    }
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            VariaveisGlobais.CodigoTroca = 0;
            frmPesquisaAnimal pesquisar = new frmPesquisaAnimal();
            pesquisar.ShowDialog();

            //Se ele encontrar algum registro
            if (VariaveisGlobais.CodigoTroca > 0)
            {
                //Posiciona o código encontrado
                animalBindingSource.Position = animalBindingSource.Find("ani_codigo", VariaveisGlobais.CodigoTroca);
            }
        }
    }
}
