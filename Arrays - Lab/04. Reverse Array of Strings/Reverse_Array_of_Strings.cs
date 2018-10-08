using System;

namespace _04._Reverse_Array_of_Strings
{
    public class Reverse_Array_of_Strings
    {
        public static void Main()
        {
            string[] someStr = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            Array.Reverse(someStr);
            Console.WriteLine(string.Join(' ', someStr));
        }
    }
}
