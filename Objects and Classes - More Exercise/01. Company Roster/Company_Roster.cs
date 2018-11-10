using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Company_Roster
{
    public class Company_Roster
    {
        public static void Main()
        {
            List<Employee> employees = new List<Employee>();
            HashSet<string> departaments = new HashSet<string>();

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] line = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                var employee = new Employee(line[0], decimal.Parse(line[1]), line[2]);

                departaments.Add(line[2]);
                employees.Add(employee);
            }

            var deptAndAverageSalary = new Dictionary<string, decimal>();
            var deptAndEmployees = new Dictionary<string, Employee[]>();
            foreach (var departament in departaments)
            {
                var employeesInDept = employees.Where(x => x.Departament == departament).ToArray();
                decimal averageSalary = 0m;
                foreach (var employee in employeesInDept)
                {
                    averageSalary += employee.Salary;
                }

                averageSalary = averageSalary / employeesInDept.Length;

                deptAndEmployees.Add(departament, employeesInDept);
                deptAndAverageSalary.Add(departament, averageSalary);
            }

            var orderedDeptAndAverageSalary = deptAndAverageSalary
                                    .OrderByDescending(x => x.Value);

            string bestDepartament = orderedDeptAndAverageSalary.First().Key;

            var employeesFromBestDept = deptAndEmployees[bestDepartament]
                                            .OrderByDescending(x => x.Salary);

            Console.WriteLine($"Highest Average Salary: {bestDepartament}");
            foreach (var employee in employeesFromBestDept)
            {
                string name = employee.Name;
                decimal salary = employee.Salary;
                Console.WriteLine($"{name} {salary:f2}");
            }
        }
    }
}
