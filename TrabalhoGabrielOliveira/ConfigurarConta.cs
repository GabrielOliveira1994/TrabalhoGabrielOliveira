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
    public partial class ConfigurarConta : Form
    {
        private string nome;
        private string email;

        public ConfigurarConta(string Nome, string Email)
        {
            InitializeComponent();
            this.nome = Nome;
            this.email = Email;
        }

        private void ConfigurarConta_Load(object sender, EventArgs e)
        {
        }

        private void ConfigurarConta_Load_1(object sender, EventArgs e)
        {
            TextName2.Text = nome;
            TextEmail2.Text = email;
        }

        private void PictureIcon_Click(object sender, EventArgs e)
        {

        }
    }
}
