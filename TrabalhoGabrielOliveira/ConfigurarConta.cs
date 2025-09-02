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
        public string NomeUsuario { get; set; }
        public string EmailUsuario { get; set; }

        public ConfigurarConta()
        {
            InitializeComponent();
        }

        private void ConfigurarConta_Load(object sender, EventArgs e)
        {
            TextName2.Text = NomeUsuario;
            TextEmail2.Text = EmailUsuario;
        }
    }
}
