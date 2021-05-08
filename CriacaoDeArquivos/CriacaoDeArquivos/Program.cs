using System;
using System.IO;

namespace CriacaoDeArquivos
{
    class Program
    {
        static void Main(string[] args)
        {
            // Criar passando um caminho absoluto
            string path = @"D:\Usuarios\Alexandre\Documentos\Repositorio\ProfessorAlexvaroz\projetosOOED\CriacaoDeArquivos\CriacaoDeArquivos\";
            string nomeArquivo = "meuSegundoArquivo.txt";
            Stream arquivo = File.Create(path + nomeArquivo);

            // Obter diretório destino a partir da pasta "Debug" do projeto
            string nomeDiretorioExecucao = System.Environment.CurrentDirectory;
            Console.WriteLine(nomeDiretorioExecucao);
            string pathDiretorio = "..//..//";
            string nomeOutroArquivo = "arquivoCriadoPastaEspecifica.txt";
            Stream outroArquivo = File.Create(pathDiretorio + nomeOutroArquivo);

            // Criar um diretorio
            string nomeDiretorio = "Arquivos";
            Directory.CreateDirectory(pathDiretorio + nomeDiretorio);

            // Criar um diretorio para armazenar arquivos na raiz do projeto
            string nomeDiretorioArquivos = "ArquivosProjeto2/";
            Directory.CreateDirectory(pathDiretorio + nomeDiretorioArquivos);
            string pathDiretorioArquivos = "..//..//" + nomeDiretorioArquivos;
            string nomeNovoArquivo = "arquivoCriadoPastaEspecificaProjeto.txt";
            File.Create(pathDiretorioArquivos + nomeNovoArquivo);

            // Verificar se um arquivo já existe
            string nomeArquivoVerificado = "meuPrimeiroArquivo.txt";
            if (File.Exists(nomeArquivoVerificado))
            {
                Console.WriteLine("Arquivo existente...");
            } else
            {
                Console.WriteLine("Arquivo não existe...");
                Stream streamArquivo = File.Create(nomeArquivoVerificado);
                streamArquivo.Close();
            }

            // Verificar se um diretório já existe
            string nomeDiretorioVerificado = pathDiretorioArquivos;
            if (Directory.Exists(nomeDiretorioVerificado))
            {
                Console.WriteLine("Diretório existente...");
            }
            else
            {
                Console.WriteLine("Diretório não existe...");
                Directory.CreateDirectory(nomeDiretorioVerificado);
            }


            // Criar um novo diretório sem chamar explicitamente a classe Directory
            string pathNovoDiretorio = "..//..//NovaPasta/";
            Directory.CreateDirectory(pathNovoDiretorio);
            string nomeNovoArquivo2 = "arquivoNovoPastaEspecifica.txt";
            Stream stream = File.Create(pathNovoDiretorio + nomeNovoArquivo2);
            stream.Close();


            // Deletar arquivo
            File.Delete(pathNovoDiretorio + nomeNovoArquivo2);

            // Alterar nome do arquivo "meuPrimeiroArquivo.txt" para "meuNovoPrimeiroArquivo.txt"
            string novoNomeArquivo = "meuNovoPrimeiroArquivo.txt";
            string novoNovoNomeArquivo = "outroPrimeiroArquivo.txt";
            File.Move(nomeArquivoVerificado, novoNomeArquivo);
            File.Move(novoNomeArquivo, novoNovoNomeArquivo);




            Console.ReadLine();



        }
    }
}
