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
    public partial class frmCadCliente : Form
    {
        public frmCadCliente()
        {
            InitializeComponent();
        }

        private void clienteBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clienteBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.masterDataSet);

        }

        private void frmCadCliente_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'masterDataSet.Cliente'. Você pode movê-la ou removê-la conforme necessário.
            this.clienteTableAdapter.Fill(this.masterDataSet.Cliente);
            // TODO: esta linha de código carrega dados na tabela 'masterDataSet.Cliente'. Você pode movê-la ou removê-la conforme necessário.
            this.clienteTableAdapter.Fill(this.masterDataSet.Cliente);

        }

        private void clienteBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            //Tratamento de erro
            try //Tente
            {
                this.Validate();
                this.clienteBindingSource.EndEdit();
                clienteTableAdapter.Update(masterDataSet.Cliente);
                gpbCliente.Enabled = false;
                MessageBox.Show("Registro salvo com sucesso!", "PetShop");
            }
            catch (Exception) //Capture o erro
            {

                MessageBox.Show("Ocorreu um erro, verifique os valores informados!", "PetShop");
            }

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            //dicionar um novo item 
            clienteBindingSource.AddNew();
            gpbCliente.Enabled = true;  //Para liberar o GruopBox para adicionar um novo item
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            clienteBindingSource.CancelEdit();
            gpbCliente.Enabled=false;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            gpbCliente.Enabled = true;
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            //Tratamento de erro
            try //Tente
            {
                if (MessageBox.Show("Deseja mesmo excluir esse registro?", "PetShop", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    clienteBindingSource.RemoveCurrent(); //Remover itens
                    clienteTableAdapter.Update(masterDataSet.Cliente); //Salvar itens caso não possa ser apagado
                }
            }
            catch (Exception)
            {

                clienteTableAdapter.Fill(masterDataSet.Cliente);
                MessageBox.Show("O registro não pode ser excluído!", "PetShop");
            }
        }

        private void btnFoto_Click(object sender, EventArgs e)
        {
            try
            {
                //Para filtar as imagens que podem ser carregadas
                openFileDialog1.Filter = "Fotos (*.jpg; *.png;) | *.jpg; *.png";

                if (openFileDialog1.ShowDialog() == DialogResult.OK) //Para chamar a janela de escolha
                {
                    cli_fotoPictureBox.Image = new Bitmap(openFileDialog1.FileName);
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Erro ao carregar o arquivo de imagem", "PetShop", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            VariaveisGlobais.CodigoTroca = 0;
            frmPesquisarCliente pesquisar = new frmPesquisarCliente();
            pesquisar.ShowDialog();
            
            //Se ele encontrar algum registro
            if (VariaveisGlobais.CodigoTroca >0)
            {
                //Posiciona o código encontrado
                clienteBindingSource.Position = clienteBindingSource.Find("cli_codigo", VariaveisGlobais.CodigoTroca);
            }
        }
    }
}
