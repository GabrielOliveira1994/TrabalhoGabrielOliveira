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
    public partial class ContaEmpresarialConfigurada : Form
    {
        public ContaEmpresarialConfigurada()
        {
            InitializeComponent();
        }

        private void BtnLivros_Click(object sender, EventArgs e)
        {
            AdcionarLivros product = new AdcionarLivros();
            this.Visible = false;
            product.ShowDialog();
            this.Visible = true;
        }
    }
}
