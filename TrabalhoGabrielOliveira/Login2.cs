using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace TrabalhoGabrielOliveira
{
    public partial class Login2 : Form
    {
        public Login2()
        {
            InitializeComponent();
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            TelaConfigurada product = new TelaConfigurada();
            this.Visible = false;
            product.ShowDialog();
            this.Visible = true;
        }

        private void BtnLogin2_Click(object sender, EventArgs e)
        {
            ConfigurarConta2 product = new ConfigurarConta2();
            this.Visible = false;
            product.ShowDialog();
            this.Visible = true;
        }

        private void BtnCE_Click(object sender, EventArgs e)
        {
            LoginEmpresarial product = new LoginEmpresarial();
            this.Visible = false;
            product.ShowDialog();
            this.Visible = true;
        }
    }
}
