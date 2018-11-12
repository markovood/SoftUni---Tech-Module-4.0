using System;
using System.Collections.Generic;
using System.Text;

namespace _07._Store_Boxes
{
    public class Box
    {
        public Box(string serial, Item item, int itemQuantity)
        {
            this.Item = item;
            this.ItemQuantity = itemQuantity;
            this.Price = item.Price * itemQuantity;
            this.SerialNumber = serial;
        }

        public string SerialNumber { get; set; }
        public decimal Price { get; set; }
        public Item Item { get; set; }
        public double ItemQuantity { get; set; }

        public override string ToString()
        {
            string boxStr = $"{this.SerialNumber}{Environment.NewLine}";
            boxStr += $"-- {this.Item.Name} - ${this.Item.Price:f2}: {this.ItemQuantity}{Environment.NewLine}";
            boxStr += $"-- ${this.Price:f2}";

            return boxStr;
        }
    }
}
