using System;
using System.Collections.Generic;

namespace _3._Gaming_Store
{
    public class Gaming_Store
    {
        public static void Main()
        {
            var priceList = new Dictionary<string, decimal>()
            {
                {"OutFall 4", 39.99m},
                {"CS: OG", 15.99m},
                {"Zplinter Zell", 19.99m},
                {"Honored 2", 59.99m},
                {"RoverWatch", 29.99m},
                {"RoverWatch Origins Edition", 39.99m}
            };

            decimal initialBalance = decimal.Parse(Console.ReadLine());
            if (initialBalance == 0m)
            {
                Console.WriteLine("Out of money!");
                return;
            }
            else
            {
                decimal curentBalance = initialBalance;

                string gameToBuy = Console.ReadLine();
                while (gameToBuy != "Game Time")
                {
                    if (!priceList.ContainsKey(gameToBuy))
                    {
                        Console.WriteLine("Not Found");
                    }
                    else
                    {
                        if (curentBalance < priceList[gameToBuy])
                        {
                            Console.WriteLine("Too Expensive");
                        }
                        else
                        {
                            curentBalance -= priceList[gameToBuy];
                            Console.WriteLine($"Bought {gameToBuy}");

                            if (curentBalance == 0m)
                            {
                                Console.WriteLine("Out of money!");
                                return;
                            }
                        }
                    }

                    gameToBuy = Console.ReadLine();
                }

                Console.WriteLine($"Total spent: ${(initialBalance - curentBalance):F2}. Remaining: ${curentBalance:F2}");
            }
        }
    }
}
