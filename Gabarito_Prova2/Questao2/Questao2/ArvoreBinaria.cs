using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questao2
{
    class ArvoreBinaria
    {
        public NoBin Raiz { get; set; }

        public void InserirNoBin(NoBin novoNo)
        {
            Raiz = Inserir(Raiz, novoNo);
        }

        private NoBin Inserir(NoBin atual, NoBin novoNo)
        {
            if (atual == null)
            {
                return novoNo;
            }
            else if (novoNo.Valor.CompareTo(atual.Valor) < 0)
            {
                atual.Esquerda = Inserir(atual.Esquerda, novoNo);
            }
            else
            {
                atual.Direita = Inserir(atual.Direita, novoNo);
            }
            return atual;

        }
    }

}
