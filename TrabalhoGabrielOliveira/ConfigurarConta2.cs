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
            string sql = "INSERT INTO Livros2 (Nome, Email, Senha, Telefone) VALUES (@Nome ,@Email ,@Senha ,@Telefone)";
            using (SqlConnection conn = new SqlConnection(conexao))
            {
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Nome", nome);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@Senha", senha);
                    cmd.Parameters.AddWithValue("@Telefone", telefone);
                    cmd.Parameters.AddWithValue("@Capa", (object)imagemBytes ?? DBNull.Value);

                    try
                    {
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Dados salvos com sucesso!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Erro ao salvar: " + ex.Message);
                    }
                }
            }
        TelaConfigurada product = new TelaConfigurada();
            this.Visible = false;
            product.ShowDialog();
            this.Visible = true;
        }
    }
}