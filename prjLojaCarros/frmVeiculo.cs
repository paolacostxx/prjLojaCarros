using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace prjLojaCarros
{
    public partial class frmVeiculo : Form
    {
        int registroAtual = 0;
        int totalRegistros = 0;
        bool novo;
        DataTable modeloVeiculo = new DataTable();
        DataTable dtMarca = new DataTable();
        DataTable dtTipo = new DataTable();
        string connectionString = @"Server=prjLojaCarros.mssql.somee.com;Database=prjLojaCarros;User Id=paola_costa_SQLLogin_1;Password=3978r7mh59;";

        public frmVeiculo()
        {
            InitializeComponent();
        }

        private void frmVeiculo_Load(object sender, EventArgs e)
        {
            carregaComboTipo();
            carregaComboMarca();
            carregarDadosVeiculo();
            resetarControles();
            btnSalvar.Enabled = false;
            txtCodVeiculo.Enabled = false;
            txtVeiculo.Enabled = false;
            txtAnoVeiculo.Enabled = false;
            cbbTipo.Enabled = false;
            cbbMarca.Enabled = false;

            string sql = "SELECT codVeiculo, anoVeiculo, modeloVeiculo, tipo, marca " +
                        "FROM modeloVeiculo " +
                        "INNER JOIN tipo ON codTipo = codTipo " +
                        "INNER JOIN marca ON codMarca = codMarca ";
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
        }

        private void navegar()
        {
            if (modeloVeiculo.Rows.Count > 0 && registroAtual >= 0 && registroAtual < totalRegistros)
            {
                txtCodVeiculo.Text = modeloVeiculo.Rows[registroAtual]["codVeiculo"].ToString();
                txtAnoVeiculo.Text = modeloVeiculo.Rows[registroAtual]["anoVeiculo"].ToString();
                txtVeiculo.Text = modeloVeiculo.Rows[registroAtual]["modeloVeiculo"].ToString();
                cbbTipo.SelectedValue = modeloVeiculo.Rows[registroAtual]["codTipo"];
                cbbMarca.SelectedValue = modeloVeiculo.Rows[registroAtual]["codMarca"];
            }
        }

        private void carregarDadosVeiculo()
        {
            modeloVeiculo = new DataTable();
            string sql = @"SELECT codVeiculo,modeloVeiculo, anoVeiculo, codMarca, codTipo ";
            using (SqlConnection con = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(sql, con))
            {
                con.Open();
                try
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        modeloVeiculo.Load(reader);
                        totalRegistros = modeloVeiculo.Rows.Count;
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

        private void carregaCombo(string sql, DataTable dt, ComboBox cbb, string displayMember, string valueMember)
        {
            dt.Clear();
            using (SqlConnection con = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(sql, con))
            {
                con.Open();
                try
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        dt.Load(reader);
                        cbb.DisplayMember = displayMember;
                        cbb.ValueMember = valueMember;
                        cbb.DataSource = dt; 
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro: " + ex.ToString());
                }
            }
        }


        private void carregaComboMarca()
        {
            dtMarca = new DataTable();
            string sql = "SELECT * from Marca";
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.CommandType = CommandType.Text;
            SqlDataReader reader;
            con.Open();
            try
            {
                using (reader = cmd.ExecuteReader())
                {
                    dtMarca.Load(reader);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro: " + ex.ToString());
            }
            finally
            {
                con.Close();
            }
            cbbMarca.DataSource = dtMarca;
            cbbMarca.DisplayMember = "marca";
            cbbMarca.ValueMember = "marca";
        }

        private void carregaComboTipo()
        {
            string sql = "SELECT codTipo, tipo FROM Tipo";
            carregaCombo(sql, dtTipo, cbbTipo, "tipo", "codTipo");
        }


        private void resetarControles()
        {
            txtCodVeiculo.Enabled = false;
            txtVeiculo.Enabled = false;
            txtAnoVeiculo.Enabled = false;
            cbbTipo.Enabled = false;
            cbbMarca.Enabled = false;
            btnSalvar.Enabled = false;
            btnNovo.Enabled = true;
            btnEditar.Enabled = true;
            btnExcluir.Enabled = true;
            btnPrimeiro.Enabled = true;
            btnAnterior.Enabled = true;
            btnProximo.Enabled = true;
            btnUltimo.Enabled = true;
        }

        private void cbbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
