using System;

namespace _4._Floating_Equality
{
    public class Floating_Equality
    {
        public static void Main()
        {
            double firstNumber = double.Parse(Console.ReadLine());
            double secondNumber = double.Parse(Console.ReadLine());

            double precision = 0.000001; // eps = 0.000001
            double difference = firstNumber - secondNumber;

            Console.WriteLine(Math.Abs(difference) < precision);
        }
    }
}
