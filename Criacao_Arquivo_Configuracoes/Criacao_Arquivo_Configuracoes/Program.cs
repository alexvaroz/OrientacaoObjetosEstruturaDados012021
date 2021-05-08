using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Criacao_Arquivo_Configuracoes
{
    class Program
    {
        static void Main(string[] args)
        {
            string pathDiretorio = "..//..//arquivos/";
            string nomeArquivo = "configuracoes.txt";
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
