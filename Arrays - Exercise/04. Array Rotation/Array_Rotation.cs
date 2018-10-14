using System;
using System.Linq;

namespace _04._Array_Rotation
{
    public class Array_Rotation
    {
        public static void Main()
        {
            int[] someArr = Console.ReadLine().
                Split(' ', StringSplitOptions.RemoveEmptyEntries).
                Select(int.Parse).
                ToArray();

            int rotations = int.Parse(Console.ReadLine());

            for (int i = 0; i < rotations; i++)
            {
                int lastElement = someArr[0];
                for (int j = 1; j < someArr.Length; j++)
                {
                    someArr[j - 1] = someArr[j];
                }

                someArr[someArr.Length - 1] = lastElement;
            }

            Console.WriteLine(string.Join(' ', someArr));
        }
    }
}
