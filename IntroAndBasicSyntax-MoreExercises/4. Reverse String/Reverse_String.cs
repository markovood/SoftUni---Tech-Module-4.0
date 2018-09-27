using System;
using System.Linq;

namespace _4._Reverse_String
{
    public class Reverse_String
    {
        public static void Main()
        {
            char[] someString = Console.ReadLine().ToCharArray();
            Array.Reverse(someString);
            Console.WriteLine(someString);
        }
    }
}
