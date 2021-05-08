using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova_ProjetoLivraria
{
    class PessoaFisica : Pessoa
    {
        public PessoaFisica(long id, string nome, string cpf, bool vip, Endereco endereco, string email) : 
            base(id, nome, endereco, email)
        {
            Cpf = cpf;
            Vip = vip;
        }

        public string Cpf { get; private set; }
        public bool Vip { get; private set; }

        public override void MostrarDescricao()
        {
            Console.WriteLine($"{Nome} ({Cpf}), residente em {Endereco.Cidade.Nome}-{Endereco.Cidade.Estado.Sigla}");
        }
    }
}
