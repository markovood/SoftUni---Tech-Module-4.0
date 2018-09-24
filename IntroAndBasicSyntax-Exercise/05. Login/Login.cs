using System;
using System.Linq;

namespace _05._Login
{
    public class Login
    {
        public static void Main()
        {
            string userName = Console.ReadLine();
            string correctPassword = string.Join("", userName.Reverse().ToArray());
            int counter = 1;

            while (Console.ReadLine() != correctPassword)
            {
                if (counter == 4)
                {
                    Console.WriteLine($"User {userName} blocked!");
                    return;
                }

                Console.WriteLine("Incorrect password. Try again.");
                counter++;
                
            }

            Console.WriteLine($"User {userName} logged in.");
        }
    }
}
