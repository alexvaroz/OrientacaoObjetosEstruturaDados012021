using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo02_Aula01
{
    class Cachorro
    {
        public string nome;
        public string raca;
        public int idade;
        public string genero;

        public void AbanarRabo()
        {
            Console.WriteLine("Rabinho balançando!!!");
            Console.ReadLine();
        }

        public void Latir()
        {
            Console.WriteLine("Au au au");
            Console.ReadLine();
        }
    }
}
