using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01._Messaging
{
    public class Messaging
    {
        public static void Main()
        {
            List<int> numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            string text = Console.ReadLine();

            StringBuilder output = new StringBuilder();

            for (int i = 0; i < numbers.Count; i++)
            {
                int sum = Sum(numbers[i]);
                if (sum >= text.Length)
                {
                    int index = 0;
                    char symbol = ' ';
                    for (int j = 0; j <= sum; j++)
                    {
                        if (index >= sum -1)
                        {
                            index = 0;
                        }

                        symbol = text[index];
                        index++;
                    }

                    output.Append(symbol);
                    text = text.Remove(index - 1, 1);
                }
                else
                {
                    output.Append(text[sum]);
                    text = text.Remove(sum, 1);
                }
            }

            Console.WriteLine(output.ToString());
        }

        private static int Sum(int number)
        {
            int sum = 0;
            while (number > 0)
            {
                int lastDigit = number % 10;
                number /= 10;
                sum += lastDigit;
            }

            return sum;
        }
    }
}
