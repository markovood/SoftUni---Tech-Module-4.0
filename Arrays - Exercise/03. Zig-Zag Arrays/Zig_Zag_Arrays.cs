using System;

namespace _03._Zig_Zag_Arrays
{
    public class Zig_Zag_Arrays
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int[] firstIntArr = new int[n];
            int[] secondIntArr = new int[n];
            for (int i = 0; i < n; i++)
            {
                string[] intsAsStr = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

                if (i % 2 == 0)
                {
                    firstIntArr[i] = int.Parse(intsAsStr[0]);
                    secondIntArr[i] = int.Parse(intsAsStr[1]);
                }
                else
                {
                    secondIntArr[i] = int.Parse(intsAsStr[0]);
                    firstIntArr[i] = int.Parse(intsAsStr[1]);
                }
            }

            Console.WriteLine(string.Join(' ', firstIntArr));
            Console.WriteLine(string.Join(' ', secondIntArr));
        }
    }
}
