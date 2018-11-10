using System;

namespace _01._Advertisement_Message
{
    public class Advertisement_Message
    {
        private static Random rnd = new Random();

        private static string[] phrases = new string[]
        {
            "Excellent product.",
            "Such a great product.",
            "I always use that product.",
            "Best product of its category.",
            "Exceptional product.",
            "I can’t live without this product."
        };

        private static string[] events = new string[]
        {
            "Now I feel good.",
            "I have succeeded with this product.",
            "Makes miracles. I am happy of the results!",
            "I cannot believe but now I feel awesome.",
            "Try it yourself, I am very satisfied.",
            "I feel great!"
        };

        private static string[] authors = new string[]
        {
            "Diana",
            "Petya",
            "Stella",
            "Elena",
            "Katya",
            "Iva",
            "Annie",
            "Eva"
        };

        private static string[] cities = new string[]
        {
            "Burgas",
            "Sofia",
            "Plovdiv",
            "Varna",
            "Ruse"
        };

        public static void Main()
        {
            int numbOfMsgs = int.Parse(Console.ReadLine());
            string[] msgs = GenerateMsgs(numbOfMsgs);
            Console.WriteLine(string.Join(Environment.NewLine, msgs));
        }

        private static string[] GenerateMsgs(int numbOfMsgs)
        {
            string[] msgs = new string[numbOfMsgs];
            for (int i = 0; i < numbOfMsgs; i++)
            {
                // {phrase} {event} {author} - {city}
                string phrase = phrases[rnd.Next(msgs.Length)];
                string @event = events[rnd.Next(msgs.Length)];
                string author = authors[rnd.Next(msgs.Length)];
                string city = cities[rnd.Next(msgs.Length)];
                msgs[i] = $"{phrase} {@event} {author} - {city}";
            }

            return msgs;
        }
    }
}
