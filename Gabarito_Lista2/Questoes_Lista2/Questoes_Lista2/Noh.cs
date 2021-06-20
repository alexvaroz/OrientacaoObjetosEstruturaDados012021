using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questoes_Lista2
{
    class Noh
    {
        public Noh(int valor)
        {
            Valor = valor;
            Esquerda = null;
            Direita = null;
        }

        public int Valor { get; set; }
        public Noh Esquerda { get; set; }
        public Noh Direita { get; set; }
    }
}
