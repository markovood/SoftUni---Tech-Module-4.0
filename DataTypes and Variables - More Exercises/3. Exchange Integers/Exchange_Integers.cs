using System;

namespace _3._Exchange_Integers
{
    public class Exchange_Integers
    {
        public static void Main()
        {
            int firstInt = int.Parse(Console.ReadLine());
            int secondInt = int.Parse(Console.ReadLine());

            Console.WriteLine("Before:");
            Console.WriteLine($"a = {firstInt}");
            Console.WriteLine($"b = {secondInt}");

            int temp = firstInt;
            firstInt = secondInt;
            secondInt = temp;
            Console.WriteLine();

            Console.WriteLine("After:");
            Console.WriteLine($"a = {firstInt}");
            Console.WriteLine($"b = {secondInt}");
        }
    }
}
