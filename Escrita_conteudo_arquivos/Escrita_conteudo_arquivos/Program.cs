using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escrita_conteudo_arquivos
{
    class Program
    {
        static void Main(string[] args)
        {
            // Escrever sem o append
            string nomeArquivo = ConfigurarArquivo();
            StreamWriter writer = new StreamWriter(nomeArquivo);
            writer.WriteLine("Brasília");
            writer.WriteLine("Goiânia");
            writer.WriteLine("São Paulo");
            writer.WriteLine("Madri");
            writer.WriteLine("Nairobi");
            writer.Close();

            // Escrever com o append
            StreamWriter writerComAppend = new StreamWriter(nomeArquivo, append: true);
            writerComAppend.WriteLine("Tóquio");
            writerComAppend.WriteLine("Seul");
            writerComAppend.WriteLine("Rio");
            writerComAppend.WriteLine("Marselha");
            writerComAppend.Close();

        }

        private static string ConfigurarArquivo()
        {
            string pathDiretorio = "..//..//arquivos/";
            string nomeArquivo = "cidades.txt";
            if (!Directory.Exists(pathDiretorio))
            {
                CriarDiretorio(pathDiretorio);
                CriarArquivo(pathDiretorio, nomeArquivo);
            }
            else
            {
                if (!File.Exists(pathDiretorio + nomeArquivo))
                {
                    CriarArquivo(pathDiretorio, nomeArquivo);
                }
            }
            return pathDiretorio + nomeArquivo;
        }

        private static void CriarArquivo(string pathDiretorio, string nomeArquivo)
        {
            File.Create(pathDiretorio + nomeArquivo).Close();
            Console.WriteLine($"Arquivo {nomeArquivo} criado.");
        }

        private static void CriarDiretorio(string pathDiretorio)
        {
            Directory.CreateDirectory(pathDiretorio);
            Console.WriteLine($"Diretório {pathDiretorio} criado.");
        }
    }
}
