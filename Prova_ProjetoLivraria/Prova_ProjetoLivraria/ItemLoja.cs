using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova_ProjetoLivraria
{
    abstract class ItemLoja: IItemRelatorio
    {
        protected ItemLoja(long id, PessoaJuridica fornecedor, float precoCompra, float precoVenda)
        {
            Id = id;
            Fornecedor = fornecedor;
            PrecoCompra = precoCompra;
            PrecoVenda = precoVenda;

        }

        public long Id { get; private set; }
        public PessoaJuridica Fornecedor { get; private set; }
        public float PrecoCompra { get; private set; }
        public float PrecoVenda { get; private set; }
        public int QuantidadeEstoque { get; set; }

        public abstract void MostrarDescricao();

        public void ReceberProduto(int quantidadeRecebida)
        {
            QuantidadeEstoque += quantidadeRecebida;
        }

        public void VenderProduto(int quantidadeVendida)
        {
            QuantidadeEstoque += quantidadeVendida;
        }


    }
}
