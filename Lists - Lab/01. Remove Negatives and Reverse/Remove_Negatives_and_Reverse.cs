using System;
using System.Linq;

namespace _01._Remove_Negatives_and_Reverse
{
    public class Remove_Negatives_and_Reverse
    {
        public static void Main()
        {
            var numbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            numbers.RemoveAll(n => n < 0);
            if (numbers.Count > 0)
            {
                numbers.Reverse();
                Console.WriteLine(string.Join(' ', numbers));
            }
            else
            {
                Console.WriteLine("empty");
            }
        }
    }
}
