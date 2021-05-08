using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova_ProjetoLivraria
{
    class PessoaJuridica : Pessoa
    {
        public PessoaJuridica(long id, string nome, string cnpj, Endereco endereco, string email) : 
            base(id, nome, endereco, email)
        {
            Cnpj = cnpj;
        }

        public string Cnpj { get; private set; }

        public override void MostrarDescricao()
        {
            Console.WriteLine($"{Nome} ({Cnpj}), instalado(a) em {Endereco.Cidade.Nome}-{Endereco.Cidade.Estado.Sigla}");
        }
    }
}
