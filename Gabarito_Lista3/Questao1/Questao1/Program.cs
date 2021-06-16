using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questao1
{
    class Program
    {
        /*
         * Dado o seguinte texto, crie um método que realize a contagem de quantas palavras diferentes 
         * estão presentes. Para isso, somente desconsidere palavras os sinais de pontuação.
         */

        static void Main(string[] args)
        {
            string textoExemplo = "...Uma atividade livre, conscientemente tomada como “não-séria” e " +
                "exterior à vida habitual, mas ao mesmo tempo capaz de absorver o jogador de maneira " +
                "intensa e total. É uma atividade desligada de todo e qualquer interesse material, " +
                "com a qual não se pode obter qualquer lucro, praticada dentro de limites espaciais " +
                "e temporais próprios, segundo uma certa ordem e certas regras. Promove a formação de" +
                " grupos sociais com tendência a rodearem-se de segredo e a sublinharem sua diferença " +
                "em relação ao resto do mundo por meio de disfarces ou outros meios semelhantes.";

            Console.WriteLine($"O texto possui {RetornarNumeroPalavrasDiferentesEmTexto(textoExemplo)}" +
                $" palavras diferentes");
            Console.ReadLine();
        }

        static int RetornarNumeroPalavrasDiferentesEmTexto(string texto)
        {
            Dictionary<string, int> palavrasContadas = new Dictionary<string, int>();
            string[] palavras = texto.Split(' ', ',', '.', '"');
            foreach (var item in palavras)
            {
                if (item.Length != 0)
                {
                    int count;
                    if (!palavrasContadas.TryGetValue(item.ToLower(), out count))
                    {
                        count = 0;
                    }
                    palavrasContadas[item.ToLower()] = count + 1;
                }
            }
            return palavrasContadas.Count;
        }

    }
}

