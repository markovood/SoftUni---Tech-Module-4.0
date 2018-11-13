using System;
using System.Text;

namespace _02._Repeat_Strings
{
    public class Repeat_Strings
    {
        public static void Main()
        {
            string[] strs = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            StringBuilder result = new StringBuilder();
            foreach (var str in strs)
            {
                int n = str.Length;
                for (int i = 0; i < n; i++)
                {
                    result.Append(str);
                }
            }

            Console.WriteLine(result);
        }
    }
}
