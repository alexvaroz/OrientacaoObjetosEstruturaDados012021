using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implementacao_PilhaDinamica
{
    class Program
    {
        static void Main(string[] args)
        {
            MinhaPilhaDinamicaInteiros pilhaNumeros = new MinhaPilhaDinamicaInteiros();
            pilhaNumeros.Pop();
            pilhaNumeros.Push(2);
            pilhaNumeros.Push(4);
            pilhaNumeros.Push(6);
            pilhaNumeros.Push(8);
            pilhaNumeros.Push(10);
            Console.WriteLine(pilhaNumeros.Pop());
            Console.WriteLine(pilhaNumeros.Pop());
            Console.WriteLine(pilhaNumeros.Pop());
            Console.WriteLine(pilhaNumeros.Pop());
            Console.WriteLine(pilhaNumeros.Pop());
            pilhaNumeros.ApresentarElementosPilha();
            pilhaNumeros.Push(2);
            pilhaNumeros.Push(4);
            pilhaNumeros.Push(6);
            pilhaNumeros.Push(8);
            pilhaNumeros.Push(10);
            Console.ReadLine();
            pilhaNumeros.ApresentarElementosPilha();
            Console.ReadLine();
        }
    }
}
