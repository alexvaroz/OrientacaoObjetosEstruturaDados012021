using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composicao_Exercicio03
{
    class Pedido
    {
        public Pedido(ItemPedido[] itens, Cliente cliente, TipoPagamento tipoPagamento)
        {
            Itens = itens;
            Cliente = cliente;
            TipoPagamento = tipoPagamento;
        }

        public ItemPedido[] Itens { get; set; }
        public Cliente Cliente { get; set; }
        public TipoPagamento TipoPagamento { get; set; }

        public void RealizarCompra()
        {
            float valorCompra = 0;
            foreach (ItemPedido item in Itens)
            {
                item.Produto.ReduzirEstoque(item.QuantidadeItens);
                valorCompra = valorCompra + item.Produto.Preco * item.QuantidadeItens;
            }
            Console.WriteLine("Compra realizada!");
            Console.WriteLine($"Valor total {valorCompra:c}");
        }
    }
}
