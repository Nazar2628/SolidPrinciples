namespace SolidPrinciples.Models
{
    public class PremiumMember : LibraryMember
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
