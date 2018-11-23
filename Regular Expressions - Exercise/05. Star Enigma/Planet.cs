using System;
using System.Collections.Generic;
using System.Text;

namespace _05._Star_Enigma
{
    public class Planet
    {
        public Planet(string name, int population, int soldierCount)
        {
            this.Name = name;
            this.Population = population;
            this.SoldierCount = soldierCount;
        }

        public string Name { get; private set; }
        public int Population { get; private set; }
        public int SoldierCount { get; private set; }

        public override string ToString()
        {
            return this.Name;
        }
    }
}
