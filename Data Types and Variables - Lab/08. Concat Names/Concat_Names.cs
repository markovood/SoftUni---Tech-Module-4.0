using System;

namespace _08._Concat_Names
{
    public class Concat_Names
    {
        public static void Main()
        {
            string firstName = Console.ReadLine();
            string secondName = Console.ReadLine();
            string delimiter = Console.ReadLine();

            Console.WriteLine(firstName + delimiter + secondName);
        }
    }
}
