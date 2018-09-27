using System;
using System.Collections.Generic;
using System.Linq;

namespace _1._Sort_Numbers
{
    public class Sort_Numbers
    {
        public static void Main(string[] args)
        {
            double firstNumber = double.Parse(Console.ReadLine());
            double secondNumber = double.Parse(Console.ReadLine());
            double thirdNumber = double.Parse(Console.ReadLine());

            var numbers = new List<double>() { firstNumber, secondNumber, thirdNumber };
            // numbers.Sort();
            // numbers.Reverse();

            var orderedNumbers = numbers.OrderByDescending(x => x);

            foreach (var number in orderedNumbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}
