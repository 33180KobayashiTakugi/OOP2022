using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise {
    class Program {
        static void Main(string[] args) {
            //2.1.3
            //List<Song> songs = new List<Song>();

            // var song1 = new Song("Let it be", "the Beatles",243);
            // songs.Add(song1);

            var songs = new Song[] {
                new Song("Let it be","The Beatles",243),
            };
            PrintSongs(songs);
        }
        //2.1.4
        private static void PrintSongs(Song[] songs) {
            foreach (var song in songs) {
                //var span = new TimeSpan(0, 0, song.Length);
                Console.WriteLine("{0} ,{1},{2:m\\:ss}",
                    song.Title, song.ArtistName, TimeSpan.FromSeconds(songs.Length));  
            }
        }
    }
}