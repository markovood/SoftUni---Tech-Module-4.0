using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Drum_Set
{
    public class Drum_Set
    {
        public static void Main()
        {
            decimal savings = decimal.Parse(Console.ReadLine());
            List<int> initialDrumsQuality = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToList();

            List<int> drumsCurrentQuality = new List<int>(initialDrumsQuality);
            while (true)
            {
                string command = Console.ReadLine();
                if (command == "Hit it again, Gabsy!")
                {
                    break;
                }

                int powerApplied = int.Parse(command);

                for (int i = 0; i < drumsCurrentQuality.Count; i++)
                {
                    // apply power
                    drumsCurrentQuality[i] -= powerApplied;

                    bool isDrumBroken = drumsCurrentQuality[i] <= 0;//N.B.'<=' When a certain drum REACHES 0 quality, it breaks.
                    if (isDrumBroken)
                    {
                        int initialQuality = initialDrumsQuality[i];
                        decimal price = initialQuality * 3m;

                        bool canBuy = savings - price >= 0;
                        if (canBuy)
                        {
                            // buy
                            savings -= price;
                            drumsCurrentQuality[i] = initialQuality;
                        }
                        else
                        {
                            // remove
                            drumsCurrentQuality.RemoveAt(i);    // N.B. possible index problem after removing one
                            initialDrumsQuality.RemoveAt(i);
                            i -= 1;
                        }
                    }
                }
            }

            // finish
            string currentStateOfDrumSet = string.Join(' ', drumsCurrentQuality);
            Console.WriteLine(currentStateOfDrumSet);
            Console.WriteLine($"Gabsy has {savings:F2}lv.");
        }
    }
}
