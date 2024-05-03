
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace prjLojaCarros
{
    partial class frmVeiculo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtCodVeiculo = new System.Windows.Forms.TextBox();
            this.txtVeiculo = new System.Windows.Forms.TextBox();
            this.lblCodVeiculo = new System.Windows.Forms.Label();
            this.lblNomeVeiculo = new System.Windows.Forms.Label();
            this.cbbTipo = new System.Windows.Forms.ComboBox();
            this.cbbMarca = new System.Windows.Forms.ComboBox();
            this.gbbTipo = new System.Windows.Forms.GroupBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.gbbMarca = new System.Windows.Forms.GroupBox();
            this.lblAno = new System.Windows.Forms.Label();
            this.txtAnoVeiculo = new System.Windows.Forms.TextBox();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnPrimeiro = new System.Windows.Forms.Button();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.btnProximo = new System.Windows.Forms.Button();
            this.btnUltimo = new System.Windows.Forms.Button();
            this.gbbTipo.SuspendLayout();
            this.gbbMarca.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCodVeiculo
            // 
            this.txtCodVeiculo.Location = new System.Drawing.Point(141, 70);
            this.txtCodVeiculo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCodVeiculo.Name = "txtCodVeiculo";
            this.txtCodVeiculo.Size = new System.Drawing.Size(71, 22);
            this.txtCodVeiculo.TabIndex = 0;
            // 
            // txtVeiculo
            // 
            this.txtVeiculo.Location = new System.Drawing.Point(321, 66);
            this.txtVeiculo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtVeiculo.Name = "txtVeiculo";
            this.txtVeiculo.Size = new System.Drawing.Size(213, 22);
            this.txtVeiculo.TabIndex = 1;
            // 
            // lblCodVeiculo
            // 
            this.lblCodVeiculo.AutoSize = true;
            this.lblCodVeiculo.Location = new System.Drawing.Point(28, 73);
            this.lblCodVeiculo.Name = "lblCodVeiculo";
            this.lblCodVeiculo.Size = new System.Drawing.Size(99, 16);
            this.lblCodVeiculo.TabIndex = 2;
            this.lblCodVeiculo.Text = "Código Veículo";
            // 
            // lblNomeVeiculo
            // 
            this.lblNomeVeiculo.AutoSize = true;
            this.lblNomeVeiculo.Location = new System.Drawing.Point(257, 70);
            this.lblNomeVeiculo.Name = "lblNomeVeiculo";
            this.lblNomeVeiculo.Size = new System.Drawing.Size(52, 16);
            this.lblNomeVeiculo.TabIndex = 3;
            this.lblNomeVeiculo.Text = "Veículo";
            // 
            // cbbTipo
            // 
            this.cbbTipo.FormattingEnabled = true;
            this.cbbTipo.Location = new System.Drawing.Point(33, 43);
            this.cbbTipo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbTipo.Name = "cbbTipo";
            this.cbbTipo.Size = new System.Drawing.Size(213, 24);
            this.cbbTipo.TabIndex = 4;
            this.cbbTipo.SelectedIndexChanged += new System.EventHandler(this.cbbTipo_SelectedIndexChanged);
            // 
            // cbbMarca
            // 
            this.cbbMarca.FormattingEnabled = true;
            this.cbbMarca.Location = new System.Drawing.Point(47, 43);
            this.cbbMarca.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbMarca.Name = "cbbMarca";
            this.cbbMarca.Size = new System.Drawing.Size(213, 24);
            this.cbbMarca.TabIndex = 7;
            // 
            // gbbTipo
            // 
            this.gbbTipo.Controls.Add(this.cbbTipo);
            this.gbbTipo.Location = new System.Drawing.Point(15, 154);
            this.gbbTipo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbbTipo.Name = "gbbTipo";
            this.gbbTipo.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbbTipo.Size = new System.Drawing.Size(301, 102);
            this.gbbTipo.TabIndex = 8;
            this.gbbTipo.TabStop = false;
            this.gbbTipo.Text = "Tipo";
            // 
            // gbbMarca
            // 
            this.gbbMarca.Controls.Add(this.cbbMarca);
            this.gbbMarca.Location = new System.Drawing.Point(336, 154);
            this.gbbMarca.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbbMarca.Name = "gbbMarca";
            this.gbbMarca.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbbMarca.Size = new System.Drawing.Size(301, 102);
            this.gbbMarca.TabIndex = 9;
            this.gbbMarca.TabStop = false;
            this.gbbMarca.Text = "Marca";
            // 
            // lblAno
            // 
            this.lblAno.AutoSize = true;
            this.lblAno.Location = new System.Drawing.Point(28, 111);
            this.lblAno.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAno.Name = "lblAno";
            this.lblAno.Size = new System.Drawing.Size(31, 16);
            this.lblAno.TabIndex = 10;
            this.lblAno.Text = "Ano";
            // 
            // txtAnoVeiculo
            // 
            this.txtAnoVeiculo.Location = new System.Drawing.Point(84, 107);
            this.txtAnoVeiculo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAnoVeiculo.Name = "txtAnoVeiculo";
            this.txtAnoVeiculo.Size = new System.Drawing.Size(132, 22);
            this.txtAnoVeiculo.TabIndex = 11;
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(47, 15);
            this.btnNovo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(100, 28);
            this.btnNovo.TabIndex = 12;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(155, 15);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(100, 28);
            this.btnEditar.TabIndex = 13;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(263, 15);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(100, 28);
            this.btnExcluir.TabIndex = 14;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(371, 15);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(100, 28);
            this.btnSalvar.TabIndex = 15;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(479, 15);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 28);
            this.btnCancelar.TabIndex = 16;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnPrimeiro
            // 
            this.btnPrimeiro.Location = new System.Drawing.Point(48, 288);
            this.btnPrimeiro.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPrimeiro.Name = "btnPrimeiro";
            this.btnPrimeiro.Size = new System.Drawing.Size(61, 28);
            this.btnPrimeiro.TabIndex = 17;
            this.btnPrimeiro.Text = "<<";
            this.btnPrimeiro.UseVisualStyleBackColor = true;
            this.btnPrimeiro.Click += new System.EventHandler(this.btnPrimeiro_Click);
            // 
            // btnAnterior
            // 
            this.btnAnterior.Location = new System.Drawing.Point(191, 288);
            this.btnAnterior.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(61, 28);
            this.btnAnterior.TabIndex = 18;
            this.btnAnterior.Text = "<";
            this.btnAnterior.UseVisualStyleBackColor = true;
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // btnProximo
            // 
            this.btnProximo.Location = new System.Drawing.Point(335, 288);
            this.btnProximo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnProximo.Name = "btnProximo";
            this.btnProximo.Size = new System.Drawing.Size(61, 28);
            this.btnProximo.TabIndex = 19;
            this.btnProximo.Text = ">";
            this.btnProximo.UseVisualStyleBackColor = true;
            this.btnProximo.Click += new System.EventHandler(this.btnProximo_Click);
            // 
            // btnUltimo
            // 
            this.btnUltimo.Location = new System.Drawing.Point(479, 288);
            this.btnUltimo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUltimo.Name = "btnUltimo";
            this.btnUltimo.Size = new System.Drawing.Size(61, 28);
            this.btnUltimo.TabIndex = 20;
            this.btnUltimo.Text = ">>";
            this.btnUltimo.UseVisualStyleBackColor = true;
            this.btnUltimo.Click += new System.EventHandler(this.btnUltimo_Click);
            // 
            // frmVeiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 331);
            this.Controls.Add(this.btnUltimo);
            this.Controls.Add(this.btnProximo);
            this.Controls.Add(this.btnAnterior);
            this.Controls.Add(this.btnPrimeiro);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnNovo);
            this.Controls.Add(this.txtAnoVeiculo);
            this.Controls.Add(this.lblAno);
            this.Controls.Add(this.gbbMarca);
            this.Controls.Add(this.lblNomeVeiculo);
            this.Controls.Add(this.lblCodVeiculo);
            this.Controls.Add(this.txtVeiculo);
            this.Controls.Add(this.txtCodVeiculo);
            this.Controls.Add(this.gbbTipo);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmVeiculo";
            this.Text = "Cadastro de Veiculos";
            this.Load += new System.EventHandler(this.frmVeiculo_Load);
            this.gbbTipo.ResumeLayout(false);
            this.gbbMarca.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void btnUltimo_Click(object sender, EventArgs e)
        {
            registroAtual = totalRegistros - 1;
            navegar();
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            if (registroAtual < totalRegistros - 1)
            {
                registroAtual++;
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

        private void btnPrimeiro_Click(object sender, EventArgs e)
        {
            registroAtual = 0;
            navegar();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtVeiculo.Text) || string.IsNullOrEmpty(txtAnoVeiculo.Text))
            {
                MessageBox.Show("Por favor, preencha todos os campos necessários.");
                return;
            }

            string sql = string.IsNullOrEmpty(txtCodVeiculo.Text) ?
                "INSERT INTO Veiculo (modeloVeiculo, anoVeiculo, codTipo, codMarca) VALUES (@Modelo, @Ano, @Tipo, @Marca);" :
                "UPDATE Veiculo SET modeloVeiculo = @Modelo, anoVeiculo = @Ano, codTipo = @Tipo, codMarca = @Marca WHERE codVeiculo = @Id;";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@Modelo", txtVeiculo.Text);
                cmd.Parameters.AddWithValue("@Ano", txtAnoVeiculo.Text);
                cmd.Parameters.AddWithValue("@Tipo", cbbTipo.SelectedValue);
                cmd.Parameters.AddWithValue("@Marca", cbbMarca.SelectedValue);
                if (!string.IsNullOrEmpty(txtCodVeiculo.Text))
                {
                    cmd.Parameters.AddWithValue("@Id", txtCodVeiculo.Text);
                }

                conn.Open();
                try
                {
                    int result = cmd.ExecuteNonQuery();
                    MessageBox.Show(result > 0 ? "Operação realizada com sucesso!" : "Operação falhou!");
                    carregarDadosVeiculo();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Erro ao acessar o banco de dados: " + ex.Message);
                }
            }
            resetarControles();
        }


        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCodVeiculo.Text))
            {
                MessageBox.Show("Selecione um veículo para excluir.");
                return;
            }

            if (MessageBox.Show("Deseja excluir este veículo?", "Excluir Veículo?", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                string sql = "DELETE FROM modeloVeiculo WHERE codVeiculo = @Id;";
                using (SqlConnection conn = new SqlConnection(connectionString))
                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Id", txtCodVeiculo.Text);

                    conn.Open();
                    try
                    {
                        int result = cmd.ExecuteNonQuery();
                        MessageBox.Show(result > 0 ? "Veículo deletado com sucesso" : "Falha ao deletar veículo.");
                        carregarDadosVeiculo();
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("Erro ao deletar veículo: " + ex.Message);
                    }
                }
            }
            resetarControles();
        }
        private void btnEditar_Click(object sender, EventArgs e)
        {
            txtVeiculo.Enabled = true;
            txtAnoVeiculo.Enabled = true;
            cbbTipo.Enabled = true;
            cbbMarca.Enabled = true;
            btnSalvar.Enabled = true;
            btnCancelar.Enabled = true;
            btnNovo.Enabled = false;
            btnEditar.Enabled = false;
            btnExcluir.Enabled = false;
            btnPrimeiro.Enabled = false;
            btnUltimo.Enabled = false;
            btnAnterior.Enabled = false;
            btnProximo.Enabled = false;
            txtVeiculo.Focus();
        }



        private void btnNovo_Click(object sender, EventArgs e)
        {
            txtCodVeiculo.Clear();
            txtVeiculo.Clear();
            txtAnoVeiculo.Clear();
            cbbTipo.SelectedIndex = -1;
            cbbMarca.SelectedIndex = -1;
            txtVeiculo.Enabled = true;
            txtAnoVeiculo.Enabled = true;
            cbbTipo.Enabled = true;
            cbbMarca.Enabled = true;
            btnSalvar.Enabled = true;
            btnCancelar.Enabled = true;
        }

        #endregion

        private System.Windows.Forms.TextBox txtCodVeiculo;
        private System.Windows.Forms.TextBox txtVeiculo;
        private System.Windows.Forms.Label lblCodVeiculo;
        private System.Windows.Forms.Label lblNomeVeiculo;
        private System.Windows.Forms.ComboBox cbbTipo;
        private System.Windows.Forms.ComboBox cbbMarca;
        private System.Windows.Forms.GroupBox gbbTipo;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox gbbMarca;
        private System.Windows.Forms.Label lblAno;
        private System.Windows.Forms.TextBox txtAnoVeiculo;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnPrimeiro;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.Button btnProximo;
        private System.Windows.Forms.Button btnUltimo;
    }
}