using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova_ProjetoLivraria
{
    class Livro : ItemLoja
    {
        public Livro(long id, PessoaJuridica fornecedor, float precoCompra, float precoVenda, string titulo, 
            EnumGenero genero, string autor, PessoaJuridica editora) : base(id, fornecedor, precoCompra, precoVenda)
        {
            Titulo = titulo;
            Genero = genero;
            Autor = autor;
            Editora = editora;
        }

        public string Titulo { get; private set; }
        public EnumGenero Genero { get; private set; }
        public string Autor { get; private set; }
        public PessoaJuridica Editora { get; private set; }

        public override void MostrarDescricao()
        {
            Console.WriteLine($"{Titulo} ({Autor}), publicado pela editora {Editora}");
        }

    }
}
