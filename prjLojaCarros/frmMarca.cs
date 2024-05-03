using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace prjLojaCarros
{
    public partial class frmMarca : Form
    {
        int registroAtual = 0;
        int totalRegistros = 0;
        DataTable dtLoja = new DataTable();
        string connectionString = @"Server=prjLojaCarros.mssql.somee.com;Database=prjLojaCarros;User Id=paola_costa_SQLLogin_1;Password=3978r7mh59;";

        public frmMarca()
        {
            InitializeComponent();
        }

        private void frmMarca_Load(object sender, EventArgs e)
        {
            CarregarDados();
            ResetarControles();
        }

        private void CarregarDados()
        {
            dtLoja = new DataTable();
            string sql = "SELECT codMarca, marca FROM Marca";
            using (SqlConnection con = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(sql, con))
            {
                con.Open();
                try
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        dtLoja.Load(reader);
                        totalRegistros = dtLoja.Rows.Count;
                        if (totalRegistros > 0)
                        {
                            registroAtual = 0;
                            Navegar();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.Message);
                }
            }
        }

        private void Navegar()
        {
            if (totalRegistros > 0)
            {
                txtCodMarca.Text = dtLoja.Rows[registroAtual]["codMarca"].ToString();
                txtMarca.Text = dtLoja.Rows[registroAtual]["marca"].ToString();
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            txtCodMarca.Clear();
            txtMarca.Clear();
            txtMarca.Enabled = true;
            btnSalvar.Enabled = true;
            btnCancelar.Visible = true;
            DisableNavigation();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMarca.Text))
            {
                MessageBox.Show("Por favor, insira um nome para a marca.");
                return;
            }

            string sql = txtCodMarca.Text == "" ? "INSERT INTO Marca (marca) VALUES (@marca)" :
                                                  "UPDATE Marca SET marca = @marca WHERE codMarca = @codMarca";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@marca", txtMarca.Text);
                if (txtCodMarca.Text != "") cmd.Parameters.AddWithValue("@codMarca", txtCodMarca.Text);

                conn.Open();
                try
                {
                    int result = cmd.ExecuteNonQuery();
                    MessageBox.Show(result > 0 ? "Operação realizada com sucesso!" : "Operação falhou!");
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Erro ao acessar o banco de dados: " + ex.Message);
                }
            }
            CarregarDados();
            ResetarControles();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCodMarca.Text))
            {
                MessageBox.Show("Selecione uma marca para editar.");
                return;
            }
            txtMarca.Enabled = true;
            btnSalvar.Enabled = true;
            btnCancelar.Visible = true;
            DisableNavigation();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCodMarca.Text))
            {
                MessageBox.Show("Selecione uma marca para excluir.");
                return;
            }

            if (MessageBox.Show("Deseja excluir essa marca?", "Excluir Marca?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string sql = "DELETE FROM Marca WHERE codMarca = @codMarca";
                using (SqlConnection conn = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@codMarca", txtCodMarca.Text);
                    conn.Open();
                    try
                    {
                        int result = cmd.ExecuteNonQuery();
                        MessageBox.Show(result > 0 ? "Marca deletada com sucesso" : "Falha ao deletar marca.");
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("Erro ao deletar marca: " + ex.Message);
                    }
                }
                CarregarDados();
                ResetarControles();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            ResetarControles();
            Navegar();
        }

        private void btnPrimeiro_Click(object sender, EventArgs e)
        {
            if (registroAtual > 0)
            {
                registroAtual = 0;
                Navegar();
            }
        }

        private void btnUltimo_Click(object sender, EventArgs e)
        {
            if (registroAtual < totalRegistros - 1)
            {
                registroAtual = totalRegistros - 1;
                Navegar();
            }
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            if (registroAtual > 0)
            {
                registroAtual--;
                Navegar();
            }
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            if (registroAtual < totalRegistros - 1)
            {
                registroAtual++;
                Navegar();
            }
        }

        private void DisableNavigation()
        {
            btnNovo.Enabled = false;
            btnEditar.Enabled = false;
            btnExcluir.Enabled = false;
            btnAnterior.Enabled = false;
            btnProximo.Enabled = false;
            btnPrimeiro.Enabled = false;
            btnUltimo.Enabled = false;
        }

        private void ResetarControles()
        {
            btnNovo.Enabled = true;
            btnEditar.Enabled = true;
            btnExcluir.Enabled = true;
            btnSalvar.Enabled = false;
            btnCancelar.Visible = false;
            txtMarca.Enabled = false;
            btnAnterior.Enabled = true;
            btnProximo.Enabled = true;
            btnPrimeiro.Enabled = true;
            btnUltimo.Enabled = true;
        }
    }
}
