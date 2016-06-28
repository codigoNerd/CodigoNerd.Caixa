using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace CodigoNerd.Caixa.WinUI.Classes
{
    public class Produto
    {
        #region Propriedades 
            public int Id { get; set; }

            public string Nome { get; set; }

            public decimal Preco { get; set; }

            public string Codigo { get; set; }

            public decimal Peso { get; set; }
        #endregion

        #region Instruções SQL
            private const string SQL_PESQUISAR_POR_CODIGO = "Select * from Produto where codigo = @codigo";
            private const string SQL_LISTAR_TODOS = "Select * from produto";
            private const string SQL_INCLUIR = "Insert into produto (codigo, nome, preco, peso) values (@codigo, @nome, @preco, @peso); select @@identity id";
            private const string SQL_ATUALIZAR = "Update produto set codigo = @codigo, preco = @preco, nome = @nome, peso = @peso where id = @id";
            private const string SQL_EXCLUIR = "Delete from produto where id = @id";
        #endregion

        public bool PesquisarPorCodigo(string codigo)
        {
            SqlConnection conexao = new SqlConnection(Configuracoes.STRING_DE_CONEXAO);
            conexao.Open();

            SqlCommand comandoDeConsulta = new SqlCommand(SQL_PESQUISAR_POR_CODIGO, conexao);
            comandoDeConsulta.Parameters.AddWithValue("codigo", codigo);
            SqlDataReader leitor = comandoDeConsulta.ExecuteReader();

            bool encontrado = leitor.Read();
            if (encontrado)
            {
                LerProduto(this, leitor);
            }
            conexao.Close();
            conexao.Dispose();
            return encontrado;
        }

        public static List<Produto> Listar()
        {
            List<Produto> produtos = new List<Produto>();
            SqlConnection conexao = new SqlConnection(Configuracoes.STRING_DE_CONEXAO);
            conexao.Open();

            SqlCommand comandoDeConsulta = new SqlCommand(SQL_LISTAR_TODOS, conexao);
            SqlDataReader leitor = comandoDeConsulta.ExecuteReader();
            while (leitor.Read())
            {
                Produto produto = new Produto();
                LerProduto(produto, leitor);
                produtos.Add(produto);
            }
            conexao.Close();
            conexao.Dispose();
            return produtos;
        }

        public void Salvar()
        {
            if (Id == 0)
            {
                Incluir();
            }
            else
            {
                Alterar();
            }
        }

        public void Excluir()
        {
            SqlConnection conexao = new SqlConnection(Configuracoes.STRING_DE_CONEXAO);
            conexao.Open();

            SqlCommand comandoDeConsulta = new SqlCommand(SQL_EXCLUIR, conexao);
            comandoDeConsulta.Parameters.AddWithValue("id", Id);
            comandoDeConsulta.ExecuteNonQuery();

            conexao.Close();
            conexao.Dispose();
        }

        private static void LerProduto(Produto produto, SqlDataReader leitor)
        {
            produto.Id = Convert.ToInt32(leitor["id"].ToString());
            produto.Codigo = leitor["codigo"].ToString();
            produto.Nome = leitor["nome"].ToString();
            produto.Peso = Convert.ToDecimal(leitor["peso"].ToString());
            produto.Preco = Convert.ToDecimal(leitor["preco"].ToString());
        }

        private void Incluir()
        {
            SqlConnection conexao = new SqlConnection(Configuracoes.STRING_DE_CONEXAO);
            conexao.Open();
            SqlCommand comandoDeConsulta = new SqlCommand(SQL_INCLUIR, conexao);
            comandoDeConsulta.Parameters.AddWithValue("codigo", Codigo);
            comandoDeConsulta.Parameters.AddWithValue("nome", Nome);
            comandoDeConsulta.Parameters.AddWithValue("peso", Peso);
            comandoDeConsulta.Parameters.AddWithValue("preco", Preco);
            SqlDataReader leitor = comandoDeConsulta.ExecuteReader();
            leitor.Read();
            Id = Convert.ToInt32(leitor["Id"].ToString());
            conexao.Close();
            conexao.Dispose();
        }

        private void Alterar()
        {
            SqlConnection conexao = new SqlConnection(Configuracoes.STRING_DE_CONEXAO);
            conexao.Open();
            SqlCommand comandoDeConsulta = new SqlCommand(SQL_ATUALIZAR, conexao);
            comandoDeConsulta.Parameters.AddWithValue("codigo", Codigo);
            comandoDeConsulta.Parameters.AddWithValue("nome", Nome);
            comandoDeConsulta.Parameters.AddWithValue("peso", Peso);
            comandoDeConsulta.Parameters.AddWithValue("preco", Preco);
            comandoDeConsulta.Parameters.AddWithValue("id", Id);
            comandoDeConsulta.ExecuteNonQuery();
            conexao.Close();
            conexao.Dispose();
        }

        
    }
}
