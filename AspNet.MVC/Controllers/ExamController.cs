using AspNet.MVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace AspNet.MVC.Controllers
{
    public class ExamController : Controller
    {
        public IActionResult Index()
        {
            var author1 = new Author { Id = 1, Name = "Frank", Surname = "Herbert", DOB = 1920 };
            var author2 = new Author { Id = 2, Name = "Howard Phillips", Surname = "Lovecraft", DOB = 1890 };
            var author3 = new Author { Id = 3, Name = "Stephen", Surname = "King", DOB = 1947 };
            var author4 = new Author { Id = 4, Name = "Joseph Edward", Surname = "Abercrombie", DOB = 1974 };

            var book1 = new Book { Id = 1, Title = "Dune", Author = author1, Genre = "Epic science fiction", ReleaseDate = 1965 };
            var book2 = new Book { Id = 2, Title = "The Call of Cthulhu", Author = author2, Genre = "Horror", ReleaseDate = 1928 };
            var book3 = new Book { Id = 3, Title = "The Gunslinger", Author = author3, Genre = "Dark fantasy, western", ReleaseDate = 1982 };
            var book4 = new Book { Id = 4, Title = "The Blade Itself", Author = author4, Genre = "Fantasy", ReleaseDate = 2006 };
            var book5 = new Book { Id = 5, Title = "The Shadow over Innsmouth", Author = author2, Genre = "Horror", ReleaseDate = 1936 };

            var books = new List<Book> { book1, book2, book3, book4, book5 };

            return View(books);
        }
    }
}
