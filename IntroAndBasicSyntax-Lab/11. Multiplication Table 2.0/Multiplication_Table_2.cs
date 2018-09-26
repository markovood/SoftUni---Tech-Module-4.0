using System;

namespace _11._Multiplication_Table_2._0
{
    class Multiplication_Table_2
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int multiplier = int.Parse(Console.ReadLine());

            if (multiplier <= 10)
            {
                for (int i = multiplier; i <= 10; i++)
                {
                    Console.WriteLine($"{number} X {i} = {number * i}");
                }
            }
            else
            {
                Console.WriteLine($"{number} X {multiplier} = {number * multiplier}");
            }
        }
    }
}
