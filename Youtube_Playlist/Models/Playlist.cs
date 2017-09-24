using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Youtube_Playlist.Models
{
    public class Playlist
    {
        public string id { get; private set; }
        public string name { get; set; }
        public List<Video> videos = new List<Video>();
    }
}
