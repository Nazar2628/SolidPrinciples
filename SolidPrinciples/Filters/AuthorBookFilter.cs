using SolidPrinciples.Models;

namespace SolidPrinciples.Filters
{
    public class AuthorBookFilter : BookFilter
    {
        private readonly string _author;

        public AuthorBookFilter(string author)
        {
            _author = author;
        }

        public override bool IsSatisfiedBy(Book book)
        {
            return book.Author == _author;
        }
    }

}
