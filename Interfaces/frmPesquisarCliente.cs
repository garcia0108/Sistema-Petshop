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
    public partial class frmPesquisarCliente : Form
    {
        public frmPesquisarCliente()
        {
            InitializeComponent();
        }

        private void clienteBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.clienteBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.masterDataSet);

        }

        private void frmPesquisarCliente_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'masterDataSet.Cliente'. Você pode movê-la ou removê-la conforme necessário.
            this.clienteTableAdapter.Fill(this.masterDataSet.Cliente);

        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            clienteBindingSource.Filter = "cli_nome like '" + txtNome.Text + "%'";
        }

        private void clienteDataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                VariaveisGlobais.CodigoTroca = int.Parse(clienteDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString());
            }
            catch (Exception)
            {

                VariaveisGlobais.CodigoTroca = 0;
            }
            this.Dispose();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            //Para descarregar o form
            this.Dispose();
        }
    }
}
