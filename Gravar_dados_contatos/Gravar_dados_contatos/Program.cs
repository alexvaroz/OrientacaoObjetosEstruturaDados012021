using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Gravar_dados_contatos
{
    class Program
    {
        static void Main(string[] args)
        {
            Arquivo.ConfigurarArquivo();
            string opcaoMenu = null;
            opcaoMenu = ApresentarMenuOpcoes();
            while (opcaoMenu != "S")
            {
                switch (opcaoMenu)
                {
                    case "1":
                        InserirNovoCovoContato();
                        opcaoMenu = ApresentarMenuOpcoes();
                        break;
                    case "2":
                        ListarTodosContatos();
                        opcaoMenu = ApresentarMenuOpcoes();
                        break;
                    case "3":
                        RecuperarInformacoesContato();
                        opcaoMenu = ApresentarMenuOpcoes();
                        break;
                    case "4":
                        AlterarTelefoneContato();
                        opcaoMenu = ApresentarMenuOpcoes();
                        break;
                    case "5":
                        ApagarContato();
                        opcaoMenu = ApresentarMenuOpcoes();
                        break;
                    default:
                        Console.WriteLine("Opção não reconhecida... Tente novamente...");
                        Console.ReadLine();
                        Console.Clear();
                        opcaoMenu = ApresentarMenuOpcoes();
                        break;
                }
            }

        }

        private static string ApresentarMenuOpcoes()
        {
            string opcaoMenu;
            Console.WriteLine("Digite a opção desejada:");
            Console.WriteLine("Digite '1' para inserir um novo contato");
            Console.WriteLine("Digite '2' para listar todos os contatos");
            Console.WriteLine("Digite '3' para procurar um contato");
            Console.WriteLine("Digite '4' para alterar telefone do contato");
            Console.WriteLine("Digite '5' para apagar um contato");
            Console.WriteLine("Digite 'S' para sair da agenda");
            opcaoMenu = Console.ReadLine();
            return opcaoMenu;
        }

        private static void InserirNovoCovoContato()
        {
            Console.WriteLine("Insira os dados dos contatos desejados:");
            Console.WriteLine("Digite o nome:");
            string nomeContato = Console.ReadLine();
            Console.WriteLine("Digite a data de nascimento (dd/mm/yyyy):");
            string dataNascimento = Console.ReadLine();
            Console.WriteLine("Digite o telefone:");
            string telefone = Console.ReadLine();
            Contato contato = new Contato(nomeContato, dataNascimento, telefone);
            Arquivo.InserirConteudoArquivo(contato.ToString());
            Console.ReadLine();
            Console.Clear();
        }

        private static void ListarTodosContatos()
        {
            List<string> contatos = Arquivo.RecuperarConteudoArquivo();
            if (contatos.Count == 0)
            {
                Console.WriteLine("Não existe contato no arquivo.");
            }
            foreach (var contato in contatos)
            {
                Console.WriteLine(contato);
            }
            Console.ReadLine();
            Console.Clear();
        }

        static void RecuperarInformacoesContato()
        {
            Console.WriteLine("Digite o nome do contato procurado:");
            string nomeContato = Console.ReadLine();
            Contato contatoRecuperado = RecuperarContatoPorNome(nomeContato);
            if (contatoRecuperado != null)
            {
                Console.WriteLine(contatoRecuperado.ToString());
            }
            else
            {
                Console.WriteLine("O contato indicado não foi localizado.");
            }
            Console.ReadLine();
            Console.Clear();
        }

        private static Contato RecuperarContatoPorNome(string nomeContato)
        {
            List<Contato> listaContatos = RecuperarContatosArquivo();
            foreach (Contato contato in listaContatos)
            {
                if (contato.Nome.ToLower() == nomeContato.ToLower())

                {
                    return contato;
                }
            }
            return null;
        }

        private static void ApagarContato()
        {
            Console.WriteLine("Digite o nome do contato que deseja apagar:");
            string contatoApagar = Console.ReadLine();
            Contato contato = RecuperarContatoPorNome(contatoApagar);
            if (contato != null)
            {
                List<Contato> listaContatos = RecuperarContatosArquivo();
                for (int i = 0; i < listaContatos.Count; i++)
                {
                    if (listaContatos[i].Nome.ToLower() == contato.Nome.ToLower())
                    {
                        listaContatos.RemoveAt(i);
                    }
                }
                List<string> listaContatosString = TransformarListaContatosEmListaString(listaContatos);
                Arquivo.AtualizarConteudoArquivo(listaContatosString);
                Console.WriteLine($"Foi apagado o contato {contato.Nome}.");
            }
            else
            {
                Console.WriteLine("O contato indicado não foi localizado.");
            }
            Console.ReadLine();
            Console.Clear();
        }

        private static List<string> TransformarListaContatosEmListaString(List<Contato> listaContatos)
        {
            List<string> listaContatosString = new List<string>();
            foreach (Contato contato in listaContatos)
            {
                listaContatosString.Add(contato.ToString());
            }
            return listaContatosString;
        }

        private static List<Contato> RecuperarContatosArquivo()
        {
            List<string> contatosEmString = Arquivo.RecuperarConteudoArquivo();
            List<Contato> contatos = new List<Contato>();
            for (int i = 0; i < contatosEmString.Count; i++)
            {
                string[] contatoString = contatosEmString[i].Split(';');
                Contato contatoRecuperado = new Contato(contatoString[0].Trim(), contatoString[1].Trim(),
                    contatoString[2].Trim());
                contatos.Add(contatoRecuperado);
            }
            return contatos;
        }

        static void AlterarTelefoneContato()
        {
            Console.WriteLine("Digite o nome do contato que deseja alterar o telefone:");
            string contatoAEditar = Console.ReadLine();
            Contato contatoEditar = RecuperarContatoPorNome(contatoAEditar);
            if (contatoEditar != null)
            {
                Console.WriteLine("Informe o novo número de telefone:");
                string novoTelefone = Console.ReadLine();
                List<Contato> listaContatos = RecuperarContatosArquivo();
                for (int i = 0; i < listaContatos.Count; i++)
                {
                    if (listaContatos[i].Nome.ToLower() == contatoEditar.Nome.ToLower())
                    {
                        listaContatos[i].AtualizarTelefone(novoTelefone);
                    }
                }
                List<string> listaContatosString = TransformarListaContatosEmListaString(listaContatos);
                Arquivo.AtualizarConteudoArquivo(listaContatosString);
                Console.WriteLine($"Atualização de telefone realizada com sucesso.");
            }
            else
            {
                Console.WriteLine("O contato indicado não foi localizado.");
            }
            Console.ReadLine();
            Console.Clear();
        }
    }
}
