using System;

namespace Baking_Masterclass
{
    public class Baking_Masterclass
    {
        public static void Main()
        {
            decimal budget = decimal.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            decimal priceFlour = decimal.Parse(Console.ReadLine());
            decimal priceEgg = decimal.Parse(Console.ReadLine());
            decimal priceApron = decimal.Parse(Console.ReadLine());

            int freePackages = students / 5;
            decimal totalPriceFlour = (students - freePackages) * priceFlour;
            decimal totalPriceEggs = students * 10 * priceEgg;
            decimal totalPriceApron = (Math.Ceiling(students * 1.2m)) * priceApron;

            decimal totalPriceItems = totalPriceFlour + totalPriceEggs + totalPriceApron;
            if (budget >= totalPriceItems)
            {
                Console.WriteLine($"Items purchased for {totalPriceItems:F2}$.");
            }
            else
            {
                decimal neededMoney = totalPriceItems - budget;
                Console.WriteLine($"{neededMoney:F2}$ more needed.");
            }
        }
    }
}
