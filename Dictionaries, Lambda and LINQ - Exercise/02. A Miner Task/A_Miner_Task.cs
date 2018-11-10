using System;
using System.Collections.Generic;

namespace _02._A_Miner_Task
{
    public class A_Miner_Task
    {
        public static void Main()
        {
            var resourceTable = new Dictionary<string, int>();
            while (true)
            {
                string resource = Console.ReadLine();
                if (resource == "stop")
                {
                    break;
                }

                int quantity = int.Parse(Console.ReadLine());
                if (resourceTable.ContainsKey(resource))
                {
                    resourceTable[resource] += quantity;
                }
                else
                {
                    resourceTable.Add(resource, quantity);
                }
            }

            foreach (var item in resourceTable)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
