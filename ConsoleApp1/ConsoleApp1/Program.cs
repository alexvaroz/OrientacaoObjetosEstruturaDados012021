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
            int diasVividos;
            int anos = 0;
            int mes = 0;

            Console.WriteLine("Digite os dias de vida");
            diasVividos = int.Parse(Console.ReadLine());

            while (diasVividos != 0)
            {
                if (diasVividos >= 360)
                {
                    diasVividos -= 360;
                    anos += 1;
                }
                else if (diasVividos >= 30)
                {
                    diasVividos -= 30;
                    mes += 1;
                }
                else
                {
                    break;
                }
            }

            Console.WriteLine($"\n {anos} anos {mes} meses {diasVividos} dias");

            Console.ReadLine();
        }
    }
}
