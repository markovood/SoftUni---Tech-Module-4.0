using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _11._Array_Manipulator
{
    public class Array_Manipulator
    {
        // TODO: shorten the solution - remove all comments before passing it to judge otherwise the code is
        // more than 16KB
        public static void Main()
        {
            int[] arr = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            string command = Console.ReadLine();
            while (command != "end")
            {
                string[] commandDetails = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                switch (commandDetails[0])
                {
                    case "exchange":
                        int indexToStartExchange = int.Parse(commandDetails[1]);
                        Exchange(arr, indexToStartExchange);
                        break;
                    case "max":
                        // max even
                        if (commandDetails[1] == "even")
                        {
                            int maxEvenElementIndex = GetMaxEvenElementIndex(arr);
                            if (maxEvenElementIndex >= 0)
                            {
                                Console.WriteLine(maxEvenElementIndex);
                            }
                            else
                            {
                                // If a max even element cannot be found, print “No matches”
                                Console.WriteLine("No matches");
                            }
                        }
                        // max odd
                        else
                        {
                            int maxOddElementIndex = GetMaxOddElementIndex(arr);
                            if (maxOddElementIndex >= 0)
                            {
                                Console.WriteLine(maxOddElementIndex);
                            }
                            else
                            {
                                // If a max odd element cannot be found, print “No matches”
                                Console.WriteLine("No matches");
                            }
                        }
                        break;
                    case "min":
                        // even
                        if (commandDetails[1] == "even")
                        {
                            int minEvenElementIndex = GetMinEvenElementIndex(arr);
                            if (minEvenElementIndex >= 0)
                            {
                                Console.WriteLine(minEvenElementIndex);
                            }
                            else
                            {
                                // If a min even element cannot be found, print “No matches”
                                Console.WriteLine("No matches");
                            }
                        }
                        // odd
                        else
                        {
                            int minOddElementIndex = GetMinOddElementIndex(arr);
                            if (minOddElementIndex >= 0)
                            {
                                Console.WriteLine(minOddElementIndex);
                            }
                            else
                            {
                                // If a min odd element cannot be found, print “No matches”
                                Console.WriteLine("No matches");
                            }
                        }
                        break;
                    case "first":
                        // even
                        if (commandDetails[2] == "even")
                        {
                            // If the count is greater than the array length, print “Invalid count”
                            int count = int.Parse(commandDetails[1]);
                            if (count > arr.Length)
                            {
                                Console.WriteLine("Invalid count");
                            }
                            else
                            {
                                string firstNEvenElements = GetFirstNEvenElements(arr, count);
                                Console.WriteLine($"[{firstNEvenElements}]");
                            }

                        }
                        // odd
                        else
                        {
                            // If the count is greater than the array length, print “Invalid count”
                            int count = int.Parse(commandDetails[1]);
                            if (count > arr.Length)
                            {
                                Console.WriteLine("Invalid count");
                            }
                            else
                            {
                                string firstNOddElements = GetFirstNOddElements(arr, count);
                                Console.WriteLine($"[{firstNOddElements}]");
                            }
                        }
                        break;
                    case "last":
                        // even
                        if (commandDetails[2] == "even")
                        {
                            // If the count is greater than the array length, print “Invalid count”
                            int count = int.Parse(commandDetails[1]);
                            if (count > arr.Length)
                            {
                                Console.WriteLine("Invalid count");
                            }
                            else
                            {
                                string lastNEvenElements = GetLastNEvenElements(arr, count);
                                Console.WriteLine($"[{lastNEvenElements}]");
                            }
                        }
                        // odd
                        else
                        {
                            // If the count is greater than the array length, print “Invalid count”
                            int count = int.Parse(commandDetails[1]);
                            if (count > arr.Length)
                            {
                                Console.WriteLine("Invalid count");
                            }
                            else
                            {
                                string lastNOddElements = GetLastNOddElements(arr, count);
                                Console.WriteLine($"[{lastNOddElements}]");
                            }
                        }
                        break;
                }

                command = Console.ReadLine();
            }

            string finalStateOfArray = string.Join(", ", arr);
            Console.WriteLine($"[{finalStateOfArray}]");
        }

        private static string GetLastNOddElements(int[] arr, int count)
        {
            int[] lastNOddElements = new int[count];
            FillInNeutralValues(lastNOddElements, int.MinValue);

            int oddElementsIndex = 0;
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                int currentElement = arr[i];
                if (currentElement % 2 != 0)
                {
                    if (oddElementsIndex >= count)
                    {
                        break;
                    }
                    else
                    {
                        lastNOddElements[oddElementsIndex] = currentElement;
                        oddElementsIndex++;
                    }
                }
            }

            string result = ProccessArrayWithCommandLast(lastNOddElements);
            return result;
        }

        private static string ProccessArrayWithCommandLast(int[] array)
        {
            // array isEmpty
            if (array[0] == int.MinValue)
            {
                return string.Empty;
            }
            // array !isEmpty
            else
            {
                int lastElement = array[array.Length - 1];
                if (lastElement != int.MinValue)
                {
                    // array is full
                    array = array.Reverse().ToArray();
                    return string.Join(", ", array);
                }
                else
                {
                    // array is partially full
                    string[] elementsThatAreFilled = GetFilledElements(array);

                    elementsThatAreFilled = elementsThatAreFilled.Reverse().ToArray();
                    return string.Join(", ", elementsThatAreFilled);
                }
            }
        }

        private static string GetLastNEvenElements(int[] arr, int count)
        {
            int[] lastNEvenElements = new int[count];
            FillInNeutralValues(lastNEvenElements, int.MinValue);

            int evenElementsIndex = 0;
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                int currentElement = arr[i];
                if (currentElement % 2 == 0)
                {
                    if (evenElementsIndex >= count)
                    {
                        break;
                    }
                    else
                    {
                        lastNEvenElements[evenElementsIndex] = currentElement;
                        evenElementsIndex++;
                    }
                }
            }

            string result = ProccessArrayWithCommandLast(lastNEvenElements);
            return result;
        }

        private static string GetFirstNOddElements(int[] arr, int count)
        {
            /*
             * first {count} odd – returns the first {count} elements -> 
             * [1, 8, 2, 3] -> first 2 odd -> prints [1, 3]
             * 
             * If there are not enough elements to satisfy the count, print as many as you can.
             * [4, 8, 3, 2] -> first 2 odd -> prints [3]
             * 
             * If there are zero odd elements, print an empty array “[]”
             */

            int[] firstNOddElements = new int[count];
            FillInNeutralValues(firstNOddElements, int.MinValue);

            int oddElementsIndex = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                int currentElement = arr[i];
                if (currentElement % 2 != 0)
                {
                    if (oddElementsIndex >= count)
                    {
                        break;
                    }
                    else
                    {
                        firstNOddElements[oddElementsIndex] = currentElement;
                        oddElementsIndex++;
                    }
                }
            }

            string result = ProccessArrayWithCommandFirst(firstNOddElements);
            return result;
        }

        private static string ProccessArrayWithCommandFirst(int[] array)
        {
            // array isEmpty
            if (array[0] == int.MinValue)
            {
                return string.Empty;
            }
            // array !isEmpty
            else
            {
                int lastElement = array[array.Length - 1];
                if (lastElement != int.MinValue)
                {
                    // array is full
                    return string.Join(", ", array);
                }
                else
                {
                    // array is partially full
                    string[] elementsThatAreFilled = GetFilledElements(array);
                    return string.Join(", ", elementsThatAreFilled);
                }
            }
        }

        private static string GetFirstNEvenElements(int[] arr, int count)
        {
            /*
             * first {count} even – returns the first {count} elements -> 
             * [1, 8, 2, 3] -> first 2 even -> prints [8, 2]
             * 
             * If there are not enough elements to satisfy the count, print as many as you can.
             * [1, 8, 3, 7] -> first 2 even -> prints [8]
             * 
             * If there are zero even elements, print an empty array “[]”
             */

            int[] firstNEvenElements = new int[count];
            FillInNeutralValues(firstNEvenElements, int.MinValue);

            int evenElementsIndex = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                int currentElement = arr[i];
                if (currentElement % 2 == 0)
                {
                    if (evenElementsIndex >= count)
                    {
                        break;
                    }
                    else
                    {
                        firstNEvenElements[evenElementsIndex] = currentElement;
                        evenElementsIndex++;
                    }
                }
            }

            string result = ProccessArrayWithCommandFirst(firstNEvenElements);
            return result;
        }

        private static string[] GetFilledElements(int[] firstNEvenElements)
        {
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < firstNEvenElements.Length; i++)
            {
                int currentElement = firstNEvenElements[i];
                if (currentElement != int.MinValue)
                {
                    result.Append(currentElement.ToString() + " ");
                }
                else
                {
                    break;
                }
            }

            return result.ToString().Split(' ', StringSplitOptions.RemoveEmptyEntries);
        }

        private static void FillInNeutralValues(int[] arrToBeFilled, int value)
        {
            for (int i = 0; i < arrToBeFilled.Length; i++)
            {
                arrToBeFilled[i] = value;
            }
        }

        private static int GetMaxEvenElementIndex(int[] arr)
        {
            /*
             * max even – returns the INDEX of the max even element -> 
             * [1, 4, 8, 3, 2, 3] -> max even -> returns 2
             * 
             * If there are two or more equal max elements, return the index of the rightmost one
            */
            int maxEvenElement = int.MinValue;
            int maxEvenElementIndex = -1;
            for (int i = 0; i < arr.Length; i++)
            {
                int currentElement = arr[i];
                if (currentElement % 2 == 0)
                {
                    if (currentElement >= maxEvenElement)
                    {
                        maxEvenElement = currentElement;
                        maxEvenElementIndex = i;
                    }
                }
            }

            return maxEvenElementIndex;
        }

        private static int GetMaxOddElementIndex(int[] arr)
        {
            /*
             * max odd – returns the INDEX of the max odd element -> 
             * [1, 4, 8, 3, 2, 3] -> max odd -> returns 5
             * 
             * If there are two or more equal max elements, return the index of the rightmost one
            */
            int maxOddElement = int.MinValue;
            int maxOddElementIndex = -1;
            for (int i = 0; i < arr.Length; i++)
            {
                int currentElement = arr[i];
                if (currentElement % 2 != 0)
                {
                    if (currentElement >= maxOddElement)
                    {
                        maxOddElement = currentElement;
                        maxOddElementIndex = i;
                    }
                }
            }

            return maxOddElementIndex;
        }

        private static int GetMinEvenElementIndex(int[] arr)
        {
            /*
             * min even – returns the INDEX of the min even element -> 
             * [1, 4, 8, 2, 3, 2] -> min even > prints 5
             * 
             * If there are two or more equal min elements, return the index of the rightmost one
            */

            int minEvenElement = int.MaxValue;
            int minEvenElementIndex = -1;
            for (int i = 0; i < arr.Length; i++)
            {
                int currentElement = arr[i];
                if (currentElement % 2 == 0)
                {
                    if (currentElement <= minEvenElement)
                    {
                        minEvenElement = currentElement;
                        minEvenElementIndex = i;
                    }
                }
            }

            return minEvenElementIndex;
        }

        private static int GetMinOddElementIndex(int[] arr)
        {
            /*
             * min odd – returns the INDEX of the min odd element -> 
             * [1, 4, 8, 1, 2, 3] -> min odd > prints 3
             * 
             * If there are two or more equal min elements, return the index of the rightmost one
            */

            int minOddElement = int.MaxValue;
            int minOddElementIndex = -1;
            for (int i = 0; i < arr.Length; i++)
            {
                int currentElement = arr[i];
                if (currentElement % 2 != 0)
                {
                    if (currentElement <= minOddElement)
                    {
                        minOddElement = currentElement;
                        minOddElementIndex = i;
                    }
                }
            }

            return minOddElementIndex;
        }

        private static void Exchange(int[] arr, int index)
        {
            /*
             * exchange {index} – splits the array after the given index, 
             * and exchanges the places of the two resulting sub-arrays. 
             * E.g. [1, 2, 3, 4, 5] -> exchange 2 -> result: [4, 5, 1, 2, 3]
             * If the index is outside the boundaries of the array, print “Invalid index”
            */
            if (index < 0 || index >= arr.Length)
            {
                Console.WriteLine("Invalid index");
            }
            else
            {
                int numberOfElementsToEnd = arr.Length - (index + 1);
                for (int i = 0; i < numberOfElementsToEnd; i++)
                {
                    InsertAtBegining(arr, arr[arr.Length - 1]);
                }
            }
        }

        private static void InsertAtBegining(int[] arrayToManipulate, int elementToInsert)
        {
            for (int i = arrayToManipulate.Length - 1; i >= 1; i--)
            {
                arrayToManipulate[i] = arrayToManipulate[i - 1];
            }

            arrayToManipulate[0] = elementToInsert;
        }
    }
}
