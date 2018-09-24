using System;

namespace _04._Print_and_sum
{
    public class Print_and_sum
    {
        public static void Main()
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int i = start; i <= end; i++)
            {
                checked
                {
                    Console.Write(i + " ");
                    sum += i;
                }
            }

            Console.WriteLine($"{Environment.NewLine}Sum: {sum}");
        }
    }
}
