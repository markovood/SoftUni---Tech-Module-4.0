using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Order_by_Age
{
    public class Order_by_Age
    {
        public static void Main()
        {
            List<Person> persons = new List<Person>();
            while (true)
            {
                string line = Console.ReadLine();
                if (line == "End")
                {
                    break;
                }

                string[] tokens = line.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string name = tokens[0];
                string id = tokens[1];
                int age = int.Parse(tokens[2]);

                var person = new Person(name, id, age);
                persons.Add(person);
            }

            persons = persons.OrderBy(x => x.Age).ToList();
            foreach (var person in persons)
            {
                Console.WriteLine(person);
            }
        }
    }
}
