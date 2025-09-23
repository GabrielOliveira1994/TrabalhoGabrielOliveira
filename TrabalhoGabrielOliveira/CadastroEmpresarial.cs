using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabalhoGabrielOliveira
{
    public partial class CadastroEmpresarial : Form
    {
        public CadastroEmpresarial()
        {
            InitializeComponent();
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            ContaEmpresarialConfigurada product = new ContaEmpresarialConfigurada();
            this.Visible = false;
            product.ShowDialog();
            this.Visible = true;
        }
    }
}
