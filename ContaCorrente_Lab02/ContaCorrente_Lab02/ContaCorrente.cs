using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaCorrente_Lab02
{
    class ContaCorrente : Conta
    {
        const double TAXA_SAQUE = 0.37/100;
        const double TAXA_TRANSFERENCIA = 0.10/100;

        public ContaCorrente(string idConta, string nomeCorrentista) : base(idConta, nomeCorrentista)
        {
        }

        public void SacarValor(double valorSacado)
        {
            base.SacarValor(valorSacado, TAXA_SAQUE);
        }

        public void TransferirValorConta(double valorTransferido, Conta contaDestino)
        {
            base.TransferirValorConta(valorTransferido, contaDestino, TAXA_TRANSFERENCIA);
        }
    }
}
