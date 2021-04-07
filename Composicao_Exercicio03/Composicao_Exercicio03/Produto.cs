using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composicao_Exercicio03
{
    class Produto
    {
        public Produto(string nome, int quantidadeEstoque, float preco)
        {
            Nome = nome;
            QuantidadeEstoque = quantidadeEstoque;
            Preco = preco;
        }

        public string Nome { get; private set; }
        public int QuantidadeEstoque { get; private set; }
        public float Preco { get; private set; }

        public void InformarEstoqueAtual()
        {
            if (QuantidadeEstoque > 0)
                Console.WriteLine($"Atualmente temos {QuantidadeEstoque} unidade(s)");
            else
                Console.WriteLine("Estamos com o estoque zerado.");
        }

        public void ReduzirEstoque(int quantidadeRetirada)
        {
            QuantidadeEstoque -= quantidadeRetirada;
        }


    }
}
