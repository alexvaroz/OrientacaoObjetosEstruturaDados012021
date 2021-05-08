using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova_ProjetoLivraria
{
    class Cadastro
    {
        public List<PessoaFisica> Clientes = new List<PessoaFisica>();
        public List<PessoaJuridica> Fornecedores = new List<PessoaJuridica>();

        public void AdicionarCliente(PessoaFisica cliente)
        {
            Clientes.Add(cliente);
        }

        public void RemoverCliente(PessoaFisica cliente)
        {
            Clientes.Remove(cliente);
        }

        public void AdicionarFornecedor(PessoaJuridica fornecedor)
        {
            Fornecedores.Add(fornecedor);
        }

        public void RemoverFornecedor(PessoaJuridica fornecedor)
        {
            Fornecedores.Remove(fornecedor);
        }

        public void ImprimirClientes()
        {
            for (int i = 0; i < Clientes.Count; i++)
            {
                Clientes[i].MostrarDescricao();
            }
        }

        public void ImprimirFornecedores()
        {
            for (int i = 0; i < Fornecedores.Count; i++)
            {
                Fornecedores[i].MostrarDescricao();
            }
        }



    }
}
