using System;

namespace _07._Math_Power
{
    public class Math_Power
    {
        public static void Main()
        {
            double number = double.Parse(Console.ReadLine());
            int power = int.Parse(Console.ReadLine());

            double poweredNumber = CalculatePower(number, power);
            Console.WriteLine(poweredNumber);
        }

        private static double CalculatePower(double number, int power)
        {
            double result = Math.Pow(number, power);

            return result;
        }
    }
}
