using System;
using System.Collections.Generic;

namespace _04._List_of_Products
{
    public class List_of_Products
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            var products = new List<string>();
            for (int i = 0; i < n; i++)
            {
                string product = Console.ReadLine();
                products.Add(product);
            }

            products.Sort();
            int prodNum = 1;
            foreach (var product in products)
            {
                Console.WriteLine($"{prodNum++}.{product}");
            }
        }
    }
}
