using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composicao_Exemplo01
{
    class PessoaJuridica : Pessoa
    {
        public PessoaJuridica(string nome, string cNPJ, PorteEmpresa porte) : base (nome)
        {
            CNPJ = cNPJ;
            Porte = porte;
        }

        public string CNPJ { get; set; }
        public PorteEmpresa Porte { get; set; }
    }

    enum PorteEmpresa
    {
        Pequeno,
        Médio,
        Grande
    }
}
