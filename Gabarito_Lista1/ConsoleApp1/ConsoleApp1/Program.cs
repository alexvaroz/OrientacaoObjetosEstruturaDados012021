using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            ChecarPalindromo("abacate");
            Console.ReadLine();
        }

        public static void VerificarPalavra(string palavra)
        {
            string palavraOriginal = palavra;
            string palavraTeste = "";

            foreach (char v in palavra)
            {
                palavraTeste += v;
            }

            if (palavraOriginal == palavraTeste)
            {
                Console.WriteLine($"{palavra} é um palíndromo");
            }
            else
            {
                Console.WriteLine($"{palavra} não é um palíndromo");
            }
        }

        private static bool ChecarPalindromo(string palavra)
        {
            char[] letras = palavra.ToCharArray();
            Array.Reverse(letras);

            string palavraInvertida = new string(letras);

            if (palavra.ToLower() == palavraInvertida.ToLower())
                return true;
            else
                return false;
        }
    }
}
