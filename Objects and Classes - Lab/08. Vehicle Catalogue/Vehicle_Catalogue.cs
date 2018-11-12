using System;
using System.Linq;

namespace _08._Vehicle_Catalogue
{
    public class Vehicle_Catalogue
    {
        public static void Main()
        {
            var catalogue = new Catalogue();
            while (true)
            {
                string[] inputTokens = Console.ReadLine().Split('/', StringSplitOptions.RemoveEmptyEntries);
                if (inputTokens[0] == "end")
                {
                    break;
                }

                // {type}/{brand}/{model}/{horse power / weight}
                string type = inputTokens[0];
                string brand = inputTokens[1];
                string model = inputTokens[2];
                double weight = 0;
                int horsePower = 0;

                switch (type)
                {
                    case "Car":
                        horsePower = int.Parse(inputTokens[3]);
                        var car = new Car(brand, model, horsePower);
                        catalogue.Cars.Add(car);
                        break;
                    case "Truck":
                        weight = double.Parse(inputTokens[3]);
                        var truck = new Truck(brand, model, weight);
                        catalogue.Trucks.Add(truck);
                        break;
                }
            }

            catalogue.Cars = catalogue.Cars.OrderBy(c => c.Brand).ToList();
            catalogue.Trucks = catalogue.Trucks.OrderBy(tr => tr.Brand).ToList();

            Console.WriteLine(catalogue);
        }
    }
}
