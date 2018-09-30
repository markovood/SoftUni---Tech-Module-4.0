using System;

namespace _04._Elevator
{
    public class Elevator
    {
        public static void Main()
        {
            int numberOfPeople = int.Parse(Console.ReadLine());
            int liftCapacity = int.Parse(Console.ReadLine());

            int courses = (int)Math.Ceiling((double)numberOfPeople / liftCapacity);
            Console.WriteLine(courses);
        }
    }
}
