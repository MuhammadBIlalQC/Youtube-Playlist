using Microsoft.AspNetCore.Mvc;
using Youtube_Playlist.Lib;
using Youtube_Playlist.Models;

namespace Youtube_Playlist.ViewComponents
{
    public class SidebarViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            LibrarySession libSession = new LibrarySession(HttpContext);
            Library library = libSession.GetLibrary();
            return View(library);
        }
    }
}
