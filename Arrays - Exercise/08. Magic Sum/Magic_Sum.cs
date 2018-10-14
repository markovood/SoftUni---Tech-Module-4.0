using System;
using System.Linq;

namespace _08._Magic_Sum
{
    public class Magic_Sum
    {
        public static void Main()
        {
            int[] someArray = Console.ReadLine().
                Split(' ', StringSplitOptions.RemoveEmptyEntries).
                Select(int.Parse).
                ToArray();

            int sum = int.Parse(Console.ReadLine());

            for (int i = 0; i < someArray.Length; i++)
            {
                int currentInt = someArray[i];
                for (int j = i + 1; j < someArray.Length; j++)
                {
                    int nextInt = someArray[j];
                    if (currentInt + nextInt == sum)
                    {
                        Console.WriteLine(currentInt + " " + nextInt);
                    }
                }
            }
        }
    }
}
