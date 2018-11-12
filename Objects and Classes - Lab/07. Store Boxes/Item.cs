using System;
using System.Collections.Generic;
using System.Text;

namespace _07._Store_Boxes
{
    public class Item
    {
        public Item(string name, decimal price)
        {
            this.Name = name;
            this.Price = price;
        }

        public string Name { get; set; }
        public decimal Price { get; set; }
    }
}
