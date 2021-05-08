using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova_ProjetoLivraria
{
    class Cidade
    {
        public Cidade(string nome, Estado estado)
        {
            Nome = nome;
            Estado = estado;
        }

        public string Nome { get; set; }
        public Estado Estado { get; set; }
    }
}
