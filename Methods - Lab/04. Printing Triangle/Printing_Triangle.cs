using System;

namespace _04._Printing_Triangle
{
    public class Printing_Triangle
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            PrintTriangle(n);
        }

        private static void PrintTriangle(int n)
        {
            // top
            for (int i = 1; i < n; i++)
            {
                PrintLine(1, i);
            }

            // middle
            PrintLine(1, n);

            // bottom
            for (int i = n - 1; i >= 1; i--)
            {
                PrintLine(1, i);
            }
        }

        private static void PrintLine(int start, int end)
        {
            for (int i = start; i <= end; i++)
            {
                Console.Write(i + " ");
            }

            Console.WriteLine();
        }
    }
}
