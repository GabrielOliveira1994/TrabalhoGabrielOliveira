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
    public partial class FrmLibrary : Form
    {
        public FrmLibrary()
        {
            InitializeComponent();
        }

        private void Lbl_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login2 product = new Login2();
            this.Visible = false;
            product.ShowDialog();
            this.Visible = true;
		}

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FrmLibrary_Load(object sender, EventArgs e)
        {

        }
    }
}
