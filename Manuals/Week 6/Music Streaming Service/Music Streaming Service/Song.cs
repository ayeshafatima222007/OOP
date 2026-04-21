using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace Music_Streaming_Service
{
    internal class Song
    {
        private string SongName;
        private string Singer;

        public Song(string SongName, string Singer)
        {
            this.SongName = SongName;
            this.Singer = Singer;

        }

        public string getSongName()
        {
            return SongName;
        }

        public string getSinger()
        {
            return Singer;
        }

        public void setSongName(string SongName)
        {
            this.SongName = SongName;
        }

        public void setSinger(string Singer)
        {
            this.Singer = Singer;
        }

    }
}
