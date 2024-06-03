using Microsoft.AspNetCore.Mvc;
using SolidPrinciples.Filters;
using SolidPrinciples.Models;
using SolidPrinciples.Repositories;
using SolidPrinciples.Services;

namespace SolidPrinciples.Controllers
{
    public class LibraryController : Controller
    {
        private readonly LibraryService _libraryService;

        public LibraryController()
        {
            _libraryService = new LibraryService(new BookRepository());
        }

        public ActionResult Index()
        {
            var books = _libraryService.GetBooksByFilter(new AuthorBookFilter("F. Scott Fitzgerald"));
            return View(books);
        }

        public ActionResult AddBook()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddBook(Book book)
        {
            _libraryService.AddBook(book);
            return RedirectToAction("Index");
        }

        public ActionResult CheckOut(int id)
        {
            var book = _libraryService.GetBooksByFilter(new CheckedOutBookFilter()).FirstOrDefault(b => b.Id == id);
            if (book != null)
            {
                var member = new RegularMember { Name = "John Doe" };
                member.CheckOutBook(book);
            }

            return RedirectToAction("Index");
        }
    }

}
