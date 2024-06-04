using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Livros
    {
        public Livros(string titulo, string autor, string isbn)
        {
            Titulo = titulo;
            Autor = autor;
            Isbn = isbn;
        }

        public string Titulo { get; set; }
        public string Autor { get; set; }
        public string Isbn { get; set; }
    }
}