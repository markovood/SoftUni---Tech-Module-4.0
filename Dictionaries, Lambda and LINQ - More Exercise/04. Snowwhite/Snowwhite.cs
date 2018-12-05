using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Snowwhite
{
    public class Snowwhite
    {
        public static void Main()
        {
            var dwarfs = new Dictionary<string, int>();
            while (true)
            {
                string line = Console.ReadLine();
                if (line == "Once upon a time")
                {
                    break;
                }

                string[] lineTokens = line.Split(" <:> ", StringSplitOptions.RemoveEmptyEntries);
                string dwarfName = lineTokens[0];
                string dwarfHatColor = lineTokens[1];
                int dwarfPhisics = int.Parse(lineTokens[2]);

                string dwarf = dwarfName + "-" + dwarfHatColor;
                if (dwarfs.ContainsKey(dwarf))
                {
                    if (dwarfs[dwarf] < dwarfPhisics)
                    {
                        dwarfs[dwarf] = dwarfPhisics;
                    }
                }
                else
                {
                    dwarfs.Add(dwarf, dwarfPhisics);
                }
            }

            var ordered = dwarfs
                  .OrderByDescending(x => x.Value)
                  .ThenByDescending(x => dwarfs.Where(y => y.Key.Split('-')[1] == x.Key.Split('-')[1]).Count());

            foreach (var dwarf in ordered)
            {
                string name = dwarf.Key.Split('-')[0];
                string hatColor = dwarf.Key.Split('-')[1];
                int phisics = dwarf.Value;
                Console.WriteLine($"({hatColor}) {name} <-> {phisics}");
            }
        }
    }
}
