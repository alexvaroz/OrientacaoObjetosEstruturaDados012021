using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questao3
{
    class Program
    {
        /*
         * A brincadeira "Batata Quente" é um popular jogo infantil no qual um objeto é passado 
         * de mão em mão pelas crianças dispostas em um círculo. A passagem do objeto é interrompida 
         * de forma aleatória e a criança que ficou com o objeto na mão é retirada do círculo. 
         * Então o jogo recomeça  e o objeto retorna a ser transmitido de criança a criança até uma 
         * nova interrupção e consequente  eliminação de mais um participante. 
         * O jogo procede com essa dinâmica ate que reste apenas 1 criança. Essa brincadeira pode 
         * ser simulada por um programa que receba uma lista de crianças e um valor fixo ou variável 
         * que será usado como interrupção. Crie um método que receba essa lista de crianças e 
         * informe quem venceu a brincadeira. Para efeito de teste, considere a seguinte relação 
         * de crianças: { Abel, Bob, Carol, Duda, Eva e Franco}
         */
        
        static void Main(string[] args)
        {
            string[] criancas = { "Ana", "Bob", "Carol", "Duda", "Eva",  "Franco" };
            int intervalo = 7;
            Console.WriteLine($"O vencedor do jogo é {JogarBatataQuente(criancas, intervalo)}");
            Console.ReadLine();
        }

        static string JogarBatataQuente(string[] criancas, int intervalo)
        {
            Queue<string> filaCriancas = new Queue<string>();
            for (int i = 0; i < criancas.Length; i++)
            {
                filaCriancas.Enqueue(criancas[i]);
            }

            while (filaCriancas.Count > 1)
            {
                for (int i = 0; i < intervalo; i++)
                {
                    filaCriancas.Enqueue(filaCriancas.Dequeue());
                }
                filaCriancas.Dequeue();
            }
            return filaCriancas.Peek();
        }
    }
}
