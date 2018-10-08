using System;

namespace _03._Rounding_Numbers
{
    public class Rounding_Numbers
    {
        public static void Main()
        {
            string[] numbersAsStr = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);

            foreach (var numberAsStr in numbersAsStr)
            {
                double number = double.Parse(numberAsStr);
                double rounded = Math.Round(number, MidpointRounding.AwayFromZero);
                Console.WriteLine($"{number} => {rounded}");
            }

        }
    }
}
