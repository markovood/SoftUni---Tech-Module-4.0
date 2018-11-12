using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Store_Boxes
{
    public class Store_Boxes
    {
        public static void Main()
        {
            List<Box> boxes = new List<Box>();
            while (true)
            {
                // {Serial Number} {Item Name} {Item Quantity} {itemPrice}
                string[] inputTokens = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                if (inputTokens[0] == "end")
                {
                    break;
                }

                string serial = inputTokens[0];
                string itemName = inputTokens[1];
                int itemQuantity = int.Parse(inputTokens[2]);
                decimal itemPrice = decimal.Parse(inputTokens[3]);

                var item = new Item(itemName, itemPrice);
                var box = new Box(serial, item, itemQuantity);
                boxes.Add(box);
            }

            var ordered = boxes.OrderByDescending(b => b.Price);
            foreach (var box in ordered)
            {
                Console.WriteLine(box);
            }
        }
    }
}
