using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo02_Aula01
{
    class Program
    {
        static void Main(string[] args)
        {
            var bidu = new Cachorro();
            bidu.nome = "Bidu da Silva";
            bidu.raca = "Pit-bull";
            bidu.genero = "macho";
            bidu.idade = 3;

            bidu.Latir();
            bidu.AbanarRabo();
        }
    }
}
