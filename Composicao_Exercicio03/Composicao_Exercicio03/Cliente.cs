using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composicao_Exercicio03
{
    class Cliente
    {
        public Cliente(string nome, string cPF)
        {
            Nome = nome;
            CPF = cPF;
        }

        public string Nome { get; private set; }
        public string CPF { get; private set; }
    }
}
