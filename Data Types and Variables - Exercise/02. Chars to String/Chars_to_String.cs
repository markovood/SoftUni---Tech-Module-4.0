using System;

namespace _02._Chars_to_String
{
    public class Chars_to_String
    {
        public static void Main()
        {
            char firstSymbol = char.Parse(Console.ReadLine());
            char secondSymbol = char.Parse(Console.ReadLine());
            char thirdSymbol = char.Parse(Console.ReadLine());

            Console.WriteLine(new string(new char[] { firstSymbol, secondSymbol, thirdSymbol }));
        }
    }
}
