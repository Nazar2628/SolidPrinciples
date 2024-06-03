using SolidPrinciples.Models;

namespace SolidPrinciples.Filters
{
    public class CheckedOutBookFilter : BookFilter
    {
        public override bool IsSatisfiedBy(Book book)
        {
            return book.IsCheckedOut;
        }
    }

}
