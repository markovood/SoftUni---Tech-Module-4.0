using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _07._Append_Arrays
{
    public class Append_Arrays
    {
        public static void Main()
        {
            string[] arraysAsStrs = Console.ReadLine().Split('|', StringSplitOptions.RemoveEmptyEntries);

            List<int[]> arrays = new List<int[]>();

            foreach (var arrayAsStr in arraysAsStrs)
            {
                int[] currentArr = arrayAsStr
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                if (currentArr.Length == 0)
                {
                    continue;
                }

                arrays.Add(currentArr);
            }

            arrays.Reverse();

            StringBuilder output = new StringBuilder();
            foreach (var arr in arrays)
            {
                output.Append(string.Join(' ', arr) + " ");
            }

            Console.WriteLine(output);
        }
    }
}
