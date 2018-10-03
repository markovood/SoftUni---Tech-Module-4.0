using System;

namespace _07._Lower_or_Upper
{
    public class Lower_or_Upper
    {
        public static void Main()
        {
            char input = char.Parse(Console.ReadLine());
            
            Console.WriteLine(char.IsLower(input) ? "lower-case" : "upper-case");
        }
    }
}
