using System;

namespace _01._Integer_Operations
{
    public class Integer_Operations
    {
        public static void Main()
        {
            // int.MaxValue -> 2147483647
            int firstInt = int.Parse(Console.ReadLine());
            int secondInt = int.Parse(Console.ReadLine());
            int thirdInt = int.Parse(Console.ReadLine());
            int fourthInt = int.Parse(Console.ReadLine());

            checked
            {
                long addition = (long)firstInt + secondInt;
                long division = addition / thirdInt;
                long result = division * fourthInt;
                Console.WriteLine(result);
            }
        }
    }
}
