using System;
using System.Collections.Generic;
using System.Text;

namespace _03._Speed_Racing
{
    public class Car
    {
        public Car(string model, double fuelAmount, double consumptionPer1Km, double travelledDistance = 0)
        {
            this.Model = model;
            this.FuelAmount = fuelAmount;
            this.ConsumptionPer1Km = consumptionPer1Km;
            this.TravelledDistance = travelledDistance;
        }

        public string Model { get; set; }
        public double FuelAmount { get; set; }
        public double ConsumptionPer1Km { get; set; }
        public double TravelledDistance { get; set; }

        public bool CanTravel(double distanceKm)
        {
            double neededFuel = distanceKm * this.ConsumptionPer1Km;
            if (this.FuelAmount >= neededFuel)
            {
                return true;
            }
            else
            {
                Console.WriteLine("Insufficient fuel for the drive");
                return false;
            }
        }

        public override string ToString()
        {
            // "<Model> <fuelAmount> <distanceTraveled>"
            string carStr = $"{this.Model} {this.FuelAmount:f2} {this.TravelledDistance}";
            return carStr;
        }
    }
}
