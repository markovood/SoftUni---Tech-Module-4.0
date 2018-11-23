using System;
using System.Text.RegularExpressions;

namespace _04._SoftUni_Bar_Income
{
    public class SoftUni_Bar_Income
    {
        public static void Main()
        {
            string pattern = @"%([A-Z][a-z]+)%[^$%|\.]*<(\w+)>[^\$\%\|\.]*\|(\d+)\|[^\$\%\|\.\d]*(\d+\.?\d*)(?=\$)";
            decimal income = 0m;
            while (true)
            {
                string line = Console.ReadLine();
                if (line == "end of shift")
                {
                    break;
                }

                MatchCollection validOrders = Regex.Matches(line, pattern);
                foreach (Match order in validOrders)
                {
                    string customerName = order.Groups[1].Value;
                    string product = order.Groups[2].Value;
                    int quantity = int.Parse(order.Groups[3].Value);
                    decimal productPrice = decimal.Parse(order.Groups[4].Value);
                    decimal totalPrice = quantity * productPrice;
                    Console.WriteLine($"{customerName}: {product} - {totalPrice:f2}");
                    income += totalPrice;
                }
            }

            Console.WriteLine($"Total income: {income:f2}");
        }
    }
}
