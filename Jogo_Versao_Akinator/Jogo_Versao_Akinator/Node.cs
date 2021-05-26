using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jogo_Versao_Akinator
{
    class Node
    {
        public Node(string content)
        {
            NodeYes = null;
            Content = content;
            NodeNo = null;
        }

        public Node NodeYes { get; set; }
        public string Content { get; set; }
        public Node NodeNo { get; set; }

        public void ProcessNode()
        {
            if (isQuestion())
            {
                Console.WriteLine(Content);
                Console.WriteLine("Digite 's' para sim ou 'n' para não:");
                char answer = Console.ReadLine()[0];
                if (answer == 's')
                {
                    NodeYes.ProcessNode();
                }
                else
                {
                    NodeNo.ProcessNode();
                }
            } else
            {
                PresentAnswer();
            }
        }

        private bool isQuestion()
        {
            if (NodeYes != null && NodeNo != null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void PresentAnswer()
        {
            Console.WriteLine($"Por acaso você pensou em {Content}?");
            Console.WriteLine("Digite 's' para sim ou 'n' para não:");
            char answer = Console.ReadLine()[0];
            if (answer == 's')
            {
                Console.WriteLine("Opa... Parece que acertei!!! ");
            }
            else
            {
                Console.WriteLine("Poxa... Não consegui acertar...");
                Console.WriteLine("Mas, no que você estava pensando??");
                string correctAnswer = Console.ReadLine();
                Console.WriteLine($"Para me ajudar a melhorar, qual seria uma pergunta que poderia diferir entre " +
                    $"{Content} e {correctAnswer}??");
                string newQuestion = Console.ReadLine();
                Console.WriteLine($"Se você estiver pensando em {correctAnswer}, qual seria a resposta para essa questão??");
                char answerNewQuestion = Console.ReadLine()[0];
                if (answerNewQuestion == 's')
                {
                    NodeYes = new Node(correctAnswer);
                    NodeNo = new Node(Content);
                } else
                {
                    NodeYes = new Node(Content);
                    NodeNo = new Node(correctAnswer);
                }
                Content = newQuestion;
            }
        }
    }
}
