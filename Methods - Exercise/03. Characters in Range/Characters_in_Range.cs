using System;

namespace _03._Characters_in_Range
{
    public class Characters_in_Range
    {
        public static void Main()
        {
            char startRange = char.Parse(Console.ReadLine());
            char endRange = char.Parse(Console.ReadLine());

            PrintRangeExclusive(startRange, endRange);
        }

        private static void PrintRangeExclusive(char startRange, char endRange)
        {
            if (startRange > endRange)
            {
                // swapping
                char temp = startRange;
                startRange = endRange;
                endRange = temp;
            }

            for (int i = startRange + 1; i < endRange; i++)
            {
                Console.Write((char)i + " ");
            }
        }
    }
}
