using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questao2
{
    class NoBin
    {
        public NoBin(string valor)
        {
            Valor = valor;
            Esquerda = null;
            Direita = null;
        }

        public string Valor { get; set; }
        public NoBin Esquerda { get; set; }
        public NoBin Direita { get; set; }
    }

}
