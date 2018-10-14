using System;
using System.Linq;

namespace _06._Equal_Sum
{
    public class Equal_Sum
    {
        public static void Main()
        {
            int[] someArray = Console.ReadLine().
                Split(' ', StringSplitOptions.RemoveEmptyEntries).
                Select(int.Parse).
                ToArray();


            for (int i = 0; i < someArray.Length; i++)
            {
                int middle = someArray[i];
                int leftSum = 0;
                int rightSum = 0;

                // sum everything to the left 
                for (int j = i - 1; j >= 0; j--)
                {
                    leftSum += someArray[j];
                }

                // sum everything to the right
                for (int k = i + 1; k < someArray.Length; k++)
                {
                    rightSum += someArray[k];
                }

                if (leftSum == rightSum)
                {
                    Console.WriteLine(i);
                    return;
                }
            }

            Console.WriteLine("no");
        }
    }
}
