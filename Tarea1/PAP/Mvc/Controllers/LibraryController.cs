using System.Web.Mvc;

namespace Mvc.Controllers
{
    public class LibraryController : Controller
    {
        private readonly PAP.Buisness.BookManager _bookManager;

        public LibraryController()
        {
            _bookManager = new PAP.Buisness.BookManager();
        }
        public ActionResult Index()
        {
            var books = _bookManager.GetAllBooksFromDataModel();
            return View(books);
        }

         
    }
}