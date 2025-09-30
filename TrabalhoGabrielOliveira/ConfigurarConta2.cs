using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabalhoGabrielOliveira
{
    public partial class ConfigurarConta2 : Form
    {
        public ConfigurarConta2()
        {
            InitializeComponent();
        }

        private void PictureIcon_Click(object sender, EventArgs e)
        {
            if (openFileDialog3.ShowDialog() == DialogResult.OK)
            {
                using (var tempImage = Image.FromFile(openFileDialog3.FileName))
                {
                    PictureIcon.Image = new Bitmap(tempImage);
                }
            }
        }

		private void SalvarConfiguração_Click(object sender, EventArgs e)
		{
			string nome = TextName2.Text;
			string email = TextEmail2.Text;
			string senha = TextSenha.Text;
			string confirmarSenha = TextConfirmarSenha.Text;
			string telefone = TextTelefone.Text;

			if (senha != confirmarSenha)
			{
				MessageBox.Show("As senhas não coincidem. Por favor, verifique.");
				return;
			}

			byte[] imagemBytes = null;
			if (PictureIcon.Image != null)
			{
				using (MemoryStream ms = new MemoryStream())
				{
					PictureIcon.Image.Save(ms, ImageFormat.Png);
					imagemBytes = ms.ToArray();
				}
			}

			string conexao = "Server=sqlexpress;Database=CJ3027422PR2;User Id=aluno;Password=aluno";
			string sql = "INSERT INTO Clientes2 (Nome, Email, Senha, Telefone, Icon) VALUES (@Nome, @Email, @Senha, @Telefone, @icon); SELECT SCOPE_IDENTITY();";

			int idClienteInserido = 0;

			using (SqlConnection conn = new SqlConnection(conexao))
			{
				using (SqlCommand cmd = new SqlCommand(sql, conn))
				{
					cmd.Parameters.AddWithValue("@Nome", nome);
					cmd.Parameters.AddWithValue("@Email", email);
					cmd.Parameters.AddWithValue("@Senha", senha);
					cmd.Parameters.AddWithValue("@Telefone", telefone);
					cmd.Parameters.AddWithValue("@Icon", (object)imagemBytes ?? DBNull.Value);

					try
					{
						conn.Open();
						idClienteInserido = Convert.ToInt32(cmd.ExecuteScalar());
						MessageBox.Show("Dados salvos com sucesso!");
					}
					catch (Exception ex)
					{
						MessageBox.Show("Erro ao salvar: " + ex.Message);
						return;
					}
				}
			}
			TelaConfigurada telaConfigurada = new TelaConfigurada(idClienteInserido);
			this.Visible = false;
			telaConfigurada.ShowDialog();
			this.Visible = true;
		}


		private void TextName2_Click(object sender, EventArgs e)
        {
			TextName2.Clear();
		}

        private void TextSenha_Click(object sender, EventArgs e)
        {
			TextSenha.Clear();
		}

        private void TextConfirmarSenha_Click(object sender, EventArgs e)
        {
			TextConfirmarSenha.Clear();
		}

        private void TextEmail2_Click(object sender, EventArgs e)
        {
			TextEmail2.Clear();
		}

        private void TextTelefone_Click(object sender, EventArgs e)
        {
			TextTelefone.Clear();
		}

        private void ConfigurarConta2_Load(object sender, EventArgs e)
        {

        }
    }
}