using System;

namespace _06._Reversed_Chars
{
    public class Reversed_Chars
    {
        public static void Main()
        {
            char firstSymbol = char.Parse(Console.ReadLine());
            char secondSymbol = char.Parse(Console.ReadLine());
            char thirdSymbol = char.Parse(Console.ReadLine());

            char[] symbols = new char[] { firstSymbol, secondSymbol, thirdSymbol };
            Array.Reverse(symbols);
            Console.WriteLine(string.Join(' ', symbols));
        }
    }
}
