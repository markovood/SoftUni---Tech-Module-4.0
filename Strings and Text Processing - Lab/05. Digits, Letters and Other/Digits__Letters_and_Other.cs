using System;
using System.Collections.Generic;

namespace _05._Digits__Letters_and_Other
{
    public class Digits__Letters_and_Other
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            List<char> digits = new List<char>();
            List<char> letters = new List<char>();
            List<char> everythingElse = new List<char>();

            foreach (var symbol in input)
            {
                if (char.IsDigit(symbol))
                {
                    digits.Add(symbol);
                }
                else if (char.IsLetter(symbol))
                {
                    letters.Add(symbol);
                }
                else
                {
                    everythingElse.Add(symbol);
                }
            }

            Console.WriteLine(string.Join("", digits));
            Console.WriteLine(string.Join("", letters));
            Console.WriteLine(string.Join("", everythingElse));
        }
    }
}
