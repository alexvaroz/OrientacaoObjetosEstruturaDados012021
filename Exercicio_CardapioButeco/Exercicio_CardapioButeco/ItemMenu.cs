using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_CardapioButeco
{
    abstract class ItemMenu
    {
        public string Nome { get; protected set; }


        public ItemMenu(string nome)
        {
            Nome = nome;
        }

        public virtual void ImprimirNome()
        {
            Console.WriteLine($">>>> {Nome}");
        }

        public abstract void ImprimirPreco();

    }
}
