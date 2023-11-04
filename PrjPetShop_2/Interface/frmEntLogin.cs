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

namespace PrjPetShop_2.Interface
{
    public partial class frmEntLogin : Form
    {

        public frmEntLogin()
        {
            InitializeComponent();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {


            string user = "garcia2023";
              string pass = "123";

              if (txtLogin.Text == user & txtSenha.Text == pass)
              {
                  MessageBox.Show("Logado com sucesso!", "Liberado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                  Form1 frmMain = new Form1();
                  frmMain.Show();
                  this.Hide();
              }
              else
              {
                  MessageBox.Show("Login ou senha inválidos!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
              }


        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja mesmo sair?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            frmCriarConta criar = new frmCriarConta();
            criar.Show();
            this.Close();
        }

        private void usuarioBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.usuarioBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.masterDataSet);

        }

        private void frmEntLogin_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'masterDataSet.Usuario'. Você pode movê-la ou removê-la conforme necessário.
            this.usuarioTableAdapter.Fill(this.masterDataSet.Usuario);

        }
    }
}
