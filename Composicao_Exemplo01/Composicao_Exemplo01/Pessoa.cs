using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composicao_Exemplo01
{
    abstract class Pessoa
    {
       
        public string Nome { get; protected set; }

        public Pessoa(string nome)
        {
            Nome = nome;
        }

    }
}
