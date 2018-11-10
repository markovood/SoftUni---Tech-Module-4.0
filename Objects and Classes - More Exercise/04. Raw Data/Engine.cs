using System;
using System.Collections.Generic;
using System.Text;

namespace _04._Raw_Data
{
    public class Engine
    {
        public Engine(int speed, int power)
        {
            this.Speed = speed;
            this.Power = power;
        }

        public int Speed { get; set; }
        public int Power { get; set; }
    }
}
