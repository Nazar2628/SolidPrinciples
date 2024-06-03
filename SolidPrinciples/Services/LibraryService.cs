using SolidPrinciples.Filters;
using SolidPrinciples.Models;
using SolidPrinciples.Repositories.Interface;

namespace SolidPrinciples.Services
{
    public class LibraryService
    {
        private readonly IBookRepository _bookRepository;

        public LibraryService(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public void AddBook(Book book)
        {
            _bookRepository.Save(book);
        }

        public List<Book> GetBooksByFilter(BookFilter filter)
        {
            return _bookRepository.GetAll().Where(filter.IsSatisfiedBy).ToList();
        }
    }

}
