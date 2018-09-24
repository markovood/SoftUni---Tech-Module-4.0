using System;

namespace _03._Vacation
{
    public class Vacation
    {
        public static void Main()
        {
            int numberOfPeople = int.Parse(Console.ReadLine());
            string typeOfGroup = Console.ReadLine();
            string dayOfWeek = Console.ReadLine();

            decimal pricePerPerson = GetPricePerPerson(typeOfGroup, dayOfWeek);
            decimal finalPrice = 0m;

            switch (typeOfGroup)
            {
                case "Students":
                    // -15%
                    if (numberOfPeople >= 30)
                    {
                        finalPrice = numberOfPeople * pricePerPerson * (1m - 0.15m);
                    }
                    else
                    {
                        finalPrice = numberOfPeople * pricePerPerson;
                    }
                    break;
                case "Business":
                    // 10 people free
                    if (numberOfPeople >= 100)
                    {
                        finalPrice = (numberOfPeople - 10) * pricePerPerson;
                    }
                    else
                    {
                        finalPrice = numberOfPeople * pricePerPerson;
                    }
                    break;
                case "Regular":
                    // -5%
                    if (numberOfPeople >= 10 && numberOfPeople <= 20)
                    {
                        finalPrice = numberOfPeople * pricePerPerson * (1m - 0.05m);
                    }
                    else
                    {
                        finalPrice = numberOfPeople * pricePerPerson;
                    }
                    break;
            }

            Console.WriteLine($"Total price: {finalPrice:F2}");
        }

        private static decimal GetPricePerPerson(string typeOfGroup, string dayOfWeek)
        {
            decimal pricePerPerson = 0;
            if (dayOfWeek == "Friday")
            {
                switch (typeOfGroup)
                {
                    case "Students":
                        pricePerPerson = 8.45m;
                        break;
                    case "Business":
                        pricePerPerson = 10.9m;
                        break;
                    case "Regular":
                        pricePerPerson = 15m;
                        break;
                }

                return pricePerPerson;
            }
            else if (dayOfWeek == "Saturday")
            {
                switch (typeOfGroup)
                {
                    case "Students":
                        pricePerPerson = 9.8m;
                        break;
                    case "Business":
                        pricePerPerson = 15.6m;
                        break;
                    case "Regular":
                        pricePerPerson = 20m;
                        break;
                }

                return pricePerPerson;
            }
            else if (dayOfWeek == "Sunday")
            {
                switch (typeOfGroup)
                {
                    case "Students":
                        pricePerPerson = 10.46m;
                        break;
                    case "Business":
                        pricePerPerson = 16m;
                        break;
                    case "Regular":
                        pricePerPerson = 22.5m;
                        break;
                }

                return pricePerPerson;
            }

            return pricePerPerson;
        }
    }
}
