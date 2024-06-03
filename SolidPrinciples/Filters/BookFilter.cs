using SolidPrinciples.Models;

namespace SolidPrinciples.Filters
{
    public abstract class BookFilter
    {
        public abstract bool IsSatisfiedBy(Book book);
    }

}
