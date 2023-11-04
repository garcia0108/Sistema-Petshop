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
    public partial class frmCadRaca : Form
    {
        public frmCadRaca()
        {
            InitializeComponent();
        }

        private void racaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            //Tratamento de erro
            try //Tente
            {
                this.Validate();
                this.racaBindingSource.EndEdit();
                racaTableAdapter.Update(masterDataSet.raca);
                gpbRaca.Enabled = false;
                MessageBox.Show("Registro salvo com sucesso!", "PetShop");
            }
            catch (Exception) //Capture o erro
            {

                MessageBox.Show("Ocorreu um erro, verifique os valores informados!", "PetShop");
            }

        }

        private void frmCadRaca_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'masterDataSet.raca'. Você pode movê-la ou removê-la conforme necessário.
            this.racaTableAdapter.Fill(this.masterDataSet.raca);

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            //Adicionar um item
            racaBindingSource.AddNew();
            gpbRaca.Enabled = true; //Para liberar o GruopBox para adicionar algum item
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            racaBindingSource.CancelEdit();
            gpbRaca.Enabled = false;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            gpbRaca.Enabled = true;
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            //Tratamento de erro
            try
            {
                if (MessageBox.Show("Deseja mesmo excluir esse registro?", "PetShop", MessageBoxButtons.YesNo, MessageBoxIcon.Question ) == DialogResult.Yes)
                {
                    racaBindingSource.RemoveCurrent();//Remove
                    racaTableAdapter.Update(masterDataSet.raca);//Salva
                    
                }
            }
            catch (Exception) //Captura o erro
            {
                racaTableAdapter.Fill(masterDataSet.raca);  

                MessageBox.Show("Registro não pode ser excluído!", "PetShop");
            }
        }
    }
}
