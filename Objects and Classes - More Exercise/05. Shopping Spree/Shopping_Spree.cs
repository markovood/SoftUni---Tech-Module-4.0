using System;
using System.Collections.Generic;

namespace _05._Shopping_Spree
{
    public class Shopping_Spree
    {
        public static void Main()
        {
            string[] peopleAndMoney = Console.ReadLine().Split(";=".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            string[] productsAndCost = Console.ReadLine().Split(";=".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

            List<Person> people = new List<Person>();
            List<Product> products = new List<Product>();

            // all people 
            for (int i = 1; i < peopleAndMoney.Length; i += 2)
            {
                string name = peopleAndMoney[i - 1];
                decimal money = decimal.Parse(peopleAndMoney[i]);
                var person = new Person(name, money);
                people.Add(person);
            }

            // all products
            for (int i = 1; i < productsAndCost.Length; i += 2)
            {
                string name = productsAndCost[i - 1];
                decimal cost = decimal.Parse(productsAndCost[i]);
                var product = new Product(name, cost);
                products.Add(product);
            }

            while (true)
            {
                string[] commandDetails = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                if (commandDetails[0] == "END")
                {
                    break;
                }

                string name = commandDetails[0];
                string productName = commandDetails[1];
                var person = people.Find(p => p.Name == name);
                var product = products.Find(pr => pr.Name == productName);
                if (person.Money >= product.Cost)
                {
                    person.Money -= product.Cost;
                    person.BagOfProducts.Add(product);
                    Console.WriteLine($"{person.Name} bought {product.Name}");
                }
                else
                {
                    Console.WriteLine($"{person.Name} can't afford {product.Name}");
                }
            }

            foreach (var person in people)
            {
                Console.WriteLine(person);
            }
        }
    }
}
