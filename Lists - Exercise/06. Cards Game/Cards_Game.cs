using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Cards_Game
{
    public class Cards_Game
    {
        public static void Main()
        {
            var firstHand = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            var secondHand = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            while (firstHand.Count > 0 && secondHand.Count > 0)
            {
                EvaluateFirstCard(firstHand, secondHand);
            }

            string winner = "";
            int sum = 0;
            if (firstHand.Count > secondHand.Count)
            {
                winner = "First";
                sum = firstHand.Sum();
            }
            else
            {
                winner = "Second";
                sum = secondHand.Sum();
            }

            Console.WriteLine($"{winner} player wins! Sum: {sum}");
        }

        private static void EvaluateFirstCard(List<int> firstHand, List<int> secondHand)
        {
            int firstCardIndex = 0;
            if (firstHand[firstCardIndex] > secondHand[firstCardIndex])
            {
                int fhLastIndex = firstHand.Count - 1;
                int firstHandFirstCard = firstHand[firstCardIndex];
                firstHand.RemoveAt(firstCardIndex);
                firstHand.Insert(fhLastIndex, firstHandFirstCard);
                fhLastIndex = firstHand.Count - 1;
                firstHand.Insert(fhLastIndex, secondHand[firstCardIndex]);

                secondHand.RemoveAt(firstCardIndex);
            }
            else if (firstHand[firstCardIndex] == secondHand[firstCardIndex])
            {
                firstHand.RemoveAt(firstCardIndex);
                secondHand.RemoveAt(firstCardIndex);
            }
            else
            {
                int shLastIndex = secondHand.Count - 1;
                int secondHandFirstCard = secondHand[firstCardIndex];
                secondHand.RemoveAt(firstCardIndex);
                secondHand.Insert(shLastIndex, secondHandFirstCard);
                shLastIndex = secondHand.Count - 1;
                secondHand.Insert(shLastIndex, firstHand[firstCardIndex]);

                firstHand.RemoveAt(firstCardIndex);
            }
        }
    }
}
