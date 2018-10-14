using System;
using System.Linq;

namespace _05._Top_Integers
{
    public class Top_Integers
    {
        public static void Main()
        {
            int[] someArray = Console.ReadLine().
                Split(' ', StringSplitOptions.RemoveEmptyEntries).
                Select(int.Parse).
                ToArray();

            for (int i = 0; i < someArray.Length; i++)
            {
                int currentInt = someArray[i];
                bool isTopInt = true;
                for (int j = i + 1; j < someArray.Length; j++)
                {
                    if (currentInt <= someArray[j]) // doesn't say what happens if currentInt is '==' to any other int to the end 
                    {
                        isTopInt = false;
                        break;
                    }
                }

                if (isTopInt)
                {
                    Console.Write(currentInt + " ");
                }
            }
        }
    }
}
