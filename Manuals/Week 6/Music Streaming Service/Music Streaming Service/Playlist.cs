using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music_Streaming_Service
{
    internal class Playlist
    {
        private string PlaylistName;
        private List<Song> songlist;

        public Playlist(string PlaylistName)
        { 
            this.PlaylistName = PlaylistName;
            this.songlist = new List<Song>();
        }

        public string getPlaylistName()
        {
            return PlaylistName;
        }

        public void setPlaylistName(string PlaylistName)
        { 
            this.PlaylistName = PlaylistName;
        }

        public void AddSongs(Song song)
        {
            songlist.Add(song);
        }

        public void ViewSong()
        {
            Console.WriteLine($"Playlist: {PlaylistName}");
            foreach (Song s in songlist)
            {
                Console.WriteLine($"Song: {s.getSongName()} | Artist: {s.getSinger()}");
            }
        }
    }
}
