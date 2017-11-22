using System;
using System.Collections.Generic;
using System.Linq;

namespace _02.SoftuniKaraoke
{
    class Singer
    {
        public string Names { get; set; }
        public List<string> Songs { get; set; }
        public List<string> Awards { get; set; }
        public Singer(string name)
        {
            this.Names = name;
            this.Songs = new List<string>();
            this.Awards = new List<string>();
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            List<string> nameOfSingers = Console.ReadLine()
                .Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            List<string> nameOfSongs = Console.ReadLine()
                .Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();
            List<Singer> singer = new List<Singer>();
            string songSinging = Console.ReadLine();

            while (songSinging != "dawn")
            {
                string[] songList = songSinging.Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries);

                string nameOutput = songList[0];
                string song = songList[1];
                string awards = songList[2];

                if (nameOfSingers.Any(a => a == nameOutput) && songList.Any(a => a == song))
                {
                    if (!singer.Any(a => a.Names == nameOutput))
                    {
                        var newSinger = new Singer(nameOutput);
                        singer.Add(newSinger);
                    }
                    var currentSinger = singer.First(e => e.Names == nameOutput);
                    if (!currentSinger.Awards.Any(a=> a == awards))
                    {
                        currentSinger.Songs.Add(song);
                        currentSinger.Awards.Add(awards);
                    }
                }




                songSinging = Console.ReadLine();
            }
            foreach (var singers in singer.OrderByDescending(e => e.Awards.Count).ThenBy(e => e.Names))
            {
                Console.WriteLine($"{singers.Names}: { singers} awards");

                if (!singers.Awards.Any())
                {
                    Console.WriteLine("No awards");
                    continue;
                }

                foreach (var award in singers.Awards.OrderBy(e => e))
                {
                    Console.WriteLine($"--{award}");
                }
            }
        }
    }
  
}
