
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;

namespace _3._Songs
{
    class Song
    {
        public string TypeList { get; set; }
        public string Name { get; set; }
        public string Time { get; set; }
    }


    class Program
    {

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Song> songs = new List<Song>();
            for (int i = 0; i < n; i++)
            {
                List<string> data = Console.ReadLine().Split("_", StringSplitOptions.RemoveEmptyEntries).ToList();
                string type = data[0];
                string name = data[1];
                string time = data[2];

                Song song = new Song();

                song.TypeList = type;
                song.Name = name;
                song.Time = time;

                songs.Add(song);
            }
            string command = Console.ReadLine();
            if (command == "all")
            {
                foreach (Song allSongs in songs)
                {
                    Console.WriteLine(allSongs.Name);
                }
            }
            else
            {
                List<Song> filteredSongs = songs.Where(n => n.TypeList == command).ToList();


                foreach (Song song in filteredSongs)
                {
                    Console.WriteLine(song.Name);
                }
            }







            //int n = int.Parse(Console.ReadLine());
            //List<string> favouriteList = new List<string>();
            //List<string> listenLaterList = new List<string>();
            //List<string> likeList = new List<string>();
            //List<string> banList = new List<string>();
            //List<string> allList = new List<string>();
            //for (int i = 0; i < n; i++)
            //{
            //    List<string> songs= Console.ReadLine().Split("_", StringSplitOptions.RemoveEmptyEntries).ToList();
            //    if (songs[0] == "favourite")
            //    {
            //        favouriteList.Add(songs[1]);
            //        allList.Add(songs[1]);
            //    }
            //    else if (songs[0] == "listenLater")
            //    {
            //        listenLaterList.Add(songs[1]);
            //        allList.Add(songs[1]);
            //    }
            //    else if (songs[0] == "like")
            //    {
            //        likeList.Add(songs[1]);
            //        allList.Add(songs[1]);
            //    }
            //    else if (songs[0] == "ban")
            //    {
            //        banList.Add(songs[1]);
            //        allList.Add(songs[1]);
            //    }
            //
            //}
            //string command = Console.ReadLine();
            //switch (command)
            //{
            //    case "favourite":
            //        Console.WriteLine(string.Join(Environment.NewLine,favouriteList));
            //        break;
            //    case "listenLater":
            //        Console.WriteLine(string.Join(Environment.NewLine,listenLaterList));
            //        break;
            //    case "like":
            //        Console.WriteLine(string.Join(Environment.NewLine,likeList));
            //        break;
            //    case "ban":
            //        Console.WriteLine(string.Join(Environment.NewLine,banList));
            //        break;
            //    case "all":
            //        Console.WriteLine(string.Join(Environment.NewLine, allList));
            //        break;
            //
            //    default:
            //        break;
            //}

        }
    }
}
