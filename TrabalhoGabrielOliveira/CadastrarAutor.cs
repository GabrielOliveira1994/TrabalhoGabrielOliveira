using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
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
                using (var stream = new FileStream(openFileDialog2.FileName, FileMode.Open, FileAccess.Read))
                {
                    PictureFoto.Image = Image.FromStream(stream);
                }
            }
        }

        private void BtnSalvar2_Click(object sender, EventArgs e)
        {
            string biografia = TextBiografia.Text;
            string nome = TextAutor2.Text;

            string conexao = "Server=sqlexpress;Database=CJ3027422PR2;User Id=aluno;Password=aluno";
            string sql = "INSERT INTO Autor (Nome, Biografia) VALUES (@Nome ,@Biografia)";
            using (SqlConnection conn = new SqlConnection(conexao))
            {
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Nome", nome);
                    cmd.Parameters.AddWithValue("@Biografia", biografia);

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
