using CodigoNerd.Caixa.WinUI.Classes;
using System;
using System.Windows.Forms;

namespace CodigoNerd.Caixa.WinUI.Formularios
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
            usuarioLogadoLabel.Text = Configuracoes.UsuarioLogado.Nome;
        }

        private Caixa telaCaixa;
        private Produtos telaProdutos;

        private void caixaMenu_Click(object sender, EventArgs e)
        {
            if (telaCaixa == null || telaCaixa.IsDisposed)
            {
                telaCaixa = new Caixa();
            }
            telaCaixa.MdiParent = this;
            telaCaixa.Show();
            telaCaixa.BringToFront();
        }

        private void sairMenu_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void produtosMenu_Click(object sender, EventArgs e)
        {
            if (telaProdutos == null || telaProdutos.IsDisposed)
            {
                telaProdutos = new Produtos();
            }
            telaProdutos.MdiParent = this;
            telaProdutos.Show();
            telaProdutos.BringToFront();
        }

        private void Principal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
