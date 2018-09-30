using System;

namespace _10._Refactor_Special_Numbers
{
    public class Refactor_Special_Numbers
    {
        public static void Main()
        {
            int range = int.Parse(Console.ReadLine());
            for (int currentNumber = 1; currentNumber <= range; currentNumber++)
            {
                int sum = 0;
                int number = currentNumber;
                while (number > 0)
                {
                    sum += number % 10;
                    number = number / 10;
                }

                bool isSpecial = (sum == 5) || (sum == 7) || (sum == 11);
                Console.WriteLine($"{currentNumber} -> {isSpecial}");

                sum = 0;
            }
        }
    }
}
