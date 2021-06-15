using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questao2
{
    class Program
    {
        /*
         * Implementar um programa que efetue a montagem de uma árvore binária de busca com os 
         * seguintes nomes de estados { Acre, Santa Catarina, Goiás, Tocantins, Ceará, Paraná, 
         * Bahia, Sergipe e Roraima} e retorne a lista de nomes em ordem alfabética.
         */

        static void Main(string[] args)
        {
            string[] nomesEstados = { "Santa Catarina", "Acre", "Goiás", "Tocantins",
                "Ceará", "Paraná", "Bahia", "Sergipe",  "Roraima"};

            ArvoreBinaria minhaArvore = new ArvoreBinaria();
            foreach (var nomeEstado in nomesEstados)
            {
                NoBin nodeAInserir = new NoBin(nomeEstado);
                minhaArvore.InserirNoBin(nodeAInserir);
            }

            PercorrerArvoreInFixado(minhaArvore.Raiz);
            Console.ReadLine();
        }

        static void PercorrerArvoreInFixado(NoBin nodo)
        {
            if (nodo != null)
            {
                PercorrerArvoreInFixado(nodo.Esquerda);
                Console.Write($"{nodo.Valor}   ");
                PercorrerArvoreInFixado(nodo.Direita);
            }
        }
    }
}
