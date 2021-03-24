using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo_Exercicio03
{
    class JogoDigital : Produto
    {
        public JogoDigital(string titulo, double preco, string plataforma) : base(titulo, preco)
        {
            Plataforma = plataforma;
        }

        public string Plataforma { get; private set; }

        public override void InformarDescricao()
        {
            Console.WriteLine($"{Titulo} para {Plataforma}.");
        }
    }
}
