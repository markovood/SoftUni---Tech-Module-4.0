using System;
using System.Collections.Generic;
using System.Linq;

namespace _08._Company_Users
{
    public class Company_Users
    {
        public static void Main()
        {
            var companiesAndEmployees = new Dictionary<string, HashSet<string>>();
            while (true)
            {
                string[] input = Console.ReadLine().Split(" -> ");
                if (input[0] == "End")
                {
                    break;
                }

                string companyName = input[0];
                string employeeId = input[1];
                if (companiesAndEmployees.ContainsKey(companyName))
                {
                    companiesAndEmployees[companyName].Add(employeeId);
                }
                else
                {
                    companiesAndEmployees.Add(companyName, new HashSet<string>() { employeeId });
                }
            }

            // order the companies by the name in ascending order
            companiesAndEmployees = companiesAndEmployees
                .OrderBy(c => c.Key)
                .ToDictionary(c => c.Key, 
                            c => c.Value);

            // Print the company name and each employee's id
            foreach (var item in companiesAndEmployees)
            {
                string companyName = item.Key;
                var employees = item.Value.ToArray();
                Console.WriteLine(companyName);
                foreach (var employeeId in employees)
                {
                    Console.WriteLine($"-- {employeeId}");
                }
            }
        }
    }
}
