using System;
using System.Collections.Generic;

namespace _04._Tribonacci_Sequence
{
    public class Tribonacci_Sequence
    {
        public static void Main()
        {
            int num = int.Parse(Console.ReadLine());

            if (num == 1)
            {
                Console.WriteLine(1);
            }
            else if (num == 2)
            {
                Console.WriteLine("1 1");
            }
            else
            {
                var nTribonacciNumbers = GetNTribonacciNumber(num);
                Console.WriteLine(string.Join(' ', nTribonacciNumbers));
            }
        }

        private static List<int> GetNTribonacciNumber(int count)
        {
            List<int> tribonacciNumbers = new List<int>() { 1, 1, 2 };
            int nextNumbersCount = count - tribonacciNumbers.Count;
            for (int i = 0; i < nextNumbersCount; i++)
            {
                int nextTribonacci = tribonacciNumbers[tribonacciNumbers.Count - 1] +
                                    tribonacciNumbers[tribonacciNumbers.Count - 2] +
                                    tribonacciNumbers[tribonacciNumbers.Count - 3];
                tribonacciNumbers.Add(nextTribonacci);
            }

            return tribonacciNumbers;
        }
    }
}
