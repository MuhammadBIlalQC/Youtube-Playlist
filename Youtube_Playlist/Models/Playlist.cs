using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Youtube_Playlist.Models
{
    public class Playlist
    {
        public string Id { get; private set; }
        public string Name { get; set; }
        public List<Video> Videos = new List<Video>();
    }
}
