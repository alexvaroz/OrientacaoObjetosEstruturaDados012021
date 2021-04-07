using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composicao_Exemplo01
{
    class Emprego
    {
        public Emprego(string descricao, PessoaJuridica empresa, double salario)
        {
            Descricao = descricao;
            Empresa = empresa;
            Salario = salario;
        }

        public string Descricao { get; private set; }
        public PessoaJuridica Empresa { get; private set; }
        public double Salario { get; private set; }

        public void ReajustarSalarioComPercentual(int taxaPercentual)
        {
            Salario = Salario * (1 + (float) taxaPercentual / 100);
        }
    }
}
