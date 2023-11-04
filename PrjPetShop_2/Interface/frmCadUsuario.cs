using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrjPetShop_2.Interface
{
    public partial class frmCadUsuario : Form
    {
        string IdSelecionado;

        public frmCadUsuario()
        {
            InitializeComponent();
        }

        /* private void LimparCampos()
            {
                txtNome.Text = "";
                txtLogin.Text = "";
                txtSenha.Text = "";
                txtConfirme.Text = "";

            }*/

        private void HabilitarCampos()
        {
            txtNome.Enabled = true;
            txtLogin.Enabled = true;
            txtSenha.Enabled = true;
            txtConfirme.Enabled = true;
            user_data_cadastroDateTimePicker.Enabled = true;
            pbFoto.Enabled = true;
            btnFotoUser.Enabled = true;
        }

        private void DesabilitarCampos()
        {
            txtNome.Enabled = false;
            txtLogin.Enabled = false;
            txtSenha.Enabled = false;
            txtConfirme.Enabled = false;
            user_data_cadastroDateTimePicker.Enabled = false;
            pbFoto.Enabled = false;
            btnFotoUser.Enabled = false;
        }

        private void usuarioBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.usuarioBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.masterDataSet);

        }

        private void frmCadUsuario_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'masterDataSet.Usuario'. Você pode movê-la ou removê-la conforme necessário.
            this.usuarioTableAdapter.Fill(this.masterDataSet.Usuario);

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            HabilitarCampos();
            //dicionar um novo item 
            usuarioBindingSource.AddNew();
            user_data_cadastroDateTimePicker.Text = DateTime.Now.ToShortDateString();

            btnExcluir.Enabled = false;
            btnEditar.Enabled = false;
            btnSalvar.Enabled = true;

            tabUsuario.SelectedTab = tabPage2;

            //gpbusuario.Enabled = true;  //Para liberar o GruopBox para adicionar um novo item
        }

        private void btnFotoUser_Click(object sender, EventArgs e)
        {
            try
            {
                //Para filtar as imagens que podem ser carregadas
                openFileDialog1.Filter = "Fotos (*.jpg; *.png;) | *.jpg; *.png";

                if (openFileDialog1.ShowDialog() == DialogResult.OK) //Para chamar a janela de escolha
                {
                    pbFoto.Image = new Bitmap(openFileDialog1.FileName);
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Erro ao carregar o arquivo de imagem", "PetShop", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            usuarioBindingSource.CancelEdit();
            tabUsuario.SelectedTab = tabPage1;


            DesabilitarCampos();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            //Tratamento de erro
            try //Tente
            {
                if (MessageBox.Show("Deseja mesmo excluir esse registro?", "PetShop", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    usuarioBindingSource.RemoveCurrent(); //Remover itens
                    usuarioTableAdapter.Update(masterDataSet.Usuario); //Salvar itens caso não possa ser apagado


                    DesabilitarCampos();
                }
            }
            catch (Exception)
            {

                usuarioTableAdapter.Fill(masterDataSet.Usuario);
                MessageBox.Show("O registro não pode ser excluído!", "PetShop");
            }
        }

        private void btnSalvar_Click_1(object sender, EventArgs e)
        {
            //Tratamento de erro
            try //Tente
            {
                this.Validate();
                this.usuarioBindingSource.EndEdit();
                usuarioTableAdapter.Update(masterDataSet.Usuario);
                //abControl1.Enabled = false;
                MessageBox.Show("Registro salvo com sucesso!", "PetShop");


                DesabilitarCampos();
                tabUsuario.SelectedTab = tabPage1;
            }
            catch (Exception) //Capture o erro
            {

                MessageBox.Show("Ocorreu um erro, verifique os valores informados!", "PetShop");
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

            HabilitarCampos();
        }



        private void txtNomeuUser_TextChanged(object sender, EventArgs e)
        {
            usuarioBindingSource.Filter = "user_nome_usuario like'" + txtNomeuUser.Text + "%'";
        }

        private void usuarioDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            IdSelecionado = usuarioDataGridView.CurrentRow.Cells[0].Value.ToString();

            tabUsuario.SelectedTab = tabPage2;
            HabilitarCampos();

            btnEditar.Enabled = true;
            btnExcluir.Enabled = true;
        }

    }
}
