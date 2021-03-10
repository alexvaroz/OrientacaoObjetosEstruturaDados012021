using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo03_Aula01
{
    class Carro
    {
        // Atributos
        public string modelo;
        public string cor;
        public int anoFabricacao;
        public int velocidadeMaxima;
        public int velocidadeAtual;
        public bool seLigado;

        // Construtores
        public Carro(string modelo, string cor, int anoFabricacao, int velocidadeMaxima)
        {
            this.modelo = modelo;
            this.cor = cor;
            this.anoFabricacao = anoFabricacao;
            this.velocidadeMaxima = velocidadeMaxima;
            this.velocidadeAtual = 0;
            this.seLigado = false;
        }

        public Carro() { }

        // Métodos
        public void Ligar()
        {
            this.seLigado = true;
            Console.WriteLine("Carro ligado!!");
            Console.ReadLine();
        }

        public void Acelerar()
        {
            this.velocidadeAtual = this.velocidadeAtual + 10;
        }

        public void Freiar()
        {
            this.velocidadeAtual = this.velocidadeAtual - 10;
        }

    }
}
