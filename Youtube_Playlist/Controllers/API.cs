using System;
using Microsoft.AspNetCore.Mvc;
using Youtube_Playlist.Models;
using Youtube_Playlist.Lib;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Youtube_Playlist.Controllers
{
    public class API : Controller
    {
        [HttpGet]
        public IActionResult jQueryGet()
        {
            return Json(new { example = "it works" });
        }
        [HttpGet] //Change to Post
        public IActionResult addToLib(string videoId, string videoName)
        {
            if (videoId == null || videoName == null)
                return Json(new { example = "bad" });
            try
            {
                LibrarySession libSession = new LibrarySession(HttpContext);
                Library library = libSession.GetLibrary();
                library.AllMusic.Add(new Video { Name = videoName, videoID = videoId });
                libSession.SetSessionLibrary(library);
            }
            catch(Exception e)
            {
                //return BadRequest();
                return Json(new { example = "internal" });
            }

            //return Ok();
            return Json(new { example = "it works" });
        }
    }
}
