using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_CardapioButeco
{
    class Program
    {
        static void Main(string[] args)
        {
            Bebida cafeExpresso = new Bebida("Café Expresso", 3.99, 5.99, 7.99);
            Bebida sucoLaranja = new Bebida("Suco de Laranja", 5.99, 7.99, 9.99);
            Bebida refrigerante = new Bebida("Copo Refrigerante", 4.99, 5.99, 6.99);
            Aperitivo batataFrita = new Aperitivo("Porção de Batata Frita", 25.99);
            Aperitivo pasteis = new Aperitivo("Porção de Pastéis Variados", 30.99);
            BebidaAlcoolica cerveja = new BebidaAlcoolica("Cerveja Brahma", 5.99, 7.99, 9.99);
            BebidaAlcoolica vinho = new BebidaAlcoolica("Taça de vinho", 13.99, 18.99, 23.50);
            Cigarro cigarroMalboro = new Cigarro("Pacote Malboro", 11.99);
            

            ItemMenu[] itensCardapio = { cafeExpresso, sucoLaranja, refrigerante, batataFrita, 
                pasteis, cerveja, cigarroMalboro, vinho };
            ImprimirCardapio(itensCardapio);
            Console.ReadLine();

        }

        public static void ImprimirCardapio(ItemMenu[] itensCardapio)
        {
            Console.WriteLine("------ Cardápio ------");
            foreach (ItemMenu item in itensCardapio)
            {
                item.ImprimirPreco();
                Console.WriteLine("");
            }
        }
    }
}
