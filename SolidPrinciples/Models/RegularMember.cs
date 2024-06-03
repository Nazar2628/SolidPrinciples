namespace SolidPrinciples.Models
{
    public class RegularMember : LibraryMember
    {
        public override void CheckOutBook(Book book)
        {
            if (!book.IsCheckedOut)
            {
                book.IsCheckedOut = true;
            }
        }
    }

}
