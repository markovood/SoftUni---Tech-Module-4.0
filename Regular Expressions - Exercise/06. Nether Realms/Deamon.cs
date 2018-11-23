using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace _06._Nether_Realms
{
    public class Deamon
    {
        public Deamon(string name, double health, double damage)
        {
            this.Name = name;
            this.Health = health;
            this.Damage = damage;
        }

        public string Name { get; private set; }
        public double Health { get; private set; }
        public double Damage { get; private set; }
        
        public override string ToString()
        {
            return $"{this.Name} - {this.Health} health, {this.Damage:f2} damage";
        }
    }
}
