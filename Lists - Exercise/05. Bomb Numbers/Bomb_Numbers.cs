using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Bomb_Numbers
{
    public class Bomb_Numbers
    {
        private static List<int> numbers;

        public static void Main()
        {
            numbers = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            var bombNumAndPower = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            int bombNumber = bombNumAndPower[0];
            int power = bombNumAndPower[1];

            int bombNumIndex = numbers.IndexOf(bombNumber);
            while (bombNumIndex >= 0)
            {
                DetonateBomb(bombNumIndex, power);

                bombNumIndex = numbers.IndexOf(bombNumber);
            }

            int sum = numbers.Sum();
            Console.WriteLine(sum);
        }

        private static void DetonateBomb(int bombNumIndex, int power)
        {
            List<int> impact = new List<int>();
            impact.AddRange(GetLeftImpactIndexes(bombNumIndex, power));
            impact.Add(bombNumIndex);
            impact.AddRange(GetRightImpactIndexes(bombNumIndex, power));
            impact = ValidateImpactIndexes(impact, numbers.Count - 1);

            numbers.RemoveRange(impact[0], impact.Count);
        }

        private static List<int> ValidateImpactIndexes(List<int> impact, int maxIndex)
        {
            var validated = new List<int>();
            foreach (var validIndex in impact)
            {
                if (!(validIndex < 0) && !(validIndex > maxIndex))
                {
                    validated.Add(validIndex);
                }
            }

            return validated;
        }

        private static int[] GetRightImpactIndexes(int bombIndex, int power)
        {
            int[] rightImpactIndexes = new int[power];
            for (int i = 0, j = 0; i < power; i++, j++)
            {
                rightImpactIndexes[j] = bombIndex + 1;
                bombIndex++;
            }

            return rightImpactIndexes;
        }

        private static int[] GetLeftImpactIndexes(int bombIndex, int power)
        {
            // starting from the index before bombIndex we go left collecting the indexes to be removed
            int[] leftImpactIndexes = new int[power];

            for (int i = 0, j = 0; i < power; i++, j++)
            {
                leftImpactIndexes[j] = bombIndex - 1;
                bombIndex--;
            }

            // have to reverse it to place the indexes in original order for the removing later
            return leftImpactIndexes.Reverse().ToArray();
        }
    }
}
