using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composicao_Exercicio03
{
    class ItemPedido
    {
        public ItemPedido(Produto produto, int quantidadeItens)
        {
            Produto = produto;
            QuantidadeItens = quantidadeItens;
        }

        public Produto Produto { get; private set; }
        public int QuantidadeItens { get; private set; }
    }
}
