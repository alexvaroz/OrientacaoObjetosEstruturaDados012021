using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Leitura_conteudo_arquivos
{
    class Program
    {
        static void Main(string[] args)
        {
            string nomeArquivoCriado = ConfigurarArquivo();
            // Primeira forma de leitura 
            string[] times = File.ReadAllLines(nomeArquivoCriado);
            foreach (var item in times)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();

            // Segunda forma de leitura -> usa o StreamReader
            StreamReader reader = new StreamReader(nomeArquivoCriado);
            string linhaArquivo;
            while ((linhaArquivo = reader.ReadLine()) != null)
            {
                Console.WriteLine(linhaArquivo);
            }
            Console.ReadLine();

            // Terceira forma de leitura -> File.OpenText
            StreamReader readerOpenText = File.OpenText(nomeArquivoCriado);
            while (!readerOpenText.EndOfStream)
            {
                Console.WriteLine(readerOpenText.ReadLine());
            }
            Console.ReadLine();

        }

        private static string ConfigurarArquivo()
        {
            string pathDiretorio = "..//..//arquivos/";
            string nomeArquivo = "times.txt";
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
