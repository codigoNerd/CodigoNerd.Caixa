using System.Collections.Generic;

namespace CodigoNerd.Caixa.WinUI.Classes
{
    public static class Configuracoes
    {
        public const string STRING_DE_CONEXAO = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Itanio-PC24\Source\Repos\CodigoNerd.Caixa\CodigoNerd.Caixa.WinUI\Banco\CodigoNerd.Caixa.Banco.mdf;Integrated Security=True";

        public static List<Imposto> Impostos { get; private set; } = new List<Imposto>() {
                new Imposto { Descricao = "ICMS", Percentual = 0.20M },
                new Imposto { Descricao = "IPI", Percentual = 0.12M },
                new Imposto { Descricao = "ICMS + IPI", Percentual = 0.32M },
            };
        public static Usuario UsuarioLogado { get; set; }
    }
}
