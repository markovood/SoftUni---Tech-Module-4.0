using System;
using System.Text;

namespace _09._Palindrome_Integers
{
    public class Palindrome_Integers
    {
        public static void Main()
        {
            string numberAsStr = Console.ReadLine();

            while (numberAsStr != "END")
            {
                string reversed = Reverse(numberAsStr);
                if (numberAsStr == reversed)
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine("false");
                }

                numberAsStr = Console.ReadLine();
            }
        }

        private static string Reverse(string someStr)
        {
            StringBuilder reversed = new StringBuilder();
            for (int i = someStr.Length - 1; i >= 0; i--)
            {
                reversed.Append(someStr[i]);
            }

            return reversed.ToString();
        }
    }
}
