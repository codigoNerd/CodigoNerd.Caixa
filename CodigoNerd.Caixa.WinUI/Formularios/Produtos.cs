using CodigoNerd.Caixa.WinUI.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodigoNerd.Caixa.WinUI.Formularios
{
    public partial class Produtos : Form
    {
        public Produtos()
        {
            InitializeComponent();
            dgvProdutos.AutoGenerateColumns = false;
           
            ModoEscrita = false;
            AtualizarGrid();
        }

        private bool ModoEscrita
        {
            set
            {
                LimparFormulario();
                ControlarEscritaFormulario(value);
                ControlarBarraBotoes(value);
                if (!value)
                {
                    _produtoCorrente = null;
                }
            }
        }

        private void AtualizarGrid()
        {
            dgvProdutos.DataSource = null;
            dgvProdutos.DataSource = Produto.Listar();
        }

        private void LimparFormulario()
        {
            txtCodigo.Clear();
            txtNome.Clear();
            txtPreco.ResetText();
            txtPeso.ResetText();
        }
        private void ControlarEscritaFormulario(bool modoEscrita)
        {
            txtCodigo.Enabled =
            txtNome.Enabled =
            txtPreco.Enabled =
            txtPeso.Enabled = modoEscrita;
        }

        private void ControlarBarraBotoes(bool modoEscrita)
        {
            btnNovo.Enabled = !modoEscrita;
            btnSalvar.Enabled = 
            btnCancelar.Enabled = modoEscrita;
            btnExcluir.Enabled = modoEscrita && _produtoCorrente.Id > 0;
        }

        private Produto _produtoCorrente;
        
        private void btnNovo_Click(object sender, EventArgs e)
        {
            _produtoCorrente = new Produto();
            ModoEscrita = true;
            txtCodigo.Focus();
        }
           
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (ValidarFormulario())
            {
                LerFormulario();
                _produtoCorrente.Salvar();
                MessageBox.Show("Produto salvo com sucesso", "Produtos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ModoEscrita = false;
                AtualizarGrid();
            }
        }

        private bool ValidarFormulario()
        {
            StringBuilder stbMensagens = new StringBuilder();

            if (string.IsNullOrWhiteSpace(txtCodigo.Text))
            {
                stbMensagens.AppendLine("Preencha o campo Código");
            }
            else
            {
                Produto produto = new Produto();
                produto.PesquisarPorCodigo(txtCodigo.Text);
                if (produto.Id > 0 && produto.Id != _produtoCorrente.Id)
                {
                    stbMensagens.AppendLine("Este produto já foi cadastrado");
                }
            }

            if (string.IsNullOrWhiteSpace(txtNome.Text))
            {
                stbMensagens.AppendLine("Preencha o campo Nome");
            }

            if (txtPreco.Text.Length== 0 || Convert.ToDecimal(txtPreco.Text) == 0)
            {
                stbMensagens.AppendLine("Preencha o Preço");
            }

            if (txtPeso.Text.Length == 0 || Convert.ToDecimal(txtPeso.Text) == 0)
            {
                stbMensagens.AppendLine("Preencha o Peso");
            }

            if (stbMensagens.Length > 0)
                MessageBox.Show(stbMensagens.ToString(), "Produtos", MessageBoxButtons.OK, MessageBoxIcon.Error);

            return stbMensagens.Length == 0;
        }
        private decimal RemoverFormatacao(string valorFormatado)
        {
            decimal numero;
            decimal.TryParse(valorFormatado, NumberStyles.Currency, null, out numero);
            return numero;
        }

        private void LerFormulario()
        {
            _produtoCorrente.Codigo = txtCodigo.Text;
            _produtoCorrente.Nome = txtNome.Text;
            _produtoCorrente.Preco = txtPreco.Value;
            _produtoCorrente.Peso = txtPeso.Value;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            ModoEscrita = false;
        }

        private void dgvProdutos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                _produtoCorrente = ((List<Produto>)dgvProdutos.DataSource)[e.RowIndex];
                ModoEscrita = true;
                CarregarFormulario();
            }
        }

        private void CarregarFormulario()
        {
            txtCodigo.Text = _produtoCorrente.Codigo;
            txtNome.Text = _produtoCorrente.Nome;
            txtPreco.Value = _produtoCorrente.Preco;
            txtPeso.Value = _produtoCorrente.Peso;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            DialogResult resposta = MessageBox.Show(string.Format("Deseja realmente excluir '{0}'?", _produtoCorrente.Nome), "Produtos", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resposta == DialogResult.Yes)
            {
                _produtoCorrente.Excluir();
                MessageBox.Show("Produto excluído com sucesso!", "Produtos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            ModoEscrita = false;
            AtualizarGrid();
            txtCodigo.Focus();
        }
    }
}
