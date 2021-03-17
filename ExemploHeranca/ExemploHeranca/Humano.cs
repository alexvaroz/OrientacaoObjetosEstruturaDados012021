using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExemploHeranca
{
    class Humano
    {
        string primeiroNome;
        string ultimoNome;

        public Humano(string primeiroNome, string ultimoNome)
        {
            this.primeiroNome = primeiroNome;
            this.ultimoNome = ultimoNome;
        }

        

        public string PrimeiroNome { get => primeiroNome; }
        public string UltimoNome { get => ultimoNome; }

        public string InformarNomeCompleto()
        {
            return $"{primeiroNome} {ultimoNome}";
        }
    }

}
