using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploHeranca
{
    class Trabalhador : Humano 
    {
        float salario;
        int horasTrabalhadas;

        public Trabalhador(string nome, string ultimoNome, float salario, int horasTrabalhadas):base(nome, ultimoNome)
        {
            this.salario = salario;
            this.horasTrabalhadas = horasTrabalhadas;
        }

        public void InformarRemuneracaoPorHora()
        {
            Console.WriteLine($"O trabalhador {base.InformarNomeCompleto()} recebe {salario / horasTrabalhadas} por hora.");
        }
    }
}
