using System;

namespace _02._Randomize_Words
{
    public class Randomize_Words
    {
        public static void Main()
        {
            string[] words = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            Random rnd = new Random();
            for (int i = 0; i < words.Length; i++)
            {
                int rndIndex = rnd.Next(0, words.Length);
                string temp = words[i];
                words[i] = words[rndIndex];
                words[rndIndex] = temp;
            }

            Console.WriteLine(string.Join(Environment.NewLine, words));
        }
    }
}
