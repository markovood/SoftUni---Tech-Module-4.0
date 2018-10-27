using System;

namespace Baking_Rush
{
    public class Baking_Rush
    {
        public static void Main()
        {
            int coins = 100;
            int energy = 100;

            string[] workingDayEvents = Console.ReadLine()
                .Split('|', StringSplitOptions.RemoveEmptyEntries);

            foreach (var @event in workingDayEvents)
            {
                string[] eventTokens = @event.Split('-');
                switch (eventTokens[0])
                {
                    case "rest":
                        int energyToGain = int.Parse(eventTokens[1]);
                        if (energy == 100)
                        {
                            energyToGain = 0;
                        }
                        else if (energy < 100)
                        {
                            energy += energyToGain;
                            if (energy > 100)
                            {
                                int exceeded = energy - 100;
                                energy = 100;
                                energyToGain -= exceeded;
                            }
                        }

                        Console.WriteLine($"You gained {energyToGain} energy.");
                        Console.WriteLine($"Current energy: {energy}.");
                        break;
                    case "order":
                        int coinsToEarn = int.Parse(eventTokens[1]);
                        energy -= 30;
                        if (energy >= 0)
                        {
                            coins += coinsToEarn;
                            Console.WriteLine($"You earned {eventTokens[1]} coins.");
                        }
                        else
                        {
                            energy += 30; // restore original
                            energy += 50;
                            Console.WriteLine($"You had to rest!");
                        }
                        break;
                    default:
                        int price = int.Parse(eventTokens[1]);
                        coins -= price;
                        if (coins > 0)
                        {
                            Console.WriteLine($"You bought {eventTokens[0]}.");
                        }
                        else
                        {
                            Console.WriteLine($"Closed! Cannot afford {eventTokens[0]}.");
                            return;
                        }
                        break;
                }
            }

            Console.WriteLine("Day completed!");
            Console.WriteLine($"Coins: {coins}");
            Console.WriteLine($"Energy: {energy}");
        }
    }
}
