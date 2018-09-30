using System;

namespace _06._Special_Numbers
{
    public class Special_Numbers
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                int number = i;
                int sum = 0;
                while (number > 0)
                {
                    sum += number % 10;
                    number /= 10;
                }

                bool isSpecial = (sum == 5) || (sum == 7) || (sum == 11);

                Console.WriteLine($"{i} -> {isSpecial}");
                isSpecial = false;
            }
        }
    }
}
