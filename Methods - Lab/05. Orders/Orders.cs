using System;

namespace _05._Orders
{
    public class Orders
    {
        public static void Main()
        {
            string product = Console.ReadLine();
            int quantity = int.Parse(Console.ReadLine());
            CalculatePrice(product, quantity);
        }

        private static void CalculatePrice(string product, int quantity)
        {
            decimal totalPrice = 0m;
            string[] products =
            {
                "coffee",
                "water",
                "coke",
                "snacks"
            };

            decimal[] prices =
            {
                1.5m,
                1m,
                1.4m,
                2m
            };

            int indexOfProduct = Array.IndexOf(products, product);
            totalPrice = prices[indexOfProduct] * quantity;

            Console.WriteLine($"{totalPrice:F2}");
        }
    }
}
