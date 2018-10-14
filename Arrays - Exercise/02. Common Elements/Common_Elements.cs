using System;
using System.Linq;

namespace _02._Common_Elements
{
    public class Common_Elements
    {
        public static void Main()
        {
            string[] firstArray = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            string[] secondArray = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            foreach (var item in secondArray)
            {
                if (firstArray.Contains(item))
                {
                    Console.Write(item + " ");
                }
            }
        }
    }
}
