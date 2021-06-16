using System;
using System.Collections.Generic;
using System.IO;

namespace Questao2
{
    /*
     * Criar um programa que leia o arquivo "listaEspera.txt", em anexo, que representa a lista de 
     * espera de um atendimento em uma clínica de múltiplas especialidades. O texto de apresentação 
     * deve seguir o formato ilustrado na figura. Importante destacar que a solução deve seguir uma 
     * organização básica de classes, seguindo responsabilidades específicas.
     */

    class Program
    {
        static void Main(string[] args)
        {
            string pathDiretorio = "..//..//..//arquivos/";
            string nomeArquivo = "ListaEspera.txt";

            string nomeCompletoArquivo = pathDiretorio + nomeArquivo;

            StreamReader reader = new StreamReader(nomeCompletoArquivo);
            string item;
            List<Medico> listaMedicos = new List<Medico>();

            while ((item = reader.ReadLine()) != null)
            {
                string[] palavras = item.Split(';');
                listaMedicos.Add(new Medico(palavras[0], palavras[1]));
            }

            foreach (var medico in listaMedicos)
            {
                medico.ImprimirInformacoes();
            }
            Console.ReadLine();
        }
}
}
