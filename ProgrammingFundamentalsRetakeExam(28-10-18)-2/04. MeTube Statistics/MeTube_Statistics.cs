using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._MeTube_Statistics
{
    public class MeTube_Statistics
    {
        public static Dictionary<string, int> videosAndViews = new Dictionary<string, int>();
        public static Dictionary<string, int> videosAndLikes = new Dictionary<string, int>();

        public static void Main()
        {
            while (true)
            {
                string line = Console.ReadLine();
                if (line == "stats time")
                {
                    break;
                }

                if (line.StartsWith("like") | line.StartsWith("dislike"))
                {
                    string[] lineTokens = line.Split(':', StringSplitOptions.RemoveEmptyEntries);
                    string command = lineTokens[0];
                    string videoName = lineTokens[1];
                    ProcessCommand(command, videoName);
                }
                else
                {
                    string[] lineTokens = line.Split('-', StringSplitOptions.RemoveEmptyEntries);
                    string videoName = lineTokens[0];
                    int views = int.Parse(lineTokens[1]);
                    AddViews(videoName, views);
                }
            }

            string criterion = Console.ReadLine();
            switch (criterion)
            {
                case "by views":
                    videosAndViews = videosAndViews
                        .OrderByDescending(vv => vv.Value)
                        .ToDictionary(x => x.Key, x => x.Value);

                    foreach (var videoAndViews in videosAndViews)
                    {
                        string video = videoAndViews.Key;
                        int views = videoAndViews.Value;
                        int likes = videosAndLikes[video];
                        Console.WriteLine($"{video} - {views} views - {likes} likes");
                    }

                    break;
                case "by likes":
                    videosAndLikes = videosAndLikes
                        .OrderByDescending(vv => vv.Value)
                        .ToDictionary(x => x.Key, x => x.Value);

                    foreach (var videoAndLikes in videosAndLikes)
                    {
                        string video = videoAndLikes.Key;
                        int likes = videoAndLikes.Value;
                        int views = videosAndViews[video];
                        Console.WriteLine($"{video} - {views} views - {likes} likes");
                    }

                    break;
            }
        }

        private static void AddViews(string videoName, int views)
        {
            if (videosAndViews.ContainsKey(videoName))
            {
                videosAndViews[videoName] += views;
            }
            else
            {
                videosAndViews.Add(videoName, views);
                videosAndLikes.Add(videoName, 0);
            }
        }

        private static void ProcessCommand(string command, string videoName)
        {
            switch (command)
            {
                case "like":
                    if (videosAndLikes.ContainsKey(videoName))
                    {
                        videosAndLikes[videoName]++;
                    }
                    else
                    {
                        videosAndLikes.Add(videoName, 1);
                    }

                    break;
                case "dislike":
                    if (videosAndLikes.ContainsKey(videoName))
                    {
                        videosAndLikes[videoName]--;
                    }

                    break;
            }
        }
    }
}
