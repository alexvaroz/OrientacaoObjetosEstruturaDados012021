using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questao3
{
    /*
     * Uma das estruturas de dados estudadas durante o curso permite que sejam utilizadas para 
     * validar estruturas de expressões numéricas, como por exemplo, verificar se os parênteses 
     * estão dispostos de forma correta. Qual é ela, e a utilize para criar um método que avalie 
     * se uma determinada expressão está com os parênteses dispostos de forma correta.
     * Use a seguinte expressão para avaliar: 
     * “1+ (5 +3 - (8-5)*4 - ((3+7)*(3-1)))”
     */

    class Program
    {
        static void Main(string[] args)
        {
            string expressaoNumericaValida = "1+ (5 +3 - (8-5)*4 - ((3+7)*(3-1)))";
            string expressaoNumericaInValida = "1+ (5 +3 - (8-5)*4 - ((3+7)*((3-1)))";

            if (ValidarSeExpressaoCorreta(expressaoNumericaValida))
            {
                Console.WriteLine($"A expressão '{expressaoNumericaValida}' está correta!!");
            }
            else
            {
                Console.WriteLine($"A expressão '{expressaoNumericaValida}' está incorreta!!");
            }

            if (ValidarSeExpressaoCorreta(expressaoNumericaInValida))
            {
                Console.WriteLine($"A expressão '{expressaoNumericaInValida}' está correta!!");
            }
            else
            {
                Console.WriteLine($"A expressão '{expressaoNumericaInValida}' está incorreta!!");
            }

            Console.ReadLine();
        }

        static bool ValidarSeExpressaoCorreta(string expressao)
        {
            Stack<char> pilhaParenteses = new Stack<char>();
            char[] caracteresExpressao = expressao.ToCharArray();

            foreach (var item in caracteresExpressao)
            {
                if (item == '(')
                {
                    pilhaParenteses.Push(item);
                }
                if (item == ')')
                {
                    if (pilhaParenteses.Count == 0)
                    {
                        return false;
                    }
                    pilhaParenteses.Pop();
                }
            }
            if (pilhaParenteses.Count != 0)
            {
                return false;
            }

            return true;
        }
    }
}
