using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resolucao_Desafio_Josefo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instanciar a fila dos judeus
            Queue<int> filaJudeus = new Queue<int>();
            
            // Para marcar as posições utilizaremos números
            for (int i = 1; i <= 41 ; i++)
            {
                filaJudeus.Enqueue(i);
            }

            while (filaJudeus.Count > 2)
            {
                filaJudeus.Enqueue(filaJudeus.Dequeue());
                filaJudeus.Enqueue(filaJudeus.Dequeue());
                Console.WriteLine($"Será sacrificado o número {filaJudeus.Peek()}");
                filaJudeus.Dequeue();
            }
            Console.ReadLine();
            foreach (var item in filaJudeus)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
