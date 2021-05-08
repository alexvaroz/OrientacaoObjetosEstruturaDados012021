using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gravar_dados_contatos
{
    class Arquivo
    {
        static string pathDiretorio = "..//..//arquivos/";
        static string nomeArquivo = "contatos.txt";
        static string localArquivoDados = pathDiretorio + nomeArquivo;

        public static string ConfigurarArquivo()
        {
            if (!Directory.Exists(pathDiretorio))
            {
                CriarDiretorio(pathDiretorio);
                CriarArquivo(localArquivoDados);
            }
            else
            {
                if (!File.Exists(localArquivoDados))
                {
                    CriarArquivo(localArquivoDados);
                }
            }
            return localArquivoDados;
        }

        public static void CriarArquivo(string localArquivoDados)
        {
            File.Create(localArquivoDados).Close();
        }

        public static void CriarDiretorio(string pathDiretorio)
        {
            Directory.CreateDirectory(pathDiretorio);
        }

        public static void InserirConteudoArquivo(string conteudoInserido)
        {
            StreamWriter writer = new StreamWriter(localArquivoDados, append: true);
            writer.WriteLine(conteudoInserido);
            writer.Close();
            Console.WriteLine("Registro inserido com sucesso!");
        }

        public static List<string> RecuperarConteudoArquivo()
        {
            StreamReader reader = new StreamReader(localArquivoDados);
            List<string> conteudo = new List<string>();
            while (!reader.EndOfStream)
            {
                string item = reader.ReadLine();
                conteudo.Add(item);
            }
            reader.Close();
            return conteudo;
        }

        public static void AtualizarConteudoArquivo(List<string> linhasConteudo)
        {
            CriarDiretorio(pathDiretorio);
            CriarArquivo(localArquivoDados);
            StreamWriter writer = new StreamWriter(localArquivoDados, append: true);
            foreach (string linha in linhasConteudo)
            {
                writer.WriteLine(linha);
            }
            writer.Close();
            Console.WriteLine("Conteúdo atualizado!");
        }
    }
}
