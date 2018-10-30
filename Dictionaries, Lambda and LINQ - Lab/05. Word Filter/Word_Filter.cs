using System;
using System.Linq;

namespace _05._Word_Filter
{
    public class Word_Filter
    {
        public static void Main()
        {
            string[] words = Console.ReadLine().Split(' ');

            var wordsEvenLength = words.Where(w => w.Length % 2 == 0);
            foreach (var word in wordsEvenLength)
            {
                Console.WriteLine(word);
            }
        }
    }
}
