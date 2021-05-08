using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gravar_dados_contatos
{
    class Contato
    {
        public Contato(string nome, string dataAniversario, string telefone)
        {
            Nome = nome;
            DataAniversario = dataAniversario;
            Telefone = telefone;
        }

        public string Nome { get; private set; }
        public string DataAniversario { get; private set; }
        public string Telefone { get; private set; }

        public void AtualizarTelefone(string novoTelefone)
        {
            Telefone = novoTelefone;
        }

        public override string ToString()
        {
            return $"{Nome}; {DataAniversario}; {Telefone}";
        }

    }
}
