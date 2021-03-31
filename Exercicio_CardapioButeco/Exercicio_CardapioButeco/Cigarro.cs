using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_CardapioButeco
{
    class Cigarro : ItemMenu, IProdutoParaMaiores
    {

        public double Preco { get; private set; }

        public Cigarro(string nome, double preco) : base(nome)
        {
            Preco = preco;
        }

        public override void ImprimirPreco()
        {
            ImprimirNome();
            Console.WriteLine($"Pacote: {Preco:C}");
            ImprimirAvisoMaiorIdade();
        }

        public void ImprimirAvisoMaiorIdade()
        {
            Console.WriteLine("Fumar faz mal a saúde!!!");
        }
    }
}
