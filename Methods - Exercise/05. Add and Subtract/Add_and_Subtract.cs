using System;

namespace _05._Add_and_Subtract
{
    public class Add_and_Subtract
    {
        public static void Main()
        {
            int firstInt = int.Parse(Console.ReadLine());
            int secondInt = int.Parse(Console.ReadLine());
            int thirdInt = int.Parse(Console.ReadLine());

            int sum = Sum(firstInt, secondInt);
            int result = Subtract(sum, thirdInt);
            Console.WriteLine(result);
        }

        private static int Subtract(int someInt, int otherInt)
        {
            checked
            {
                return someInt - otherInt;
            }
        }

        private static int Sum(int someInt, int otherInt)
        {
            checked
            {
                return someInt + otherInt;
            }
        }
    }
}
