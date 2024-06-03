using SolidPrinciples.Models;
using SolidPrinciples.Repositories.Interface;

namespace SolidPrinciples.Repositories
{
    public class BookRepository : IBookRepository
    {
        private static List<Book> _books = new List<Book>();

        public void Save(Book book)
        {
            _books.Add(book);
        }

        public Book GetById(int id)
        {
            return _books.FirstOrDefault(b => b.Id == id);
        }

        public List<Book> GetAll()
        {
            return _books;
        }
    }

}
