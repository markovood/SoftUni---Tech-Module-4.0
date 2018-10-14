using System;

namespace _01._Train
{
    public class Train
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int[] trainWagons = new int[n];
            int sumOfPeople = 0;
            for (int i = 0; i < n; i++)
            {
                int people = int.Parse(Console.ReadLine());
                trainWagons[i] = people;

                checked
                {
                    sumOfPeople += people; 
                }
            }

            Console.WriteLine(string.Join(' ', trainWagons));
            Console.WriteLine(sumOfPeople);
        }
    }
}
