using System;

namespace _03._Substring
{
    public class Substring
    {
        public static void Main()
        {
            string word = Console.ReadLine().ToLower();
            string text = Console.ReadLine();
            while (text.Contains(word))
            {
                text = text.Replace(word, "");
            }

            Console.WriteLine(text);
        }
    }
}
