using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questao4
{
    class FilaEstaticaInteiros
    {
        public FilaEstaticaInteiros(int numElementos)
        {
            Inicio = 0;
            Fim = -1;
            Dados = new int[numElementos];
        }

        public int Inicio { get; set; }
        public int Fim { get; set; }
        public int[] Dados { get; set; }

        public void Enfileirar(int numero)
        {
            if (Fim >= Dados.Length - 1)
            {
                Console.WriteLine("A fila já está cheia...");
                return;
            }
            else
            {
                Fim++;
                Dados[Fim] = numero;
                Console.WriteLine($"Elemento {numero} inserido com sucesso!!!");
            }
        }

        public int Desinfileirar()
        {
            if (Fim == -1)
            {
                Console.WriteLine("A fila está vazia...");
                return -1;
            }
            else
            {
                int valor = Dados[Inicio];
                Inicio++;
                if (Inicio > Fim)
                {
                    Inicio = 0;
                    Fim = -1;
                }
                return valor;
            }
        }

        public int ConsultarFila()
        {
            if (Fim == -1)
            {
                Console.WriteLine("A fila está vazia...");
                return -1;
            }
            else
            {
                return Dados[Inicio];
            }
        }

        public void MostrarElementos()
        {
            if (Fim == -1)
            {
                Console.WriteLine("A fila está vazia...");
                return;
            }
            for (int i = Inicio; i <= Fim; i++)
            {
                Console.WriteLine(Dados[i]);
            }
        }
    }
}
