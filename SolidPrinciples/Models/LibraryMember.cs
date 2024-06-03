namespace SolidPrinciples.Models
{
    public abstract class LibraryMember
    {
        public string Name { get; set; }
        public abstract void CheckOutBook(Book book);
    }

}
