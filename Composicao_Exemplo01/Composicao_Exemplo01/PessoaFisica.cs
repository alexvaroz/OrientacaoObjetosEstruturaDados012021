using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composicao_Exemplo01
{
    class PessoaFisica : Pessoa
    {
        public string CPF { get; private set; }
        public Sexo Sexo { get; private set; }
        public Emprego Emprego  { get; private set; }

        public PessoaFisica(string nome, string cPF, Sexo sexo, Emprego emprego) : base (nome)
        {
            CPF = cPF;
            Sexo = sexo;
            Emprego = emprego;
        }
    }

    enum Sexo
    {
        Masculino,
        Feminino
    }
}
