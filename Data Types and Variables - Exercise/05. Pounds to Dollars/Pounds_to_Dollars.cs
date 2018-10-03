using System;

namespace _05._Pounds_to_Dollars
{
    public class Pounds_to_Dollars
    {
        public static void Main()
        {
            decimal poundRate = 1.31m;  // 1 British Pound = 1.31 Dollars
            decimal britishPounds = decimal.Parse(Console.ReadLine());

            decimal usDollars = britishPounds * poundRate;
            Console.WriteLine($"{usDollars:F3}");
        }
    }
}
