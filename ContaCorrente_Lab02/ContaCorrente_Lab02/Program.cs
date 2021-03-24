using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaCorrente_Lab02
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente bob = new ContaCorrente("12345-6", "Bob Nelson");
            ContaPoupanca testolfo = new ContaPoupanca("71717-1", "Testolfo Rocha");
            ContaCorrente lisa = new ContaCorrente("65432-1", "Lisa Leite");

            bob.DepositarValor(5000);
            lisa.DepositarValor(2000);
            testolfo.DepositarValor(1500);
            bob.TransferirValorConta(600, testolfo);
            lisa.SacarValor(250);
            lisa.TransferirValorConta(400, testolfo);
            testolfo.TransferirValorConta(1000,bob);
            bob.SacarValor(900);
            bob.TransferirValorConta(1500, lisa);
            testolfo.TransferirValorConta(1200, lisa);
            bob.SacarValor(2000);
            lisa.DepositarValor(100);
            testolfo.TransferirValorConta(700, bob);

            ImprimirValorDosSaldos(bob, testolfo, lisa);
            

        }

        static void ImprimirValorDosSaldos(Conta conta1, Conta conta2, Conta conta3)
        {
            Console.WriteLine($"Saldo da conta de {conta1.NomeCorrentista}: {conta1.SaldoConta.ToString("C")} reais");
            Console.WriteLine($"Saldo da conta de {conta2.NomeCorrentista}: {conta2.SaldoConta.ToString("C")} reais");
            Console.WriteLine($"Saldo da conta de {conta3.NomeCorrentista}: {conta3.SaldoConta.ToString("C")} reais");
            Console.ReadLine();

        }
    }
}
