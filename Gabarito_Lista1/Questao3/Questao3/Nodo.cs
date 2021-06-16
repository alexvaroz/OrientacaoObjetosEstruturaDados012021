using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Questao3
{
    class Nodo
    {
        public int Dado { get; set; }
        public Nodo Elo { get; set; } = null;
    }
}
