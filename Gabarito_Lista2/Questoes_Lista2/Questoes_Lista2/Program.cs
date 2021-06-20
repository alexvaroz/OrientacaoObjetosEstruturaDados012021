using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questoes_Lista2
{
    /*
     * Questão 1) Descreva, em texto, a ordem de visita para um percurso em pré-fixado, in-fixado e 
     * pós-fixado na árvore descrita na figura presente no forumlário da lista de exercícios:
     * 
     * Pré-fixado: 33  15  41  38  34  47  43  49
     * In-fixado:  15  33  34  38  41  43  47  49
     * Pós-fixado: 15  34  38  43  49  47  41  33
     * 
     * Questão 2) Implemente um método que receba uma lista de números inteiros e os adicione em uma 
     * arvore de busca binária incialmente vazia. Para efeito de testes, considere a seguinte 
     * sequencia de números { 59, 103, 48, 33, 51, 38, 79, 1, 235, 121, 223, 161}. 
     * P.s. Você também deve apresentar o código da árvore e do nó criados.
     *
     * Questão 3) Crie um método que receba a árvore criada no exercício anterior e imprima os nós dela 
     * na sequencia do percurso "in-fixado". 
     *
     * Questao 4) Implemente um método que receba uma árvore binária e retorne a quantidade de nós 
     * presentes. P.S. Para questão de testes, utilizar a árvore implementada na questão 2. *
     *
     * Questão 5) Implemente um método que receba uma árvore binária não nula e retorne o maior valor 
     * encontrado nela. 
     *
     * Questao 6) Implemente um método que receba uma árvore binária de busca e retorne a soma dos 
     * valores presentes.
     *
     */

    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[] { 59, 103, 48, 33, 51, 38, 79, 1, 235, 121, 223, 161 };
            Console.WriteLine("Questão 2");
            Arvore arvoreBinariaBusca = CriarArvoreBinariaPorLista(numeros);
            Console.WriteLine("Questão 3");
            ImprimirPercorrimentoInFixadoArvoreBinaria(arvoreBinariaBusca);
            Console.Write("\n");
            Console.WriteLine("Questão 4");
            Console.WriteLine($"A árvore possui {RetornarQuantidadeNosEmArvore(arvoreBinariaBusca.Raiz)} " +
                $"nohs");
            Console.WriteLine("Questão 5");
            Console.WriteLine($"O maior valor encontrado na árvore é " +
                $"{RetornarMaiorValorEmArvore(arvoreBinariaBusca.Raiz)}");
            Console.WriteLine("Questão 6");
            Console.WriteLine($"A soma dos elementos da árvore é " +
                $"{RetornarSomaElementosEmArvore(arvoreBinariaBusca.Raiz)}");
            Console.ReadLine();
        }

        static Arvore CriarArvoreBinariaPorLista(int[] numeros)
        {
            Arvore arvoreBinaria = new Arvore();
            foreach (var item in numeros)
            {
                Noh novoNoh = new Noh(item);
                arvoreBinaria.InserirNoBin(novoNoh);
            }
            Console.WriteLine("Árvore criada!");
            return arvoreBinaria;
        }

        static void ImprimirPercorrimentoInFixadoArvoreBinaria(Arvore arvore)
        {
            arvore.ImprimirPercursoInFixado();
        }

        static int RetornarQuantidadeNosEmArvore(Noh no)
        {
            if (no == null)
            {
                return 0;
            }
            else
            {
                return 1 + RetornarQuantidadeNosEmArvore(no.Direita) +
                    RetornarQuantidadeNosEmArvore(no.Esquerda);
            }
        }

        static int RetornarMaiorValorEmArvore(Noh no)
        {
            int maiorAtual = no.Valor;
            int maiorValor = maiorAtual;
            if (no.Esquerda != null)
            {
                int maiorEsquerda = RetornarMaiorValorEmArvore(no.Esquerda);
                if (maiorEsquerda > maiorValor)
                {
                    maiorValor = maiorEsquerda;
                }
            }
            if (no.Direita != null)
            {
                int maiorDireita = RetornarMaiorValorEmArvore(no.Direita);
                if (maiorDireita > maiorValor)
                {
                    maiorValor = maiorDireita;
                }
            }
            return maiorValor;
        }

        static int RetornarSomaElementosEmArvore(Noh no)
        {
            if (no == null)
                return 0;
            else
            {
                int soma = 0;
                soma += RetornarSomaElementosEmArvore(no.Esquerda);
                soma += RetornarSomaElementosEmArvore(no.Direita);
                soma += no.Valor;
                return soma;
            }
        }

    }
}
