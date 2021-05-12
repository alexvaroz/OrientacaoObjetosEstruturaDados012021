using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Implementacao_PilhaDinamica
{
    class MinhaPilhaDinamicaInteiros
    {
        public MinhaPilhaDinamicaInteiros()
        {
            Topo = null;
        }

        public Nodo Topo { get; set; }

        public void Push(int dado)
        {
            Nodo novoNodo = new Nodo();
            novoNodo.Dado = dado;
            novoNodo.Elo = Topo;
            Topo = novoNodo;
        }

        public int Pop()
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

        public int Peek()
        {
            if (Topo == null)
            {
                Console.WriteLine("A pilha está vazia");
                return -1;
            } else
            {
                return Topo.Dado;
            }
        }

        public void ApresentarElementosPilha()
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
