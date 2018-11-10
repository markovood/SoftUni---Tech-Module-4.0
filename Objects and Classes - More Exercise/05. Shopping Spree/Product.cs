using System;
using System.Collections.Generic;
using System.Text;

namespace _05._Shopping_Spree
{
    public class Product
    {
        public Product(string name, decimal cost)
        {
            this.Name = name;
            this.Cost = cost;
        }

        public string Name { get; set; }
        public decimal Cost { get; set; }

        public override string ToString()
        {
            return this.Name;
        }
    }
}
