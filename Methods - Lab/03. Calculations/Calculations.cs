﻿using System;

namespace _03._Calculations
{
    public class Calculations
    {
        public static void Main()
        {
            string operation = Console.ReadLine();
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());

            switch (operation)
            {
                case "add":
                    Add(firstNumber, secondNumber);
                    break;
                case "subtract":
                    Subtract(firstNumber, secondNumber);
                    break;
                case "multiply":
                    Multiply(firstNumber, secondNumber);
                    break;
                case "divide":
                    Divide(firstNumber, secondNumber);
                    break;
            }
        }

        private static void Divide(int firstNumber, int secondNumber)
        {
            Console.WriteLine(firstNumber / secondNumber);
        }

        private static void Multiply(int firstNumber, int secondNumber)
        {
            Console.WriteLine(firstNumber * secondNumber);
        }

        private static void Subtract(int firstNumber, int secondNumber)
        {
            Console.WriteLine(firstNumber - secondNumber);
        }

        private static void Add(int firstNumber, int secondNumber)
        {
            Console.WriteLine(firstNumber + secondNumber);
        }
    }
}
