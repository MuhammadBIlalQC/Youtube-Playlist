using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Youtube_Playlist.Models
{
    public class Library
    {
        public List<Video> AllMusic { get; set; }
        public List<Playlist> Playlists { get; set; }

        public Library()
        {
            var x = 3;

            AllMusic = new List<Video>()
            {
                new Video { Name="Spider Pig", videoID = "BARjPuUN36Y" },
                new Video { Name="Ambitizious", videoID = "NWdndgVf8qw" },
                new Video { Name="Spider Pig", videoID = "BARjPuUN36Y" },
                new Video { Name="Ambitizious", videoID = "NWdndgVf8qw" },
                new Video { Name="Spider Pig", videoID = "BARjPuUN36Y" },
                new Video { Name="Ambitizious", videoID = "NWdndgVf8qw" }
            };

            Playlists = new List<Playlist>()
            {
                new Playlist {Name = "Example1", Videos = new List<Video>() },
                new Playlist {Name = "Example2", Videos = new List<Video>() },
                new Playlist {Name = "Example3", Videos = new List<Video>() },
            };
            //Playlists = new Dictionary<string, Playlist>();

        }

    }
}
