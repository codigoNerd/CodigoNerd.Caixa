using CodigoNerd.Caixa.WinUI.Classes;
using CodigoNerd.Caixa.WinUI.Formularios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodigoNerd.Caixa.WinUI
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Usuario usuarioAAutenticar = new Usuario();
            if (usuarioAAutenticar.Autenticar(txtLogin.Text, txtSenha.Text))
            {
                Configuracoes.UsuarioLogado = usuarioAAutenticar;
                Principal formularioPrincipal = new Principal();
                this.Hide();
                formularioPrincipal.Show();
            }
            else
            {
                MessageBox.Show("Usuário ou senha inválido(s)", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
