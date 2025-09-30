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
    public partial class TelaConfigurada : Form
    {
        public TelaConfigurada()
        {
            InitializeComponent();
        }

        private void TelaConfigurada_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void BtnTelaInicial_Click(object sender, EventArgs e)
        {

		}
			private int _idCliente;

			public TelaConfigurada(int idCliente)
			{
				InitializeComponent();
				_idCliente = idCliente;
				CarregarDadosCliente();
			}

			private void CarregarDadosCliente()
			{
				string conexao = "Server=sqlexpress;Database=CJ3027422PR2;User Id=aluno;Password=aluno";
				string sql = "SELECT IDCLIENTE, Nome, Email, Senha, Telefone, Icon FROM Clientes2 WHERE IDCLIENTE = @IdCliente";

				using (SqlConnection conn = new SqlConnection(conexao))
				{
					using (SqlCommand cmd = new SqlCommand(sql, conn))
					{
						cmd.Parameters.AddWithValue("@IdCliente", _idCliente);

						try
						{
							conn.Open();
							using (SqlDataReader reader = cmd.ExecuteReader())
							{
								if (reader.Read())
								{
									LabelNome.Text = reader["Nome"].ToString();
									LabelEmail.Text = reader["Email"].ToString();
									LabelTelefone.Text = reader["Telefone"].ToString();

									if (reader["Icon"] != DBNull.Value)
									{
										byte[] imgBytes = (byte[])reader["Icon"];
										using (MemoryStream ms = new MemoryStream(imgBytes))
										{
											pictureBoxPerfil.Image = Image.FromStream(ms);
										}
									}
								}
							}
						}
						catch (Exception ex)
						{
							MessageBox.Show("Erro ao carregar dados: " + ex.Message);
						}
					}
				}
			}
		}
	}
