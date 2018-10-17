using System;

namespace _11._Math_operations
{
    public class Math_operations
    {
        public static void Main()
        {
            double firstNumber = double.Parse(Console.ReadLine());
            string @operator = Console.ReadLine();
            double secondNumber = double.Parse(Console.ReadLine());

            double result = Calculate(firstNumber, @operator, secondNumber);
            Console.WriteLine(result);
        }

        private static double Calculate(double firstNumber, string @operator, double secondNumber)
        {
            double result = 0;

            switch (@operator)
            {
                case "+":
                    result = firstNumber + secondNumber;
                    break;
                case "-":
                    result = firstNumber - secondNumber;
                    break;
                case "*":
                    result = firstNumber * secondNumber;
                    break;
                case "/":
                    result = firstNumber / secondNumber;
                    break;
            }

            return result;
        }
    }
}
