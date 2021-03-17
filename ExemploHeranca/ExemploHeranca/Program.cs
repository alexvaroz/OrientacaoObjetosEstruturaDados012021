using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploHeranca
{
    class Program
    {
        static void Main(string[] args)
        {
            Humano jota = new Humano("João", "Jota");
            Trabalhador testolfo = new Trabalhador("Testolfo", "Rocha", 4000, 100);
            testolfo.InformarRemuneracaoPorHora();

            Estudante bob = new Estudante("Bob", "Nelson", 7);
            bob.InformarSeAprovado();
            Console.ReadLine();
        }
    }
}
