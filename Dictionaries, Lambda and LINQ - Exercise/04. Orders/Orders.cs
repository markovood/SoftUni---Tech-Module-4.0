using System;
using System.Collections.Generic;

namespace _04._Orders
{
    public class Orders
    {
        public static void Main()
        {
            var orders = new Dictionary<string, decimal[]>();
            
            while (true)
            {
                string[] order = Console.ReadLine().Split(' ');
                if (order[0] == "buy")
                {
                    break;
                }

                string product = order[0];
                decimal productPrice = decimal.Parse(order[1]);
                decimal productQuantity = decimal.Parse(order[2]);

                if (orders.ContainsKey(product))
                {
                    // increase product quantity by the input quantity
                    orders[product][1] += productQuantity;

                    // if product price is different, replace the price as well
                    decimal currentPrice = orders[product][0];
                    if (currentPrice != productPrice)
                    {
                        orders[product][0] = productPrice;
                    }
                }
                else
                {
                    orders.Add(product, new decimal[] { productPrice, productQuantity });
                }
            }

            // print the items with their names and total price of all the products with that name. 
            // 
            foreach (var item in orders)
            {
                string productName = item.Key;
                decimal totalPrice = item.Value[0] * item.Value[1];
                Console.WriteLine($"{productName} -> {totalPrice:F2}");
            }
        }
    }
}
