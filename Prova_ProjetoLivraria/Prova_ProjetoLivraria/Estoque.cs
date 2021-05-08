using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova_ProjetoLivraria
{
    class Estoque
    {
        public List<ItemLoja> Item { get; set; }

        public void EntrarProduto(ItemLoja produto)
        {
            Item.Add(produto);
        }

        public void RetirarProduto(ItemLoja produto)
        {
            Item.Add(produto);
        }
    }
}
