using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementacaoFilaDinamica
{
    class Nodo
    {
        public string Valor { get; set; }
        public Nodo Elo { get; set; } = null;
    }
}
