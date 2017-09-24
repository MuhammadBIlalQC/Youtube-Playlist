using Microsoft.AspNetCore.Mvc;
using Youtube_Playlist.Lib;

namespace Youtube_Playlist.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Playlist()
        {
            return View();
        }

        public IActionResult Library()
        {
            var libSession = new LibrarySession(HttpContext);
            var library = libSession.GetLibrary();
            return View(library);
        }

    }
}
