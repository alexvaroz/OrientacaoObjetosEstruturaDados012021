using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questoes_Lista2
{
    class Arvore
    {
        public Noh Raiz { get; set; }

        public void InserirNoBin(Noh novoNo)
        {
            Raiz = Inserir(Raiz, novoNo);
        }

        private Noh Inserir(Noh atual, Noh novoNo)
        {
            if (atual == null)
            {
                return novoNo;
            }
            else if (novoNo.Valor < atual.Valor)
            {
                atual.Esquerda = Inserir(atual.Esquerda, novoNo);
            }
            else
            {
                atual.Direita = Inserir(atual.Direita, novoNo);
            }
            return atual;
        }

        public void ImprimirPercursoInFixado()
        {
            if (Raiz != null)
            {
                PercorrerInfixado(Raiz);
            }
            else
            {
                Console.WriteLine("A árvore está vazia.");
            }
        }

        private void PercorrerInfixado(Noh no)
        {
            if (no != null)
            {
                PercorrerInfixado(no.Esquerda);
                Console.Write($"{no.Valor}   ");
                PercorrerInfixado(no.Direita);
            }
        }
    }
}
