using System.Data.SqlClient;

namespace CodigoNerd.Caixa.WinUI.Classes
{
    public class Usuario
    {
        private const string SQL_AUTENTICAR = "Select nome from usuario where login = @login and senha = @senha";

        public string Nome { get; set; }

        public bool Autenticar(string login, string senha) {
            
            SqlConnection conexao = new SqlConnection(Configuracoes.STRING_DE_CONEXAO);
            conexao.Open();

            SqlCommand comandoDeConsulta = new SqlCommand(SQL_AUTENTICAR, conexao);
            comandoDeConsulta.Parameters.AddWithValue("login", login);
            comandoDeConsulta.Parameters.AddWithValue("senha", senha);
            SqlDataReader leitor = comandoDeConsulta.ExecuteReader();

            bool autenticado = leitor.Read();
            if (autenticado)
            {
                Nome = leitor["nome"].ToString();
            }
            conexao.Close();
            conexao.Dispose();
            return autenticado;
        }
    }
}
