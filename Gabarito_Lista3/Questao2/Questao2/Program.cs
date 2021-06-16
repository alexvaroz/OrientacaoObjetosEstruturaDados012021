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
         * No texto considerado da questão anterior,  crie um método que realize a contagem de quantas 
         * vezes cada palavra é encontrada.
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

            Dictionary<string, int> palavrasComQuantidade = RetornarPalavrasEQuantidadesEmTexto(textoExemplo);
            Console.WriteLine("Segue relação de palavras e, respectivas, quantidades:");
            foreach(var item in palavrasComQuantidade)
            {
                Console.WriteLine($"{item.Key} - {item.Value} ");
            }
            Console.ReadLine();
        }

        static Dictionary<string, int> RetornarPalavrasEQuantidadesEmTexto(string texto)
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
            return palavrasContadas;
        }
    }
}
