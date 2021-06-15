using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contar_Palavras_Texto
{
    class Program
    {
        


        static void Main(string[] args)
        {
            string texto = "O termo “gamificação” é proveniente do inglês “gamification”. " +
            "Como você pode imaginar, esse tipo de estratégia tem como base o uso de " +
            "características provenientes dos games. Saiba mais sobre o conceito de gamificação e " +
            "como ela aumenta o engajamento de colaboradores e clientes.Portanto, a gamificação " +
            "utiliza mecanismos como desafios, pontuações, regras, premiações, fases, recompensas e " +
            "tudo o que você pode relacionar ao universo dos jogos, porém aplicada em outros contextos, " +
            "como a educação e, é claro, o mundo empresarial.";

            foreach(var item in ContarPalavrasEmTexto(texto))
            {
                Console.WriteLine(item);
                
            }
            Console.ReadLine();
        }

        static List<string> ContarPalavrasEmTexto(string texto)
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
            List<string> palavrasResultantes = new List<string>();

            foreach (var item in palavrasContadas)
            {
                if (item.Key.Length == 4)
                {
                    palavrasResultantes.Add(item.Key);
                }
                
            }

            return palavrasResultantes;
        }
    }
}
