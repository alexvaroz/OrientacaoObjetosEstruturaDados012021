using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jogo_Versao_Akinator
{
    class Tree
    {
        public Node Root { get; set; }

        public Tree(string question, string answerYes, string answerNo)
        {
            Root = new Node(question);
            Root.NodeYes = new Node(answerYes);
            Root.NodeNo = new Node(answerNo);
        }

        public void ProcessTree()
        {
            Root.ProcessNode();
        }

        
    }
}
