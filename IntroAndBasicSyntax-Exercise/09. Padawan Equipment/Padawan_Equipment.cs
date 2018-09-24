using System;

namespace _09._Padawan_Equipment
{
    public class Padawan_Equipment
    {
        public static void Main()
        {
            decimal budget = decimal.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            decimal priceForASabre = decimal.Parse(Console.ReadLine());
            decimal priceForARobe = decimal.Parse(Console.ReadLine());
            decimal priceForABelt = decimal.Parse(Console.ReadLine());

            // lightsabres sometimes brake, Ivan Cho should buy 10% more, rounded up to the next integer. Also,
            // every sixth belt is free.

            decimal totalPriceSabres = Math.Ceiling(students * 1.1m) * priceForASabre;
            decimal totalPriceBelts = 0;
            decimal totalPriceRobes = students * priceForARobe;
            if (students >= 6)
            {
                decimal freeBelts = Math.Floor(students / 6.0m);
                totalPriceBelts = (students - freeBelts) * priceForABelt;
            }
            else
            {
                totalPriceBelts = students * priceForABelt;
            }

            decimal totalMoneyNeeded = totalPriceSabres + totalPriceRobes + totalPriceBelts;
            if (budget >= totalMoneyNeeded)
            {
                Console.WriteLine($"The money is enough - it would cost {totalMoneyNeeded:F2}lv.");
            }
            else
            {
                decimal neededMoney = totalMoneyNeeded - budget;
                Console.WriteLine($"Ivan Cho will need {neededMoney:F2}lv more.");
            }
        }
    }
}
