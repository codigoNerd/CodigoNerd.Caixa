using CodigoNerd.Caixa.WinUI.Classes;
using System.Windows.Forms;
using System;
using System.Text;

namespace CodigoNerd.Caixa.WinUI.Formularios
{
    public partial class Caixa : Form
    {
        private Compra _compra;

        public Caixa()
        {
            InitializeComponent();
            _compra = new Compra();
            dgvItens.AutoGenerateColumns = false;
            CarregarImpostos();
        }

        private void CarregarImpostos()
        {
            cboImpostos.ValueMember = "Percentual";
            cboImpostos.DisplayMember = "Descricao";
            cboImpostos.Items.Add(new Imposto { Percentual = 0, Descricao = "-- Selecione --" });
            foreach (var imposto in Configuracoes.Impostos)
            {
                cboImpostos.Items.Add(imposto);
            }
            cboImpostos.SelectedIndex = 0;
        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Keys)e.KeyChar != Keys.Enter)
            {
                return;
            }

            Produto produto = new Produto();
            if (produto.PesquisarPorCodigo(txtCodigo.Text))
            {
                _compra.IncluirProduto(produto);
                AtualizarItensCompra();
                if (cboImpostos.SelectedItem != null)
                    AtualizarTotais();
            }
            else
            {
                MessageBox.Show("Produto não encontrado", "Caixa", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            txtCodigo.Clear();
            txtCodigo.Focus();
        }

        private void AtualizarItensCompra()
        {
            dgvItens.DataSource = null;
            dgvItens.DataSource = _compra.Itens;
            lblSubtotalValor.Text = _compra.SubTotal.ToString("C2");
        }

        private void cboImpostos_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            _compra.IncluirImposto((Imposto)cboImpostos.SelectedItem);
            AtualizarTotais();
        }

        private void AtualizarTotais()
        {
            lblValorImpostosValor.Text = _compra.ValorImposto.ToString("C2");
            lblTotalValor.Text = _compra.ValorTotal.ToString("C2");
        }

        private void btnFinalizarCompra_Click(object sender, System.EventArgs e)
        {
            if (ValidarCompra())
            {
                LimparFormulario();
                MessageBox.Show("Compra Finalizada", "Caixa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private bool ValidarCompra()
        {
           
            StringBuilder stbErros = new StringBuilder();
            if (_compra.SubTotal == 0)
                stbErros.AppendLine("A compra não possui nenhum produto");

            if (_compra.Imposto == null || _compra.Imposto.Percentual == 0)
                stbErros.AppendLine("Selecione um imposto");

            if (stbErros.Length > 0)
                MessageBox.Show(stbErros.ToString(), "Caixa", MessageBoxButtons.OK, MessageBoxIcon.Error);

            return stbErros.Length == 0;
        }

        private void LimparFormulario()
        {
            dgvItens.DataSource = null;
            lblPesoValor.Text = "0,00 Kg";
            lblSubtotalValor.Text = 0M.ToString("C2");
            lblTotalValor.Text = 0M.ToString("C2");
            lblValorImpostosValor.Text = 0M.ToString("C2");
            cboImpostos.SelectedItem = 0;
            txtCodigo.Clear();
            txtCodigo.Focus();
        }
    }
}
