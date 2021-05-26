using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementacaoArvore
{
    class Program
    {
        static void Main(string[] args)
        {
            // criação da árvore
            MinhaArvore arvoreD = new MinhaArvore(null, 'D', null);
            MinhaArvore arvoreE = new MinhaArvore(null, 'E', null);
            MinhaArvore arvoreG = new MinhaArvore(null, 'G', null);
            MinhaArvore arvoreF = new MinhaArvore(arvoreG, 'F', null);
            MinhaArvore arvoreB = new MinhaArvore(arvoreD, 'B', arvoreE);
            MinhaArvore arvoreC = new MinhaArvore(null, 'C', arvoreF);
            MinhaArvore arvoreA = new MinhaArvore(arvoreB, 'A', arvoreC);
            Console.WriteLine("Percorrimento Pré-fixado:");
            PercorrimentoPreFixado(arvoreA);
            Console.WriteLine();
            Console.WriteLine("Percorrimento In-fixado:");
            PercorrimentoInFixado(arvoreA);
            Console.WriteLine();
            Console.WriteLine("Percorrimento Pós-fixado:");
            PercorrimentoPosFixado(arvoreA);
            Console.ReadLine();

        }

        static void PercorrimentoPreFixado(MinhaArvore arvore)
        {
            if (arvore != null)
            {
                Console.Write($"{arvore.Dado}   ");
                PercorrimentoPreFixado(arvore.Esquerda);
                PercorrimentoPreFixado(arvore.Direita);
            }
        }

        static void PercorrimentoInFixado(MinhaArvore arvore)
        {
            if (arvore != null)
            {
                PercorrimentoInFixado(arvore.Esquerda);
                Console.Write($"{arvore.Dado}   ");
                PercorrimentoInFixado(arvore.Direita);
            }
        }

        static void PercorrimentoPosFixado(MinhaArvore arvore)
        {
            if (arvore != null)
            {
                PercorrimentoPosFixado(arvore.Esquerda);
                PercorrimentoPosFixado(arvore.Direita);
                Console.Write($"{arvore.Dado}   ");
            }
        }
    }
}
