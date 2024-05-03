using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace prjLojaCarros
{
    public partial class frmTipo : Form
    {
        int registroAtual = 0;
        int totalRegistros = 0;
        DataTable dtLoja = new DataTable();
        string connectionString = @"Server=prjLojaCarros.mssql.somee.com;Database=prjLojaCarros;User Id=paola_costa_SQLLogin_1;Password=3978r7mh59;";

        public frmTipo()
        {
            InitializeComponent();
        }

        private void frmTipo_Load(object sender, EventArgs e)
        {
            carregar();
            resetarControles();
        }

        private void navegar()
        {
            if (dtLoja.Rows.Count > 0)
            {
                txtCodTipo.Text = dtLoja.Rows[registroAtual]["codTipo"].ToString();
                txtTipo.Text = dtLoja.Rows[registroAtual]["tipo"].ToString();
            }
        }

        private void carregar()
        {
            dtLoja = new DataTable();
            string sql = "SELECT codTipo, tipo FROM Tipo";
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
                        registroAtual = 0;
                        navegar();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.ToString());
                }
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            txtCodTipo.Text = "";
            txtTipo.Text = "";
            txtTipo.Enabled = true;
            btnSalvar.Enabled = true;
            btnCancelar.Visible = true;
            btnEditar.Enabled = false;
            btnExcluir.Enabled = false;
            btnNovo.Enabled = false;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTipo.Text))
            {
                MessageBox.Show("Por favor, preencha o campo Tipo.");
                return;
            }

            string sql = "INSERT INTO Tipo (tipo) VALUES (@Tipo)";
            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@Tipo", txtTipo.Text);
                conn.Open();
                try
                {
                    int i = cmd.ExecuteNonQuery();
                    if (i > 0)
                    {
                        MessageBox.Show("Tipo cadastrado com sucesso");
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Erro ao cadastrar tipo: " + ex);
                }
            }
            carregar();
            resetarControles();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            txtTipo.Enabled = true;
            btnAtualizar.Visible = true;
            btnCancelar.Visible = true;
            btnEditar.Enabled = false;
            btnExcluir.Enabled = false;
            btnNovo.Enabled = false;
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            string sql = "UPDATE Tipo SET tipo = @Tipo WHERE codTipo = @CodTipo";
            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@Tipo", txtTipo.Text);
                cmd.Parameters.AddWithValue("@CodTipo", txtCodTipo.Text);
                conn.Open();
                try
                {
                    int i = cmd.ExecuteNonQuery();
                    if (i > 0)
                    {
                        MessageBox.Show("Tipo atualizado com sucesso");
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Erro ao atualizar tipo: " + ex);
                }
            }
            carregar();
            resetarControles();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja excluir esse tipo?", "Excluir Tipo?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string sql = "DELETE FROM Tipo WHERE codTipo = @CodTipo";
                using (SqlConnection conn = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@CodTipo", txtCodTipo.Text);
                    conn.Open();
                    try
                    {
                        int i = cmd.ExecuteNonQuery();
                        if (i > 0)
                        {
                            MessageBox.Show("Tipo deletado com sucesso");
                        }
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("Erro ao deletar tipo: " + ex);
                    }
                }
                carregar();
                resetarControles();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            resetarControles();
            navegar();
        }

        private void btnPrimeiro_Click(object sender, EventArgs e)
        {
            if (registroAtual > 0)
            {
                registroAtual = 0;
                navegar();
            }
        }

        private void btnUltimo_Click(object sender, EventArgs e)
        {
            if (registroAtual < totalRegistros - 1)
            {
                registroAtual = totalRegistros - 1;
                navegar();
            }
        }

        private void btnAnterior_Click(object sender, EventArgs e)
        {
            if (registroAtual > 0)
            {
                registroAtual--;
                navegar();
            }
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            if (registroAtual < totalRegistros - 1)
            {
                registroAtual++;
                navegar();
            }
        }

        private void resetarControles()
        {
            txtCodTipo.Enabled = false;
            txtTipo.Enabled = false;
            btnSalvar.Enabled = false;
            btnAtualizar.Visible = false;
            btnCancelar.Visible = false;
            btnNovo.Enabled = true;
            btnEditar.Enabled = true;
            btnExcluir.Enabled = true;
        }

        private void txtCodTipo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
