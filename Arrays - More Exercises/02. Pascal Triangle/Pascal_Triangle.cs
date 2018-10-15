using System;
using System.Collections.Generic;

namespace _02._Pascal_Triangle
{
    public class Pascal_Triangle
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine(1);
            List<int> currentRow = new List<int>() { 0, 1, 0 };
            for (int i = 0; i < n - 1; i++)
            {
                currentRow = GetCurrentRow(currentRow);

                string currentRowAsStr = string.Join(' ', currentRow);
                currentRowAsStr = currentRowAsStr.Remove(0, 2);
                currentRowAsStr = currentRowAsStr.Remove(currentRowAsStr.Length - 1, 1);
                Console.WriteLine(currentRowAsStr);
            }
        }

        private static List<int> GetCurrentRow(List<int> row)
        {
            List<int> newElements = new List<int>();
            for (int j = 0; j < row.Count - 1; j++)
            {
                newElements.Add(row[j] + row[j + 1]);
            }

            newElements.Insert(0, 0);
            newElements.Add(0);
            return newElements;
        }
    }
}
