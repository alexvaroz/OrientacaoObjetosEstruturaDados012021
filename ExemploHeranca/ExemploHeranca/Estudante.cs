using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploHeranca
{
    class Estudante : Humano
    {
        int nota;

        
        public Estudante(string nome, string ultimoNome, int nota): base (nome, ultimoNome)
        {
            this.nota = nota;
        }

        public void InformarSeAprovado()
        {
            if (nota >= 5)
                Console.WriteLine($"O aluno {base.InformarNomeCompleto()} foi aprovado");
            else
                Console.WriteLine($"O aluno {base.InformarNomeCompleto()} foi reprovado");
        }
        
    }
}
