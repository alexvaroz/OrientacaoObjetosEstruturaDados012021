using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementacaoFilaDinamica
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Construir fila com nome dos alunos:");
            MinhaFilaDinamica alunos = new MinhaFilaDinamica();
            alunos.InserirElemento("Rafael");
            alunos.InserirElemento("Fabrício");
            alunos.InserirElemento("Ighor");
            alunos.InserirElemento("Gustavo");
            alunos.InserirElemento("Gabriel");
            alunos.InserirElemento("Pedro");
            alunos.InserirElemento("Davi");
            Console.WriteLine($"Removido aluno {alunos.RemoverElemento()}");
            Console.WriteLine($"Removido aluno {alunos.RemoverElemento()}");
            Console.WriteLine($"Removido aluno {alunos.RemoverElemento()}");
            Console.WriteLine($"Removido aluno {alunos.RemoverElemento()}");
            Console.WriteLine($"Removido aluno {alunos.RemoverElemento()}");
            Console.WriteLine($"Removido aluno {alunos.RemoverElemento()}");
            Console.WriteLine($"Removido aluno {alunos.RemoverElemento()}");
            Console.WriteLine($"Removido aluno {alunos.RemoverElemento()}");
            Console.ReadLine();
        }
    }
}
