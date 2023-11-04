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
    public partial class frmCriarConta : Form
    {
        public frmCriarConta()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            
        }

        private void frmCriarConta_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            frmEntLogin login = new frmEntLogin();  
            login.ShowDialog(); 
        }
    }
}
