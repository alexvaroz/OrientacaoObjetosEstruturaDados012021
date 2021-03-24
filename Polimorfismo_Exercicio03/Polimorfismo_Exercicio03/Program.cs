using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polimorfismo_Exercicio03
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto jogoFifa = new JogoDigital("Fifa 2020", 550, "PS5");
            Produto jogoGoW = new JogoDigital("God of War", 5.99, "PS2");
            Produto livro1 = new Livro("O príncipe", 40, "Maquiavel");
            Produto livro2 = new Livro("A arte da guerra", 57.90, "Sun Tzu");

            Produto[] produtos = { jogoFifa, jogoGoW, livro1, livro2 };

            foreach (Produto item in produtos)
            {
                item.InformarDescricao();
                item.InformarPreco();
                Console.WriteLine("-------------");
                Console.ReadLine();
            }
        }
    }
}
