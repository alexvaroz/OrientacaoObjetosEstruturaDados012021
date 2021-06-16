using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questao3
{
    class PilhaDinamicaInteiros
    {
        public PilhaDinamicaInteiros()
        {
            Topo = null;
        }

        public Nodo Topo { get; set; }

        public void InserirElemento(int elemento)
        {
            Nodo novoNodo = new Nodo();
            novoNodo.Dado = elemento;
            novoNodo.Elo = Topo;
            Topo = novoNodo;
        }

        public int RetirarElemento()
        {
            Nodo auxiliar;
            if (Topo == null)
            {
                Console.WriteLine("A pilha está vazia");
                return -1;
            }
            else
            {
                auxiliar = Topo;
                Topo = auxiliar.Elo;
                return auxiliar.Dado;
            }
        }

        public int ApresentarElementoTopo()
        {
            if (Topo == null)
            {
                Console.WriteLine("A pilha está vazia");
                return -1;
            }
            else
            {
                return Topo.Dado;
            }
        }

        public void ApresentarTodosElementosPilha()
        {
            Nodo auxiliar;
            auxiliar = Topo;
            if (Topo == null)
            {
                Console.WriteLine("A pilha está vazia");
                return;
            }
            while (auxiliar != null)
            {
                Console.WriteLine(auxiliar.Dado);
                auxiliar = auxiliar.Elo;
            }
        }
    }
}

