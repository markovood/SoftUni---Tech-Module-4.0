using System;

namespace _04._Text_Filter
{
    public class Text_Filter
    {
        public static void Main()
        {
            string[] bannedWords = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
            string text = Console.ReadLine();

            foreach (var bannedWord in bannedWords)
            {
                if (text.Contains(bannedWord))
                {
                    text = text.Replace(bannedWord, new string('*', bannedWord.Length));
                }
            }

            Console.WriteLine(text);
        }
    }
}
