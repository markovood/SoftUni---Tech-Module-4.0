using System;
using System.Text;

namespace _01._Reverse_Strings
{
    public class Reverse_Strings
    {
        public static void Main()
        {
            while (true)
            {
                string str = Console.ReadLine();
                if (str == "end")
                {
                    break;
                }

                string reversedStr = Reverse(str);
                Console.WriteLine($"{str} = {reversedStr}");
            }
        }

        private static string Reverse(string str)
        {
            StringBuilder reversed = new StringBuilder();
            for (int i = str.Length - 1; i >= 0; i--)
            {
                reversed.Append(str[i]);
            }

            return reversed.ToString();
        }
    }
}
