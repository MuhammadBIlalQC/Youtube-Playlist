using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Youtube_Playlist.Models
{
    public class Library
    {
        public List<Video> AllMusic { get; set; }
        //public Dictionary<string, Playlist> Playlists { get; set; }

        public Library()
        {
            AllMusic = new List<Video>()
            {
                new Video { Name="Spider Pig", videoID = "BARjPuUN36Y" },
                new Video { Name="Ambitizious", videoID = "NWdndgVf8qw" },
                new Video { Name="Spider Pig", videoID = "BARjPuUN36Y" },
                new Video { Name="Ambitizious", videoID = "NWdndgVf8qw" },
                new Video { Name="Spider Pig", videoID = "BARjPuUN36Y" },
                new Video { Name="Ambitizious", videoID = "NWdndgVf8qw" }
            };

            //Playlists = new Dictionary<string, Playlist>();

        }

    }
}
