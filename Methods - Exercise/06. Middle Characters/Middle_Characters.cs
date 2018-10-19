using System;

namespace _06._Middle_Characters
{
    public class Middle_Characters
    {
        public static void Main()
        {
            string someStr = Console.ReadLine();
            PrintMiddleSymbols(someStr);
        }

        private static void PrintMiddleSymbols(string someStr)
        {
            int middleIndex = someStr.Length / 2;

            if (someStr.Length % 2 != 0)
            {
                Console.WriteLine($"{someStr[middleIndex]}");
            }
            else
            {
                // If the length of the string is even there are two middle characters
                Console.WriteLine($"{someStr[middleIndex - 1]}{someStr[middleIndex]}");
            }
        }
    }
}
