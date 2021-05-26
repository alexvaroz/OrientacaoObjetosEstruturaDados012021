using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jogo_Versao_Akinator
{
    class Program
    {
        static Tree gameTree;

        static void Main(string[] args)
        {
            GameSetup();
            Console.WriteLine("Inciando o jogo!!!!!!!!!!!!");
            gameTree.ProcessTree();
            while (PlayAgain())
            {
                Console.Clear();
                gameTree.ProcessTree();
            }

        }

        static private void GameSetup()
        {
            Console.WriteLine("Nenhum conhecimento prévio...");
            Console.WriteLine("Inicializando o jogo...");
            Console.WriteLine("Apresente uma pergunta sobre super-heróis:");
            string firstQuestion = Console.ReadLine();
            Console.WriteLine("Apresente uma tentativa caso a resposta for 'sim':");
            string yesAnswer = Console.ReadLine();
            Console.WriteLine("Apresente uma tentativa caso a resposta for 'não':");
            string noAnswer = Console.ReadLine();
            gameTree = new Tree(firstQuestion, yesAnswer, noAnswer);
        }

        static bool PlayAgain()
        {
            Console.WriteLine("Vamos jogar outra partida???");
            char userAnswer = Console.ReadLine()[0];
            if (userAnswer == 's')
            {
                return true;
            } else
            {
                return false;
            }
        }
    }
}
