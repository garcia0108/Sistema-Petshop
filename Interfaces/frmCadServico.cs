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
    public partial class frmCadServico : Form
    {
        public frmCadServico()
        {
            InitializeComponent();
        }

        private void servicoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.servicoBindingSource.EndEdit();
                servicoTableAdapter.Update(masterDataSet.servico);
                gpbServico.Enabled = false;

                MessageBox.Show("Registro salvo com sucesso!", "PetShop");
            }
            catch (Exception)
            {

                MessageBox.Show("Ocorreu um erro, verifique os valores informado!", "PetShop");
            }

        }

        private void frmCadServico_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'masterDataSet.servico'. Você pode movê-la ou removê-la conforme necessário.
            this.servicoTableAdapter.Fill(this.masterDataSet.servico);

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            //Adicionar um novo item
            servicoBindingSource.AddNew();
            gpbServico.Enabled = true;//Para liberar o GruoupBox para adicionar um novo item
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            servicoBindingSource.CancelEdit();
            gpbServico.Enabled = false;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            gpbServico.Enabled = true;
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Deseja mesmo excluir esse registro?", "PetShop", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    servicoBindingSource.RemoveCurrent(); //Remover
                    servicoTableAdapter.Update(masterDataSet.servico);//Salvar
                }
            }
            catch (Exception)
            {

                servicoTableAdapter.Fill(masterDataSet.servico);

                MessageBox.Show("O registro não pode ser excluído!", "PetShop");
            }
        }
    }
}
