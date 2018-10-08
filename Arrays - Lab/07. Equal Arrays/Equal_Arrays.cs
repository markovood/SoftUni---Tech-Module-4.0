using System;
using System.Linq;

namespace _07._Equal_Arrays
{
    public class Equal_Arrays
    {
        public static void Main()
        {
            int[] firstArr = Console.ReadLine().
                Split(' ', StringSplitOptions.RemoveEmptyEntries).
                Select(n => int.Parse(n)).
                ToArray();

            int[] secondArr = Console.ReadLine().
                Split(' ', StringSplitOptions.RemoveEmptyEntries).
                Select(n => int.Parse(n)).
                ToArray();

            int sum = 0;
            for (int i = 0; i < firstArr.Length; i++)
            {
                if (firstArr[i] != secondArr[i])
                {
                    Console.WriteLine($"Arrays are not identical. Found difference at {i} index");
                    return;
                }

                checked
                {
                    sum += firstArr[i];
                }
            }

            Console.WriteLine($"Arrays are identical. Sum: {sum}");
        }
    }
}
