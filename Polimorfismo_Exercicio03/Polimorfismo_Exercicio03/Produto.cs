using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo_Exercicio03
{
    class Produto
    {
        public string Titulo { get; protected set; }
        public double Preco { get; protected set; }

        public Produto(string titulo, double preco)
        {
            Titulo = titulo;
            Preco = preco;
        }

        public virtual void InformarDescricao() {
            Console.WriteLine("Item da loja");
        }
        public void InformarPreco() {
            Console.WriteLine($"{Preco.ToString("C")}");
        }
    }
}
