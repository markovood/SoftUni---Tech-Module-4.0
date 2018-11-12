using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace _04._Songs
{
    public class Songs
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            List<Song> songs = new List<Song>();
            for (int i = 0; i < n; i++)
            {
                string[] inputTokens = Console.ReadLine().Split('_', StringSplitOptions.RemoveEmptyEntries);
                string type = inputTokens[0];
                string name = inputTokens[1];
                string time = inputTokens[2];
                var song = new Song(type, name, time);

                songs.Add(song);
            }

            string typeList = Console.ReadLine();
            if (typeList == "all")
            {
                foreach (var song in songs)
                {
                    Console.WriteLine(song.Name);
                }
            }
            else
            {
                var filtered = songs.Where(s => s.TypeList == typeList);
                foreach (var song in filtered)
                {
                    Console.WriteLine(song.Name);
                }
            }
        }
    }
}
