using System;

namespace EinsteinsRiddle
{
    public class EinsteinsRiddle
    {
        private static string[] houses = { "Yellow", "Blue", "Red", "Green", "White" };

        private static string[] pets = { "Cat", "Horse", "Bird", "Fish", "Dog" };

        private static string[] nationalities = { "Norwegian", "Dane", "Brit", "German", "Swede" };

        private static string[] cigarettes = { "Dunhill", "Blend", "PallMall", "Prince", "BlueMaster" };

        private static string[] drinks = { "Water", "Tea", "Milk", "Coffee", "Beer" };

        private static string[] hints = new string[15];

        public static void Main()
        {
            Random randGenerator = new Random();
            Shuffle(randGenerator);
            GenerateHints();
            Console.WriteLine("Einstein's riddle");
            Console.WriteLine("The situation:");
            Console.WriteLine("     1.There are 5 houses in five different color.");
            Console.WriteLine("     2.In each house lives a person with different nationality.");
            Console.WriteLine("     3.These five owners drink a certain type of beverage, smoke a certain brand of cigar and keep a certain pet.");
            Console.WriteLine("     4.No owners have the same pet, smoke the same brand of cigar or drink the same beverage.");
            Console.WriteLine($"The question is: Who owns the {pets[4]}?");
            Console.WriteLine("HINTS:");

            for (int i = 1; i <= hints.Length; i++)
            {
                Console.WriteLine($"{i}. {hints[i - 1]}");
            }

            Console.WriteLine("Einstein wrote this riddle this century. He said that 98% of the world could not solve it.");
            Console.WriteLine("To see the solution type solution");

            string solution = Console.ReadLine();
            while (solution.ToLower() != "solution")
            {
                Console.WriteLine("Wrong command. Try again!");
                solution = Console.ReadLine();
            }

            PrintSolution();
        }

        private static void PrintSolution()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"In the {houses[i]} lives the {nationalities[i]}. He drinks {drinks[i]}, smokes {cigarettes[i]}, and has {pets[i]}, as a pet.");
            }
        }

        private static void GenerateHints()
        {
            hints[0] = $"The {nationalities[2]} lives in the {houses[2]} house.";
            hints[1] = $"The {nationalities[4]} keeps {pets[4]} as pets.";
            hints[2] = $"The {nationalities[1]} drinks {drinks[1]}";
            hints[3] = $"The {houses[3]} house is on the left of the {houses[4]} house.";
            hints[4] = $"The {houses[3]} house's owner drinks {drinks[3]}";
            hints[5] = $"The person who smokes {cigarettes[2]} rears {pets[2]}";
            hints[6] = $"The owner of the {houses[0]} smokes {cigarettes[0]}";
            hints[7] = $"The man living in the center house drinks {drinks[2]}";
            hints[8] = $"The {nationalities[0]} lives in the first house";
            hints[9] = $"The man who smokes {cigarettes[1]} lives next to the one who keeps {pets[0]}";
            hints[10] = $"The man who keeps {pets[1]} lives next to the man who smokes {cigarettes[0]}";
            hints[11] = $"The owner who smokes {cigarettes[4]} drinks {drinks[4]}";
            hints[12] = $"The {nationalities[3]} smokes {cigarettes[3]}";
            hints[13] = $"The {nationalities[0]} lives next to the {houses[1]} house";
            hints[14] = $"The man who smokes {cigarettes[1]} has a neighbor who drinks {drinks[0]}";
        }

        private static void Shuffle(Random randGenerator)
        {
            for (int i = 0; i < 5; i++)
            {
                // shuffling houses
                int randomeHouseOneIndex = randGenerator.Next(0, houses.Length);
                int randomeHouseTwoIndex = randGenerator.Next(0, houses.Length);
                Swap(randomeHouseOneIndex, randomeHouseTwoIndex, houses);

                // shuffling pets
                int randomePetOneIndex = randGenerator.Next(0, pets.Length);
                int randomePetTwoIndex = randGenerator.Next(0, pets.Length);
                Swap(randomePetOneIndex, randomePetTwoIndex, pets);

                // shuffling nationalities
                int randomeNationalityOneIndex = randGenerator.Next(0, nationalities.Length);
                int randomeNationalityTwoIndex = randGenerator.Next(0, nationalities.Length);
                Swap(randomeNationalityOneIndex, randomeNationalityTwoIndex, nationalities);

                // shuffling cigarettes
                int randomeCigarettesOneIndex = randGenerator.Next(0, cigarettes.Length);
                int randomeCigarettesTwoIndex = randGenerator.Next(0, cigarettes.Length);
                Swap(randomeCigarettesOneIndex, randomeCigarettesTwoIndex, cigarettes);

                // shuffling drinks
                int randomeDrinkOneIndex = randGenerator.Next(0, drinks.Length);
                int randomeDrinkTwoIndex = randGenerator.Next(0, drinks.Length);
                Swap(randomeDrinkOneIndex, randomeDrinkTwoIndex, drinks);
            }

        }

        private static void Swap(int randomeItemOneIndex, int randomeItemTwoIndex, string[] itemsToRandomise)
        {
            string temp = itemsToRandomise[randomeItemOneIndex];
            itemsToRandomise[randomeItemOneIndex] = itemsToRandomise[randomeItemTwoIndex];
            itemsToRandomise[randomeItemTwoIndex] = temp;
        }
    }
}
