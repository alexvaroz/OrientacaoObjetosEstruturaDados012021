using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstudoColections
{
    class Program
    {
        static void Main(string[] args)
        {
            // ArrayList
            ArrayList meuPrimeiroArrayList = new ArrayList();
            meuPrimeiroArrayList.Add("Bob Nelson");
            meuPrimeiroArrayList.Add(99);
            meuPrimeiroArrayList.Add(false);
            int elementoArrayList = (int) meuPrimeiroArrayList[1];
            Console.WriteLine(meuPrimeiroArrayList.Contains(false));
            Console.ReadLine();

            //List
            List<String> listaDeNomes = new List<String>();

            // Exercicio Listas
            // Criar 2 listas com 20 números inteiros aleatórios entre 0 e 50
            Random rnd = new Random();
            List<int> listaA = new List<int>();
            List<int> listaB = new List<int>();

            // Criação das listas
            for (int i = 0; i < 20; i++)
            {
                listaA.Add(rnd.Next(0, 51));
                listaB.Add(rnd.Next(0, 51));
            }

            List<int> listaElementosEmComum = new List<int>();
            // Realizar a união das duas listas
            foreach (var item in listaB)
            {
                if (!listaA.Contains(item))
                {
                    listaA.Add(item);
                } else
                {
                    listaElementosEmComum.Add(item);
                }
            }

            Console.WriteLine($"Tamanho da lista acumulada: {listaA.Count()}");
            Console.WriteLine("Elementos em comum nas duas listas:");
            foreach (var item in listaElementosEmComum)
            {
                Console.Write($"{item} ");
            }
            
            Console.ReadLine();

        }
    }
}
