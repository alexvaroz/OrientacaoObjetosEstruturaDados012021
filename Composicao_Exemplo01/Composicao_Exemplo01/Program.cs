using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composicao_Exemplo01
{
    class Program
    {
        static void Main(string[] args)
        {
            PessoaJuridica estudioTop = new PessoaJuridica("Bad Minions", "0001.765.123-90", PorteEmpresa.Pequeno);
            Emprego empregoDesign = new Emprego("Design Gráfico", estudioTop, 4500);
            Emprego empregoDesenvolvedor = new Emprego("Desenvolvedor", estudioTop, 7000);
            PessoaFisica bob = new PessoaFisica("Bob Nelson", "999.888.777-22", Sexo.Masculino, empregoDesign);
            PessoaFisica testolfo = new PessoaFisica("Testolfo Rocha", "111.222.333-99", Sexo.Masculino, empregoDesenvolvedor);

            Console.WriteLine($"{bob.Nome} ({bob.CPF}) trabalha na empresa {bob.Emprego.Empresa.Nome} " +
                $"como {bob.Emprego.Descricao} com o salário de {bob.Emprego.Salario:c}");
            Console.WriteLine($"{testolfo.Nome} ({testolfo.CPF}) trabalha na empresa {testolfo.Emprego.Empresa.Nome} " +
                $"como {testolfo.Emprego.Descricao} com o salário de {testolfo.Emprego.Salario:c}");
            Console.ReadLine();
            Console.WriteLine("Após negociação, o salário do Bob Nelson foi reajustado em 7%");
            bob.Emprego.ReajustarSalarioComPercentual(7);
            Console.WriteLine($"{bob.Nome} ({bob.CPF}) trabalha na empresa {bob.Emprego.Empresa.Nome} " +
               $"como {bob.Emprego.Descricao} com o salário de {bob.Emprego.Salario:c}");
            Console.ReadLine();

        }
    }
}
