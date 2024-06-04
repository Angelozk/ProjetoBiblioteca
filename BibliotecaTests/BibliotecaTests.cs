using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Biblioteca;
using GerenciamentoBiblioteca;

namespace BibliotecaTests
{
    public class BibliotecaTests
    {
        [Fact]
        public void DeveAdicionarLivro()
        {
            var biblioteca = new BibliotecaL();
            var livro = new Livros("teste Nome", "Teste Autor", "123245");

            biblioteca.AdicionarLivro(livro);

            var resultado = biblioteca.ListarLivros();
            Assert.Contains(livro, resultado);
        }

        [Fact]
        public void DeveRemoverOLivroERetornarTrue()
        {
            var biblioteca = new BibliotecaL();
            var livro = new Livros("teste Nome", "Teste Autor", "123245");
            biblioteca.AdicionarLivro(livro);

            var resultado = biblioteca.RemoverLivro("123245");

            Assert.True(resultado);
        }

        [Fact]
        public void BuscaOLivroPeloIsbnERetornaOLivroCorreto()
        {
            var biblioteca = new BibliotecaL();
            var livro = new Livros("teste Nome", "Teste Autor", "123245");
            biblioteca.AdicionarLivro(livro);

            var resultado = biblioteca.BuscarLivro("123245");

            Assert.Equal(livro, resultado);
        }

        [Theory]
        [MemberData(nameof(GetBooksData))]
        public void ListarOsLivrosRetornandoTodos(List<Livros> livros)
        {
            var biblioteca = new BibliotecaL();
            foreach(var livro in livros)
            {
                biblioteca.AdicionarLivro(livro);
            }

            var resultado = biblioteca.ListarLivros();

            foreach(var livro in livros)
            {
                Assert.Contains(livro, resultado);
            }
        }
        public static IEnumerable<object[]> GetBooksData()
        {
            yield return new object[] { new List<Livros> { new Livros("teste Nome", "Teste Autor", "123245"), new Livros("teste Nome2", "Teste Autor2", "242454") } };
            yield return new object[] { new List<Livros> { new Livros("Teste Nome 3", "Test Autor 3", "54321"), new Livros("Teste Nome 4", "Teste Autor 4", "09876"), new Livros("Teste Nome 5", "Test Autor 5", "11223") } };
        }
    }
}