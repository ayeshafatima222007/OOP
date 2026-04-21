using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Music_Streaming_Service
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***************************************");
            Console.WriteLine("*      PLAYLIST MANAGEMENT SYSTEM     *");
            Console.WriteLine("***************************************");

            Console.Write("Enter a name for your Playlist: ");
            string PlaylistName = Console.ReadLine();
            Playlist playlist = new Playlist(PlaylistName);

            bool addingSongs = true;

             
            while (addingSongs)
            {
                Console.WriteLine("--- Add a New Song ---");

                Console.Write("Enter Song Name: ");
                string SongName = Console.ReadLine();

                Console.Write("Enter Singer Name: ");
                string Singer = Console.ReadLine();

           
                Song NewSong = new Song(SongName, Singer);
                playlist.AddSongs(NewSong);

                Console.WriteLine("Song added successfully!");

                // Ask to continue
                Console.Write("Do you want to add another song? (yes/no): ");
                string choice = Console.ReadLine().ToLower();

                if (choice != "yes")
                {
                    addingSongs = false;
                }

                Console.Write("");
            }

             
            playlist.ViewSong();

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
