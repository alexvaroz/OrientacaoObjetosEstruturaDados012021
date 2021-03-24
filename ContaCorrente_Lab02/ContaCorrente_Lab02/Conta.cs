using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaCorrente_Lab02
{
    class Conta
    {
        public string IdConta { get; private set; }
        public string NomeCorrentista { get; private set; }
        public double SaldoConta { get; protected set; }

        public Conta(string idConta, string nomeCorrentista)
        {
            IdConta = idConta;
            NomeCorrentista = nomeCorrentista;
            SaldoConta = 0;
        }

        // Depositar, transferir, sacar e verificar
        public void DepositarValor(double valorDeposito) 
        {
            SaldoConta += valorDeposito;
        }

        public virtual void TransferirValorConta(double valorTranferencia, Conta contaDestino, double TAXA_TRANSFERENCIA)
        {
            if (SaldoConta >= valorTranferencia + (TAXA_TRANSFERENCIA) * valorTranferencia)
            {
                SaldoConta = SaldoConta - valorTranferencia - (TAXA_TRANSFERENCIA) * valorTranferencia;
                contaDestino.DepositarValor(valorTranferencia);
            }
            else
                Console.WriteLine("Operação não pode ser realizada por falta de saldo.");
        }

        public virtual void SacarValor(double valorSacado, double TAXA_SAQUE)
        {
            if (SaldoConta >= valorSacado + (TAXA_SAQUE) * valorSacado)
                SaldoConta = SaldoConta - valorSacado - (TAXA_SAQUE) * valorSacado;
            else
                Console.WriteLine("Operação não pode ser realizada por falta de saldo.");
        }

        public double VerificarSaldo()
        {
            return SaldoConta;
        } 

    }
}
