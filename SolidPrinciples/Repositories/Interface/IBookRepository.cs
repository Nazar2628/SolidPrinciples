using SolidPrinciples.Models;

namespace SolidPrinciples.Repositories.Interface
{
    public interface IBookRepository
    {
        void Save(Book book);
        Book GetById(int id);
        List<Book> GetAll();
    }

}
