using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02._Furniture
{
    public class Furniture
    {
        public static void Main()
        {
            string pattern = @">>([A-Za-z]+)<<([\d+\.]+)!(\d+)";
            List<Match> allFurnituresDetails = new List<Match>();
            decimal totalPrice = 0m;
            Console.WriteLine("Bought furniture:");
            while (true)
            {
                string line = Console.ReadLine();
                if (line == "Purchase")
                {
                    break;
                }

                Match furnitureDetails = Regex.Match(line, pattern);
                if (furnitureDetails.Success)
                {
                    allFurnituresDetails.Add(furnitureDetails); 
                }
            }

            foreach (var furnitureDetails in allFurnituresDetails)
            {
                string furnitureName = furnitureDetails.Groups[1].Value;
                decimal furniturePrice = decimal.Parse(furnitureDetails.Groups[2].Value);
                int quantity = int.Parse(furnitureDetails.Groups[3].Value);
                totalPrice += furniturePrice * quantity;
                Console.WriteLine(furnitureName);
            }

            Console.WriteLine($"Total money spend: {totalPrice:f2}");
        }
    }
}
