using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilizacaoQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nomeCriancas = {"Alice", "Bob Nelson", "Charlie", "Dani", "Eva",
            "Franz", "Gal", "Helo", "Ivy", "Juka"};

            Queue<string> filaCantina = new Queue<string>();

            foreach (var item in nomeCriancas)
            {
                filaCantina.Enqueue(item);
            }

            while (filaCantina.Count > 0) { 
                Console.WriteLine($"O lanche do(a) aluno(a) {filaCantina.Peek()}");
                filaCantina.Dequeue();
                Console.ReadLine();
            }
            Console.ReadLine();

        }
    }
}
