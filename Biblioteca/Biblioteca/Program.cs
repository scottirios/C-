using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Livro livro = new Livro();
            livro.Titulo = "A Perfeitinha";
            livro.Autor = "Fallenzao";


            Livro livro2 = new Livro();
            livro2.Titulo = "T.I na Faculdade";
            livro2.Autor = "Lucas Sartori";

            Biblioteca biblioteca = new Biblioteca();
            biblioteca.Adicionar(livro);
            biblioteca.Adicionar(livro2);

            biblioteca.Consultar();

            biblioteca.SearchBook("A Perfeitinha");

        }

    }

    class Livro
    {
        public string Titulo;
        public string Autor;
    }


    class Biblioteca
    {
        public List<Livro> livros = new List<Livro>();


        public void Adicionar(Livro livro)
        {
            livros.Add(livro);
        }

        public void Consultar() {
            foreach (var livro in livros)
            {
                Console.WriteLine($"{livro.Titulo}, {livro.Autor}");
            }

        }

        public void SearchBook(string titulo)
        {
            foreach (var livro in livros)
            {
                if (titulo == livro.Titulo)
                {
                    Console.WriteLine("Livro encontrado");
                }
            }
        }
    }
}