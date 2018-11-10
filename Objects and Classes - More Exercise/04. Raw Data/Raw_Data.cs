using System;
using System.Linq;

namespace _04._Raw_Data
{
    public class Raw_Data
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            Car[] cars = new Car[n];
            for (int i = 0; i < n; i++)
            {
                // "<Model> <EngineSpeed> <EnginePower> <CargoWeight> <CargoType>"
                string[] tokens = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string model = tokens[0];
                int speed = int.Parse(tokens[1]);
                int power = int.Parse(tokens[2]);
                int weight = int.Parse(tokens[3]);
                string type = tokens[4];

                var engine = new Engine(speed, power);
                var cargo = new Cargo(type, weight);
                var car = new Car(model, engine, cargo);
                cars[i] = car;
            }

            string command = Console.ReadLine();
            switch (command)
            {
                case "fragile":
                    var filtered = cars
                                    .Where(c => c.Cargo.Type == command)
                                    .Where(c => c.Cargo.Weight < 1000)
                                    .ToArray();

                    foreach (var item in filtered)
                    {
                        Console.WriteLine(item.Model);
                    }

                    break;

                case "flamable":
                    filtered = cars
                        .Where(c => c.Cargo.Type == command)
                        .Where(c => c.Engine.Power > 250)
                        .ToArray();

                    foreach (var item in filtered)
                    {
                        Console.WriteLine(item.Model);
                    }

                    break;
            }
        }
    }
}
