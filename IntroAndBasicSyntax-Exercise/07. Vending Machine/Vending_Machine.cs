using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Vending_Machine
{
    public class Vending_Machine
    {
        public static void Main()
        {
            decimal[] allowedCoins = { 0.1m, 0.2m, 0.5m, 1m, 2m };
            string[] stockedProducts = { "Nuts", "Water", "Crisps", "Soda", "Coke"};
            Dictionary<string, decimal> priceList = new Dictionary<string, decimal>()
                {
                    { "Nuts", 2.0m },
                    { "Water", 0.7m },
                    { "Crisps", 1.5m },
                    { "Soda", 0.8m },
                    { "Coke", 1m }
                };

            // getting different coins
            string coinAsStr = Console.ReadLine();
            decimal coin = decimal.Parse(coinAsStr);

            decimal totalAmountInserted = 0;
            while (coinAsStr != "Start")
            {
                if (allowedCoins.Contains(decimal.Parse(coinAsStr)))
                {
                    totalAmountInserted += decimal.Parse(coinAsStr);
                }
                else
                {
                    Console.WriteLine($"Cannot accept {coinAsStr}");
                }

                coinAsStr = Console.ReadLine();
            }

            // choosing products
            string product = Console.ReadLine();

            while (product != "End")
            {
                if (stockedProducts.Contains(product))
                {
                    if (totalAmountInserted >= priceList[product])
                    {
                        Console.WriteLine($"Purchased {product.ToLower()}");
                        totalAmountInserted -= priceList[product];
                    }
                    else
                    {
                        Console.WriteLine("Sorry, not enough money");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid product");
                }

                product = Console.ReadLine();
            }

            Console.WriteLine($"Change: {totalAmountInserted:F2}");
        }
    }
}
