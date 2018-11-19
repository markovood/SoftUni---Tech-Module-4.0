using System;

namespace _02._Ascii_Sumator
{
    public class Ascii_Sumator
    {
        public static void Main()
        {
            char firstChar = char.Parse(Console.ReadLine());
            char secondChar = char.Parse(Console.ReadLine());
            string str = Console.ReadLine();

            // ensure correct order
            if (firstChar > secondChar)
            {
                char temp = firstChar;
                firstChar = secondChar;
                secondChar = temp;
            }

            int sum = 0;
            for (int i = 0; i < str.Length; i++)
            {
                char currentChar = str[i];
                if (currentChar > firstChar && currentChar < secondChar)
                {
                    sum += currentChar;
                }
            }

            Console.WriteLine(sum);
        }
    }
}
