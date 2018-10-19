using System;
using System.Linq;

namespace _02._Vowels_Count
{
    public class Vowels_Count
    {
        public static void Main()
        {
            string someString = Console.ReadLine();

            int vowelsCount = CountVowels(someString);
            Console.WriteLine(vowelsCount);
        }

        private static int CountVowels(string someString)
        {
            char[] vowels = { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
            int count = 0;

            foreach (var symbol in someString)
            {
                if (vowels.Contains(symbol))
                {
                    count++;
                }
            }

            return count;
        }
    }
}
