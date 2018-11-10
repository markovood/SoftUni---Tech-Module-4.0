using System;

namespace Task2
{
    public class Task2
    {
        public static void Main()
        {
            int initialHealth = 100;
            int health = initialHealth;
            int coins = 0;
            string[] dungenousRooms = Console.ReadLine().Split('|', StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < dungenousRooms.Length; i++)
            {
                string[] roomTokens = dungenousRooms[i].Split(' ', StringSplitOptions.RemoveEmptyEntries);
                if (roomTokens[0].StartsWith("potion"))
                {
                    int healingAmount = int.Parse(roomTokens[1]);
                    health += healingAmount;
                    int diff = 0;
                    if (health > initialHealth)// nb >=
                    {
                        int currentHealth = health - healingAmount;
                        diff = initialHealth - currentHealth;
                        health = initialHealth;
                    }
                    else
                    {
                        diff = healingAmount;
                    }
                    
                    Console.WriteLine($"You healed for {diff} hp.");
                    Console.WriteLine($"Current health: {health} hp.");
                }
                else if (roomTokens[0].StartsWith("chest"))
                {
                    int foundCoins = int.Parse(roomTokens[1]);
                    coins += foundCoins;
                    Console.WriteLine($"You found {foundCoins} coins.");
                }
                else
                {
                    string monster = roomTokens[0];
                    int monsterAttack = int.Parse(roomTokens[1]);
                    health -= monsterAttack;
                    if (health > 0)
                    {
                        Console.WriteLine($"You slayed {monster}.");
                    }
                    else
                    {
                        int roomNum = i + 1;
                        Console.WriteLine($"You died! Killed by {monster}.");
                        Console.WriteLine($"Best room: {roomNum}");
                        return;
                    }
                }
            }

            // end
            Console.WriteLine("You've made it!");
            Console.WriteLine($"Coins: {coins}");
            Console.WriteLine($"Health: {health}");
        }
    }
}
