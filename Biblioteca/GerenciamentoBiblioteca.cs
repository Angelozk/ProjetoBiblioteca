using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Biblioteca;

namespace GerenciamentoBiblioteca
{
    public class BibliotecaL
    {
        private readonly List<Livros> _livros;

        public BibliotecaL()
        {
            _livros = new List<Livros>();
        }

        public void AdicionarLivro(Livros livro)
        {   
            _livros.Add(livro);
        }

        public bool RemoverLivro(string isbn)
        {
            var livro = _livros.SingleOrDefault(b => b.Isbn == isbn);
            if(livro != null)
            {
                _livros.Remove(livro);
                return true;
            }

            return false;
        }

        public Livros BuscarLivro(string isbn)
        {
            return _livros.SingleOrDefault(b => b.Isbn == isbn);
        }

        public List<Livros> ListarLivros()
        {
            return _livros;
        }
    }
}