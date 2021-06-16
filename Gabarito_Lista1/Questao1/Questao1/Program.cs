using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questao1
{
    /*
     * Criar um método que receba uma palavra e cheque se ela é um palíndromo. 
     * Obs. Palíndromo é toda palavra ou frase que pode ser lida de trás pra frente e 
     * que, independente da direção, mantém o seu sentido, por exemplo: anilina, arara.
     */

    class Program
    {
        static void Main(string[] args)
        {
            string palavra = "batata";

            if (VerificarSePalavraEhPalindromo(palavra))
            {
                Console.WriteLine($"A palavra {palavra} é um palíndromo.");
            } else
            {
                Console.WriteLine($"A palavra {palavra} não é um palíndromo.");
            }
            Console.ReadLine();
        }

        static bool VerificarSePalavraEhPalindromo(string palavra)
        {
            Stack<char> pilha = new Stack<char>();
            bool sePalavraPalindromo = true;
            foreach(var letra in palavra)
            {
                pilha.Push(letra);
            }

            foreach (var letra in palavra)
            {
                if (letra != pilha.Pop())
                {
                    sePalavraPalindromo = false;
                }
            }
           return sePalavraPalindromo;
        }
    }
}
