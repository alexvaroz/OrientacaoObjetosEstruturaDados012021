using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova_ProjetoLivraria
{
    class Caderno : ItemLoja
    {
        public Caderno(long id, PessoaJuridica fornecedor, float precoCompra, float precoVenda, int quantidadeFolhas) : 
            base(id, fornecedor, precoCompra, precoVenda)
        {
            QuantidadeFolhas = quantidadeFolhas;
        }

        public int QuantidadeFolhas { get; set; }

        public override void MostrarDescricao()
        {
            Console.WriteLine($"Caderno de {QuantidadeFolhas} folhas, fabricado por {Fornecedor}");
        }
    }
}
