using System;
using System.Linq;

namespace _08._Condense_Array_to_Number
{
    public class Condense_Array_to_Number
    {
        public static void Main()
        {
            int[] arr = Console.ReadLine().
                Split(' ', StringSplitOptions.RemoveEmptyEntries).
                Select(int.Parse).
                ToArray();

            while (arr.Length > 1)
            {
                int[] condensed = new int[arr.Length - 1];
                for (int i = 0; i < arr.Length - 1; i++)
                {
                    condensed[i] = arr[i] + arr[i + 1];
                }

                arr = condensed;
            }

            Console.WriteLine(arr[0]);
        }
    }
}
