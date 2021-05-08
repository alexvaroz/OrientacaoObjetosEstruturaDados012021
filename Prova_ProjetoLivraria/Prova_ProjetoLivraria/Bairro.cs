using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova_ProjetoLivraria
{
    class Bairro
    {
        public Bairro(string nome)
        {
            Nome = nome;
        }

        public string Nome { get; private set; }
    }
}
