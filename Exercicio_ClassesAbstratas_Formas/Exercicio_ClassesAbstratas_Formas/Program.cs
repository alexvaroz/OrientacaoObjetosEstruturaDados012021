using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_ClassesAbstratas_Formas
{
    class Program
    {
        static void Main(string[] args)
        {
            TrianguloEquilatero triangulo = new TrianguloEquilatero("Triângulo", 9);
            Hexagono hexagono = new Hexagono("Hexágono", 9);
            Quadrado quadrado = new Quadrado("Quadrado", 9);
            Circulo circulo = new Circulo("Círculo", 9);

            FormaGeometrica[] formasCriadas = { triangulo, hexagono, quadrado, circulo };

            foreach (FormaGeometrica item in formasCriadas)
            {
                Console.WriteLine($"{item.Descricao}:");
                Console.WriteLine($"Área: {item.CalcularArea()}");
                Console.WriteLine($"Perímetro: {item.CalcularPerimetro()}\n");
            }
            Console.ReadLine();
        }
    }
}
