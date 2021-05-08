using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementarPilhaPorArray
{
    class Program
    {
        static void Main(string[] args)
        {
            MinhaPilha primeiraPilha = new MinhaPilha(3);
            primeiraPilha.Pop();
            primeiraPilha.Push("Rafael Tarnac");
            primeiraPilha.Push("Gustavo Francisco");
            primeiraPilha.Push("Fabricio Duarte");
            primeiraPilha.Pop();
            primeiraPilha.Push("Israel Brito");
            primeiraPilha.Push("Fabricio Duarte");
            primeiraPilha.ImprimirElementosPilha();
            Console.WriteLine($"O topo da pilha é {primeiraPilha.Peek()}");
            Console.ReadLine();
        }
    }
}
