using System;
using System.Collections.Generic;

namespace Task1
{
    public class Task1
    {
        public static void Main()
        {
            int companions = int.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());

            int coins = days * 50;
            for (int day = 1; day <= days; day++)
            {
                // Every 10th
                if (day % 10 == 0)
                {
                    companions -= 2;
                }

                // every 15th (fifteenth) day 5 (five) new companions are joined at the beginning of the day
                if (day % 15 == 0)
                {
                    companions += 5;
                }

                // Every 3rd
                if (day % 3 == 0)
                {
                    int coinsForWater = 3;
                    for (int i = 0; i < companions; i++)
                    {
                        coins -= coinsForWater;
                    }
                }

                // Every 5th 
                if (day % 5 == 0)
                {
                    int earnedCoins = 20;
                    coins += earnedCoins * companions;
                    if (day % 3 == 0)
                    {
                        int coinsToSpend = 2;
                        for (int i = 0; i < companions; i++)
                        {
                            coins -= coinsToSpend;
                        }
                    }
                }

                int coinsForFood = 2;
                for (int i = 0; i < companions; i++)
                {
                    coins -= coinsForFood;
                }

            }

            // You have to calculate how much coins gets each companion at the end of the adventure
            int coinsPerPerson = coins / companions;
            Console.WriteLine($"{companions} companions received {coinsPerPerson} coins each.");
        }
    }
}
