using System;

namespace _01._Extract_Person_Information
{
    public class Extract_Person_Information
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string line = Console.ReadLine();

                int startIndexName = line.IndexOf('@') + 1;
                int endIndexName = line.IndexOf('|');
                string name = string.Empty;
                if (startIndexName >= 0 && endIndexName >= 0)
                {
                    int length = endIndexName - startIndexName;
                    name = line.Substring(startIndexName, length);
                }

                int startIndexAge = line.IndexOf('#') + 1;
                int endIndexAge = line.IndexOf('*');
                int age = 0;
                if (startIndexAge >= 0 && endIndexAge >= 0)
                {
                    int length = endIndexAge - startIndexAge;
                    age = int.Parse(line.Substring(startIndexAge, length));
                }

                if (name != string.Empty && age != 0)
                {
                    Console.WriteLine($"{name} is {age} years old.");
                }
            }
        }
    }
}
