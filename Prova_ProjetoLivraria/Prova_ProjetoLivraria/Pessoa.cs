using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova_ProjetoLivraria
{
    abstract class Pessoa: IItemRelatorio
    {
        protected Pessoa(long id, string nome, Endereco endereco, string email)
        {
            Id = id;
            Nome = nome;
            Endereco = endereco;
            Email = email;
        }

        public long Id { get; private set; }
        public string Nome { get; private set; }
        public Endereco Endereco { get; private set; }
        public string Email { get; private set; }

        public abstract void MostrarDescricao();
    }
}
