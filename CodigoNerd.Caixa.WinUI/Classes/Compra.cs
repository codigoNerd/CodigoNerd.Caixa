using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodigoNerd.Caixa.WinUI.Classes
{
    public class Compra
    {

        public Compra()
        {
            Itens = new List<ItemCompra>();
        }
        public List<ItemCompra> Itens { get; private set; }

        public decimal SubTotal { get; private set; }

        public decimal ValorImposto { get; private set; }

        public decimal ValorTotal { get; private set; }

        public Imposto Imposto { get; private set; }

        public void IncluirImposto(Imposto imposto)
        {
            Imposto = imposto;
            ValorImposto = CalcularImposto();
            ValorTotal = CalcularTotal();
        }

        public void IncluirProduto(Produto produto)
        {
            bool produtoEncontrado = false;
            foreach (var item in Itens)
            {
                if (item.Produto.Id == produto.Id)
                {
                    produtoEncontrado = true;
                    item.Quantidade++;
                    break;
                }
            }

            if (!produtoEncontrado)
            {
                Itens.Add(new ItemCompra(produto));
            }

            AtualizarSubTotal();

            if (Imposto != null)
            {
                ValorImposto = CalcularImposto();
                ValorTotal = CalcularTotal();
            }
        }

        private void AtualizarSubTotal()
        {
            SubTotal = 0;
            foreach (var item in Itens)
            {
                SubTotal += item.Quantidade * item.Preco;
            }
        }

        private decimal CalcularImposto()
        {
           return SubTotal * Imposto.Percentual;
        }

        private decimal CalcularTotal()
        {
            return SubTotal + ValorImposto;
        }
    }
}
