using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batata_Quente
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] criancas = { "Ana", "Bob", "Carol", "Duda", "Eva" };
            int intervalo = 6;
            Console.WriteLine($"O vencedor do jogo é {JogarBatataQuente(criancas, intervalo)}");
            Console.ReadLine();
        }

        static string JogarBatataQuente(string[] criancas, int intervalo)
        {
            Queue<string> filaCriancas = new Queue<string>();
            for (int i = 0; i < criancas.Length; i++)
            {
                filaCriancas.Enqueue(criancas[i]);
            }

            while (filaCriancas.Count > 1)
            {
                for (int i = 0; i < intervalo; i++)
                {
                    filaCriancas.Enqueue(filaCriancas.Dequeue());
                }
                filaCriancas.Dequeue();
            }
            return filaCriancas.Peek();
        }
    }
}
