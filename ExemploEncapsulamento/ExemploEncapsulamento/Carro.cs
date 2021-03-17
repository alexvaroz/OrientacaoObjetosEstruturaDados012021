using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploEncapsulamento
{
    class Carro
    {
        string modelo;
        string cor;
        int anoFabricacao;
        int velocidadeAtual = 0;
        int velocidadeMaxima;
        bool seLigado = false;

        public Carro(string modelo, string cor, int anoFabricacao, int velocidadeMaxima)
        {
            this.modelo = modelo;
            this.cor = cor;
            this.anoFabricacao = anoFabricacao;
            this.velocidadeMaxima = velocidadeMaxima;
        }

        public string Modelo { get => modelo; }
        public string Cor { get => cor; }
        public int AnoFabricacao { get => anoFabricacao; }
        public int VelocidadeAtual { get => velocidadeAtual; }
        public int VelocidadeMaxima { get => velocidadeMaxima; }
        public bool SeLigado { get => seLigado; }

        public void Ligar()
        {
            if (seLigado)
                Console.WriteLine("O carro já está ligado!!");
            else
            {
                this.seLigado = true;
                Console.WriteLine("O carro foi ligado!!");
            }
        }

        public void Desligar()
        {
            if (seLigado)
            {
                Console.WriteLine("O carro foi desligado!!");
                seLigado = false;
            }
            else
                Console.WriteLine("O carro já está desligado!!");           
        }

        public void Acelerar()
        {

        }
    }
}
