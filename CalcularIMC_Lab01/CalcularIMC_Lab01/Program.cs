using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcularIMC_Lab01
{
    class Program
    {
        static void Main(string[] args)
        {
            Usuario bobNelson = new Usuario("Bob Nelson", 37, 78.0f, 1.70f);
            Console.WriteLine($"Situacao IMC do {bobNelson.nome}: {bobNelson.InformarSituacaoIMC()}");
            Console.WriteLine($"Seu peso ideal é {bobNelson.InformarMetaPeso()}");
            Console.ReadLine();

            Usuario testolfo = new Usuario("Testolfo Rocha", 43, 60.0f, 1.65f);
            Console.WriteLine($"Situacao IMC do {testolfo.nome}: {testolfo.InformarSituacaoIMC()}");
            Console.WriteLine($"Seu peso ideal é {testolfo.InformarMetaPeso()}");
            Console.ReadLine();

            Usuario lisa = new Usuario("Lisa Leite", 22, 92.0f, 1.72f);
            Console.WriteLine($"Situacao IMC do {lisa.nome}: {lisa.InformarSituacaoIMC()}");
            Console.WriteLine($"Seu peso ideal é {lisa.InformarMetaPeso()}");
            Console.ReadLine();
        }
    }
}
