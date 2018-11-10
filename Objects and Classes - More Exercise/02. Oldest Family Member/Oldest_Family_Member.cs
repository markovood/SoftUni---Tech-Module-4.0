using System;

namespace _02._Oldest_Family_Member
{
    public class Oldest_Family_Member
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            var family = new Family();
            for (int i = 0; i < n; i++)
            {
                string[] inputTokens = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string name = inputTokens[0];
                int age = int.Parse(inputTokens[1]);
                var person = new Person(name, age);

                family.AddMember(person);
            }

            var oldest = family.GetOldestMember();
            Console.WriteLine($"{oldest.Name} {oldest.Age}");
        }
    }
}
