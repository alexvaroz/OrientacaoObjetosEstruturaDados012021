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
            List<string> KidsList = new List<string>();
            KidsList.Add("Abel");
            KidsList.Add("Bob");
            KidsList.Add("Carol");
            KidsList.Add("Duda");
            KidsList.Add("Eva");
            KidsList.Add("Franco");

            int random;
            int kidAtual = 0;

            for (int i = 0; KidsList.Count > 1; i++)
            {
                Console.WriteLine(i);
                Random rnd = new Random();
                random = rnd.Next(0, 100);

                if (random > 20)
                {
                    KidsList.RemoveAt(kidAtual);
                    Console.WriteLine(kidAtual);
                }
                kidAtual++;
                if (kidAtual >= KidsList.Count) kidAtual = 0;
            }
            Console.WriteLine(KidsList[0]);
            Console.ReadLine();
        }
        
    }
    }
