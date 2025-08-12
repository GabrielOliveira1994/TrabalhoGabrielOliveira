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
                using (var stream = new FileStream(openFileDialog1.FileName, FileMode.Open, FileAccess.Read))
                {
                    PictureCapa.Image = Image.FromStream(stream);
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
            TextGênero.Clear();
        }
        private void TextPáginasClick(object sender, EventArgs e)
        {
            TextPaginas.Clear();
        }

        private void TextAcabamento_Click(object sender, EventArgs e)
        {
            TextAcabamento.Clear();
        }

        private void TextPreço_Click(object sender, EventArgs e)
        {
            TextPreço.Clear();
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            string nome = TextNome.Text;
            string autor = TextAutor.Text;
            string sinopse = TextSinopse.Text;
            string preço = TextPreço.Text;
            string gênero = TextGênero.Text;
            string paginas = TextPaginas.Text;
            string acabamento = TextAcabamento.Text;

            string conexao = Server = sqlexpress; Database = CJ3027422PR2; User Id = aluno; Password = aluno;
            string sql = INSERT INTO Livros (Nome, Autor, Sinopse, Preço, Gênero, Acabamento) VALUES (@Nome, @Autor, @Sinopse, @Preço, @Gênero, @Acabamento);
            using (SqlConnection conn = new SqlConnection(conexao))
            {
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Nome", txtNome.Text);
                    cmd.Parameters.AddWithValue("@Email", txtEmail.Text);

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
