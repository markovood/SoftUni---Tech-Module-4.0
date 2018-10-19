using System;

namespace _07._NxN_Matrix
{
    public class NxN_Matrix
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            PrintSquareMatrix(n);
        }

        private static void PrintSquareMatrix(int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(n + " ");
                }

                Console.WriteLine();
            }
        }
    }
}
