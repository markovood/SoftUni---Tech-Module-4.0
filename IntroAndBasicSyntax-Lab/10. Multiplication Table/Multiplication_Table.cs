using System;

namespace _10._Multiplication_Table
{
    internal class Multiplication_Table
    {
        private static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{number} X {i} = {number * i}");
            }
        }
    }
}
