using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcularIMC_Lab01
{
    class Usuario
    {
        public string nome;
        public int idade;
        public float peso;
        public float altura;

        public Usuario(string nome, int idade, float peso, float altura)
        {
            this.nome = nome;
            this.idade = idade;
            this.peso = peso;
            this.altura = altura;
        }

        private float CalcularIMC()
        {
            return this.peso/(this.altura*this.altura);
        }

        public string InformarSituacaoIMC()
        {
            string situacaoIMC = "Erro na identificação da situação";
            float imc = CalcularIMC();
            
            if (imc >= 18.5f & imc <= 24.9f)
                situacaoIMC = "Parabéns — você está em seu peso normal!";           
            if (imc >= 25.0f & imc <= 29.9f)
                situacaoIMC = "Você está acima de seu peso (sobrepeso)";
            if (imc >= 30.0f & imc <= 34.9f)
                situacaoIMC = "Obesidade grau I.";
            if (imc >= 35.0f & imc <= 39.9f)
                situacaoIMC = "Obesidade grau II.";
            if (imc >= 40.0f)
                situacaoIMC = "Obesidade graus III e IV.";
            return situacaoIMC;
        }

        public float InformarMetaPeso()
        {
            float IMC_IDEAL = 24.9f;
            return IMC_IDEAL * (this.altura) * (this.altura);
        }
    }
}
