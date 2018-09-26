using System;

namespace _09._Sum_of_Odd_Numbers
{
    class Sum_of_Odd_Numbers
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sum = 0;
            int number = 1;
            for (int i = 0; i < n; i++)
            {
                if (number % 2 != 0)
                {
                    Console.WriteLine(number);
                    sum += number;
                    number += 2;
                }
            }

            Console.WriteLine($"Sum: {sum}");
        }
    }
}
