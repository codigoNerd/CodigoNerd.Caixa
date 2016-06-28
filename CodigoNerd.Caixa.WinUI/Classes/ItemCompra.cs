using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodigoNerd.Caixa.WinUI.Classes
{
    public class ItemCompra
    {
        public ItemCompra(Produto produto)
        {
            Produto = produto;
            Quantidade = 1;
        }

        public Produto Produto
        {
            get; private set;
        }

        public string Nome { get {
                return Produto.Nome;
            }
        }

        public decimal Preco
        {
            get
            {
                return Produto.Preco;
            }
        }

        public string Codigo
        {
            get
            {
                return Produto.Codigo;
            }
        }




        public int Quantidade { get; set; }
    }
}
