using System;

namespace _10._Rage_Expenses
{
    public class Rage_Expenses
    {
        public static void Main()
        {
            int lostGamesCount = int.Parse(Console.ReadLine());
            decimal headsetPrice = decimal.Parse(Console.ReadLine());
            decimal mousePrice = decimal.Parse(Console.ReadLine());
            decimal keyboardPrice = decimal.Parse(Console.ReadLine());
            decimal displayPrice = decimal.Parse(Console.ReadLine());

            // Every second lost game, Pesho trashes his headset.
            int trashedHeadsets = lostGamesCount / 2;

            // Every third lost game, Pesho trashes his mouse.
            int trashedMouses = lostGamesCount / 3;

            // When Pesho trashes both his mouse and headset in the same lost game, he also trashes his keyboard.
            // Every second time, when he trashes his keyboard, he also trashes his display.
            int trashedKeyboards = 0;
            int trashedDisplays = 0;
            int trashedKeyboardsCount = 0;
            for (int i = 1; i <= lostGamesCount; i++)
            {
                if (i % 2 == 0 && i % 3 == 0)
                {
                    trashedKeyboards++;
                    trashedKeyboardsCount++;
                    if (trashedKeyboardsCount % 2 == 0 && trashedKeyboardsCount != 0)
                    {
                        trashedDisplays++;
                    }
                }

            }

            decimal expenses = (trashedHeadsets * headsetPrice) +
                                (trashedMouses * mousePrice) +
                                (trashedKeyboards * keyboardPrice) +
                                (trashedDisplays * displayPrice);

            Console.WriteLine($"Rage expenses: {expenses:F2} lv.");
        }
    }
}
