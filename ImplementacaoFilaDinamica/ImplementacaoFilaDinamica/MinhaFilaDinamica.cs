using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImplementacaoFilaDinamica
{
    class MinhaFilaDinamica
    {
        public MinhaFilaDinamica()
        {
            Inicio = null;
            Tamanho = 0;
            Fim = null;
        }

        public Nodo Inicio { get; set; }
        public int Tamanho { get; set; }
        public Nodo Fim { get; set; }

        public void InserirElemento(string valor)
        {
            Nodo nodoNovo = new Nodo();
            nodoNovo.Valor = valor;
            Tamanho++;
            if (Fim != null)
            {
                Fim.Elo = nodoNovo;
            }
            Fim = nodoNovo;
            if (Inicio == null)
            {
                Inicio = nodoNovo;
            }
        }

        public string RemoverElemento()
        {
            string valor;
            if (Inicio == null)
            {
                Console.WriteLine("A fila está vazia...");
                return "FILA VAZIA";
            }
            else
            {
                valor = Inicio.Valor;
                Tamanho--;
                Inicio = Inicio.Elo;
                if (Inicio == null)
                {
                    Fim = null;
                }
                return valor;
            }
        }
    }
}
