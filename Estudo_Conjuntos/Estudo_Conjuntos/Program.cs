using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudo_Conjuntos
{
    class Program
    {
        static void Main(string[] args)
        {
            string textoASerAnalisado = "" +
                "Minha terra tem palmeiras, Onde canta o Sabiá; As aves, que aqui gorjeiam, " +
                "Não gorjeiam como lá. Nosso céu tem mais estrelas, Nossas várzeas têm mais flores, " +
                "Nossos bosques têm mais vida, Nossa vida mais amores.";
            string adicional = " Bob Bob Bob Bob Bob Bob";

            Console.WriteLine($"O texto analisado possui {ContarPalavrasUnicasEmTexto(textoASerAnalisado + adicional)} palavras distintas");
            Console.ReadLine();
        }

        static int ContarPalavrasUnicasEmTexto(string texto)
        {
            HashSet<string> palavrasDoTexto = new HashSet<string>();
            string[] palavras = texto.Split(' ', ',', ';', '.');
            foreach (var item in palavras)
            {
                if (item.Length != 0)
                {
                    palavrasDoTexto.Add(item);
                }
            }
            return palavrasDoTexto.Count();
        }
    }
}
