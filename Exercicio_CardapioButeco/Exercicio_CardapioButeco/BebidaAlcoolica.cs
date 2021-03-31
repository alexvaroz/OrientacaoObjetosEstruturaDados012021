using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_CardapioButeco
{
    class BebidaAlcoolica : Bebida, IProdutoParaMaiores
    {
        public BebidaAlcoolica(string nome, double precoPequena, 
            double precoMedia, double precoGrande) : base(nome, precoPequena, precoMedia, precoGrande)
        {
        }

        public override void ImprimirPreco()
        {
            base.ImprimirPreco();
            ImprimirAvisoMaiorIdade();
        }

        public void ImprimirAvisoMaiorIdade()
        {
            Console.WriteLine("Antes de dirigir não beba!!!");
        }
    }
}
