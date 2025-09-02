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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void BtnCE_Click(object sender, EventArgs e)
        {
            EouAI product = new EouAI();
            this.Visible = false;
            product.ShowDialog();
            this.Visible = true;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void TextName1_Click(object sender, EventArgs e)
        {
            TextName.Clear();
        }

        private void TextEmail2_Click(object sender, EventArgs e)
        {
            TextEmail.Clear();
        }

        private void TextSenha3_Click(object sender, EventArgs e)
        {
            TextSenha.Clear();
        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            string Nome = TextName.Text;
            string Email = TextEmail.Text;
            string Senha = TextSenha.Text;


            string conexao = "Server=sqlexpress;Database=CJ3027422PR2;User Id=aluno;Password=aluno";
            string sql = "INSERT INTO  (Nome, Email, Senha) VALUES (@Nome, @Email, @Senha)";
            using (SqlConnection conn = new SqlConnection(conexao))
            {
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Nome", Nome);
                    cmd.Parameters.AddWithValue("@Email", Email);
                    cmd.Parameters.AddWithValue("@Senha", Senha);

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
                ConfigurarConta product = new ConfigurarConta();
                this.Visible = false;
                product.ShowDialog();
                this.Visible = true;
            }
        }
    }
}
