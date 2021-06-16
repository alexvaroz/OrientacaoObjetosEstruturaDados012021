using System;
using System.Collections.Generic;
using System.Text;

namespace Questao2
{
    class Medico
    {
        public Medico(string nome, string especialidade)
        {
            Nome = nome;
            Especialidade = especialidade;
        }

        public string Nome { get; set; }
        public string Especialidade { get; set; }

        public void ImprimirInformacoes()
        {
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Especialidade: {Especialidade}");
            Console.WriteLine($"*************************");
        }
    }
}
