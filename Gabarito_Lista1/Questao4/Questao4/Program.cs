using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questao4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Criando uma fila com 3 números:");
            FilaEstaticaInteiros minhaFila = new FilaEstaticaInteiros(3);
            minhaFila.Enfileirar(10);
            minhaFila.Enfileirar(20);
            minhaFila.Enfileirar(30);
            Console.WriteLine("Imprimir valores da fila:");
            minhaFila.MostrarElementos();
            Console.ReadLine();
            minhaFila.Desinfileirar();
            minhaFila.Desinfileirar();
            Console.WriteLine("Consultar primeiro elemento da Fila:");
            Console.WriteLine(minhaFila.ConsultarFila());
            minhaFila.Desinfileirar();
            minhaFila.Desinfileirar();
            minhaFila.Desinfileirar();
            minhaFila.Desinfileirar();
            Console.ReadLine();
        }
    }
}
