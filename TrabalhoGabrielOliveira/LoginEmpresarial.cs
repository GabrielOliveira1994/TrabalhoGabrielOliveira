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
    public partial class LoginEmpresarial : Form
    {
        public LoginEmpresarial()
        {
            InitializeComponent();
        }

        private void BtnEditora_Click(object sender, EventArgs e)
        {
        }

        private void TextName_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnEntrar_Click(object sender, EventArgs e)
        {
            ContaEmpresarialConfigurada product = new ContaEmpresarialConfigurada();
            this.Visible = false;
            product.ShowDialog();
            this.Visible = true;
        }

        private void BtnCadastro_Click(object sender, EventArgs e)
        {
            CadastroEmpresarial product = new CadastroEmpresarial();
            this.Visible = false;
            product.ShowDialog();
            this.Visible = true;
        }

        private void TextName_Click(object sender, EventArgs e)
        {
			TextName.Clear();
		}

        private void TextSenha_Click(object sender, EventArgs e)
        {
			TextSenha.Clear();
		}
    }
}
