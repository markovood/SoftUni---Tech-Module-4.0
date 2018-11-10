using System;
using System.Collections.Generic;

namespace _03._Speed_Racing
{
    public class Speed_Racing
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();
            for (int i = 0; i < n; i++)
            {
                string[] inputTokens = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string model = inputTokens[0];
                double fuelAmount = double.Parse(inputTokens[1]);
                double consumption = double.Parse(inputTokens[2]);

                var car = new Car(model, fuelAmount, consumption);
                cars.Add(car);
            }

            while (true)
            {
                string command = Console.ReadLine();
                if (command == "End")
                {
                    break;
                }

                string[] tokens = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string carModel = tokens[1];
                double distanceKm = double.Parse(tokens[2]);

                var car = cars.Find(c => c.Model == carModel);
                if (car.CanTravel(distanceKm))
                {
                    double neededFuel = distanceKm * car.ConsumptionPer1Km;
                    car.FuelAmount -= neededFuel;
                    car.TravelledDistance += distanceKm;
                }
            }

            foreach (var car in cars)
            {
                Console.WriteLine(car);
            }
        }
    }
}
