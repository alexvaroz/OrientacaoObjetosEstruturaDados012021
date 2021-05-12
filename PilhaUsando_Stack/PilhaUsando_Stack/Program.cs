using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PilhaUsando_Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exemplo de pilha com nomes de times de futebol:");
            Stack<string> times = new Stack<string>();
            times.Push("Flamengo");
            times.Push("Mengão");
            times.Push("O mais querido");
            times.Push("OctoCampeão Brasileiro");
            times.Push("Mengo");
            Console.WriteLine(times.Pop());
            foreach (var item in times)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
