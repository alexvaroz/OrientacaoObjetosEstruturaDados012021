using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_CardapioButeco
{
    class Bebida : ItemMenu
    {
        public double PrecoPequena { get; private set; }
        public double PrecoMedia { get; private set; }
        public double PrecoGrande { get; private set; }


        public Bebida(string nome, double precoPequena, double precoMedia, double precoGrande) : base(nome)
        {
            PrecoPequena = precoPequena;
            PrecoMedia = precoMedia;
            PrecoGrande = precoGrande;
        }

        public override void ImprimirPreco()
        {
            ImprimirNome();
            Console.WriteLine($"P: {PrecoPequena:C}");
            Console.WriteLine($"M: {PrecoMedia:C}");
            Console.WriteLine($"G: {PrecoGrande:C}");
        }
    }
}
