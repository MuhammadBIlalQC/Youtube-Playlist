using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using Youtube_Playlist.Models;

namespace Youtube_Playlist.Lib
{

    public class LibrarySession
    {
        private HttpContext Context;
        private const string KEY = "Library";
        public LibrarySession(HttpContext context)
        {
            Context = context;

            if (!this.LibraryExists())
                this.SetSessionLibrary(new Library());
        }


        public Library GetLibrary()
        {
            if (this.LibraryExists())
                return JsonConvert.DeserializeObject<Library>(Context.Session.GetString(KEY));
            else
                return null;
        }
        public bool LibraryExists()
        {
            if (Context.Session.GetString(KEY) != null)
                return true;
            else
                return false;
        }

        public void SetSessionLibrary( Library library)
        {
            Context.Session.SetString(KEY, JsonConvert.SerializeObject(library));
        }
    }
}
