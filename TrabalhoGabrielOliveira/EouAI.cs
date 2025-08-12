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
    public partial class EouAI : Form
    {
        public EouAI()
        {
            InitializeComponent();
        }

        private void BtnEditora_Click(object sender, EventArgs e)
        {
            Configurar product = new Configurar();
            this.Visible = false;
            product.ShowDialog();
            this.Visible = true;
        }
    }
}
