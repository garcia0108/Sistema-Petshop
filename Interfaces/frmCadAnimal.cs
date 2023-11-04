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
    public partial class frmCadAnimal : Form
    {
        public frmCadAnimal()
        {
            InitializeComponent();
        }

        private void animalBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.animalBindingSource.EndEdit();
                animalTableAdapter.Update(masterDataSet.animal);
                gpbAnimal.Enabled = false;

                MessageBox.Show("Registro salvo com sucesso!", "PetShop");
            }
            catch (Exception)
            {

                MessageBox.Show("Ocorreu um erro, verifique os valores informado!", "PetShop");
            }

        }

        private void frmCadAnimal_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'masterDataSet.raca'. Você pode movê-la ou removê-la conforme necessário.
            this.racaTableAdapter.Fill(this.masterDataSet.raca);
            // TODO: esta linha de código carrega dados na tabela 'masterDataSet.Cliente'. Você pode movê-la ou removê-la conforme necessário.
            this.clienteTableAdapter.Fill(this.masterDataSet.Cliente);
            // TODO: esta linha de código carrega dados na tabela 'masterDataSet.animal'. Você pode movê-la ou removê-la conforme necessário.
            this.animalTableAdapter.Fill(this.masterDataSet.animal);

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            animalBindingSource.AddNew();
            gpbAnimal.Enabled = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            animalBindingSource.CancelEdit();
            gpbAnimal.Enabled = false;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            gpbAnimal.Enabled = true;
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Deseja mesmo excluir esse registro?", "PetShop", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    animalBindingSource.RemoveCurrent();
                    animalTableAdapter.Update(masterDataSet.animal);
                }
            }
            catch (Exception)
            {

                animalTableAdapter.Fill(masterDataSet.animal);
                MessageBox.Show("O registro não pode ser excluído!", "PetShop");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog1.Filter = "Fotos (*.jpg; *.png) | *.jpg; *.png";
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    ani_fotoPictureBox.Image = new Bitmap(openFileDialog1.FileName);    
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Erro ao carregar o arquivo de imagem", "PetShop", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
