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
    public partial class CadastrarAutor : Form
    {
        public CadastrarAutor()
        {
            InitializeComponent();
        }

        private void TextAutor2_Click(object sender, EventArgs e)
        {
            TextAutor2.Clear();
        }

        private void TextBiografia_Click(object sender, EventArgs e)
        {
            TextBiografia.Clear();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (openFileDialog2.ShowDialog() == DialogResult.OK)
            {
                using (var tempImage = Image.FromFile(openFileDialog2.FileName))
                {
                    PictureFoto.Image = new Bitmap(tempImage);
                }
            }
        }

        private void BtnSalvar2_Click(object sender, EventArgs e)
        {
            string biografia = TextBiografia.Text;
            string nome = TextAutor2.Text;

            byte[] imagemBytes = null;
            if (PictureFoto.Image != null)
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    PictureFoto.Image.Save(ms, ImageFormat.Png);
                    imagemBytes = ms.ToArray();
                }
            }

            string conexao = "Server=sqlexpress;Database=CJ3027422PR2;User Id=aluno;Password=aluno";
            string sql = "INSERT INTO Autor (Nome, Biografia, Foto) VALUES (@Nome ,@Biografia, @Foto)";
            using (SqlConnection conn = new SqlConnection(conexao))
            {
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Nome", nome);
                    cmd.Parameters.AddWithValue("@Biografia", biografia);
                    cmd.Parameters.AddWithValue("@Foto", (object)imagemBytes ?? DBNull.Value);

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
        }
    }
}
