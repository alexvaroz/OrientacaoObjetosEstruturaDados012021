using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questao3
{
    /*
     * Implementar uma pilha usando alocação dinâmica.
     */

    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = { 1, 3, 5, 7 };
            PilhaDinamicaInteiros minhaPilha = new PilhaDinamicaInteiros();
            for (int i = 0; i < numeros.Length; i++)
            {
                minhaPilha.InserirElemento(numeros[i]);
            }

            Console.WriteLine(minhaPilha.ApresentarElementoTopo());

            Console.ReadLine();
        }
    }
}
