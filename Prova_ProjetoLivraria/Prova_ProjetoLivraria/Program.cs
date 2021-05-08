using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova_ProjetoLivraria
{
    class Program
    {
        static void Main(string[] args)
        {
            Estado df = new Estado("Distrito Federal", "DF");
            Cidade brasilia = new Cidade("Brasília", df);
            Bairro jardim = new Bairro("Jardim Botânico");
            Endereco enderecoBob = new Endereco(5, "3", jardim, brasilia);
            PessoaFisica bob = new PessoaFisica(100, "Bob Nelson", "111.222.333-90", false, enderecoBob, "bobNelsonGgmail.com");
            PessoaFisica testolfo = new PessoaFisica(150, "Testolfo Rocha", "222.333.444-90", false, 
                enderecoBob, "testollforocha@gmail.com");
            Cadastro cadastro = new Cadastro();
            cadastro.AdicionarCliente(bob);
            cadastro.AdicionarCliente(testolfo);
            cadastro.ImprimirClientes();
            Estado rj = new Estado("Rio de Janeiro", "RJ");
            Cidade rio = new Cidade("Rio de Janeiro", rj);
            Bairro copacabana = new Bairro("Copacabana");
            Endereco enderecoSodiler = new Endereco(4, "3", copacabana, rio);
            PessoaJuridica livraria = new PessoaJuridica(200, "Livraria Sodiler",
                "00.0001.456-12", enderecoSodiler, "sodiler@pop.com.br");
            cadastro.AdicionarFornecedor(livraria);
            cadastro.ImprimirFornecedores();
            PessoaJuridica editora = new PessoaJuridica(300, "Editora Azul",
                "00.0001.456-12", enderecoSodiler, "mail.com.br");


            Livro livro = new Livro(11, editora, 25.00f, 53.00f, "Princípios", EnumGenero.Negocios,
                "Rai Dalio", livraria);

            Estoque estoque = new Estoque();


            Console.ReadLine();

        }
    }
}
