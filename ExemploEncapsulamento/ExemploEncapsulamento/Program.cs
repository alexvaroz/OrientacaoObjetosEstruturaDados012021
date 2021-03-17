using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploEncapsulamento
{
    class Program
    {
        static void Main(string[] args)
        {
            Carro carroDoBob = new Carro("Fusca", "Azul", 1978, 120);
            carroDoBob.Ligar();
            Console.ReadLine();
            carroDoBob.Desligar();
            Console.ReadLine();
            Console.WriteLine($"Velocidade atual: {carroDoBob.VelocidadeAtual}Km/h");
            Console.ReadLine();
        }
    }
}
