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
    public partial class AdcionarLivros : Form
    {
        public AdcionarLivros()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void PictureCapa_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using (var tempImage = Image.FromFile(openFileDialog1.FileName))
                {
                    PictureCapa.Image = new Bitmap(tempImage);
                }
            }
        }
        private void AdcionarLivros_Load(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void BtnAutor_Click(object sender, EventArgs e)
        {
            CadastrarAutor product = new CadastrarAutor();
            this.Visible = false;
            product.ShowDialog();
            this.Visible = true;
        }

        private void TextNameClick(object sender, EventArgs e)
        {
            TextNome.Clear();
        }

        private void TextAutor_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextAutor_Click(object sender, EventArgs e)
        {
            TextAutor.Clear();
        }

        private void TextSinopse_Click(object sender, EventArgs e)
        {
            TextSinopse.Clear();
        }

        private void TextGêneroClick(object sender, EventArgs e)
        {
           
        }
        private void TextPáginasClick(object sender, EventArgs e)
        {
            TextPaginas.Clear();
        }

        private void TextAcabamento_Click(object sender, EventArgs e)
        {
           
        }

        private void TextPreço_Click(object sender, EventArgs e)
        {
            TextPreco.Clear();
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            string nome = TextNome.Text;
            string autor = TextAutor.Text;
            string sinopse = TextSinopse.Text;
            string preco = TextPreco.Text;
            string genero = ComboGênero.Text;
            string paginas = TextPaginas.Text;
            string acabamento = ComboAcabamento.Text;

            byte[] imagemBytes = null;
            if (PictureCapa.Image != null)
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    PictureCapa.Image.Save(ms, ImageFormat.Png);
                    imagemBytes = ms.ToArray();
                }
            }
            string conexao = "Server=sqlexpress;Database=CJ3027422PR2;User Id=aluno;Password=aluno";
            string sql = "INSERT INTO Livros2 (Nome, Autor, Sinopse, Preco, Genero, Paginas, Acabamento, Capa) VALUES (@Nome ,@Autor ,@Sinopse ,@Preco ,@Genero, @Paginas, @Acabamento, @Capa)";
            using (SqlConnection conn = new SqlConnection(conexao))
            {
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Nome", nome);
                    cmd.Parameters.AddWithValue("@Autor", autor);
                    cmd.Parameters.AddWithValue("@Sinopse", sinopse);
                    cmd.Parameters.AddWithValue("@Preco", preco);
                    cmd.Parameters.AddWithValue("@Genero", genero);
                    cmd.Parameters.AddWithValue("@Paginas", paginas);
                    cmd.Parameters.AddWithValue("@Acabamento", acabamento);
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
        }

        private void ComboGênero_Click(object sender, EventArgs e)
        {
           
        }

        private void ComboGênero_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
