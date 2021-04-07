using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composicao_Exercicio03
{
    class Program
    {
        static void Main(string[] args)
        {
            // Criar produtos
            Produto sacoArroz = new Produto("Saco 5Kg Arroz", 10, 16.99f);
            Produto sacoAcucar = new Produto("Saco 5Kg Açucar", 8, 9.99f);
            Produto sacoCafe = new Produto("Saco 1Kg Café", 20, 7.49f);

            // Criar Clientes
            Cliente bob = new Cliente("Bob Nelson", "111.222.333-99");

            ItemPedido arroz = new ItemPedido(sacoArroz, 2);
            ItemPedido cafe = new ItemPedido(sacoCafe, 5);
            ItemPedido[] itens = { arroz, cafe };
            Pedido pedidoBob = new Pedido(itens, bob, TipoPagamento.Cartão);
            pedidoBob.RealizarCompra();
            sacoAcucar.InformarEstoqueAtual();
            sacoArroz.InformarEstoqueAtual();
            sacoCafe.InformarEstoqueAtual();
            Console.ReadLine();
        }
    }
}
