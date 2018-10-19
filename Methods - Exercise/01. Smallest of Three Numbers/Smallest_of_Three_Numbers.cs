using System;

namespace _01._Smallest_of_Three_Numbers
{
    public class Smallest_of_Three_Numbers
    {
        public static void Main()
        {
            int firstInt = int.Parse(Console.ReadLine());
            int secondInt = int.Parse(Console.ReadLine());
            int thirdInt = int.Parse(Console.ReadLine());

            int smallest = GetSmallest(firstInt, secondInt, thirdInt);
            Console.WriteLine(smallest);
        }

        private static int GetSmallest(params int[] numbers)
        {
            int smallest = int.MaxValue;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < smallest)
                {
                    smallest = numbers[i];
                }
            }

            return smallest;
        }
    }
}
