using System;
using System.Collections.Generic;
using System.Text;

namespace _08._Vehicle_Catalogue
{
    public class Truck
    {
        public Truck(string brand, string model, double weight)
        {
            this.Brand = brand;
            this.Model = model;
            this.Weight = weight;
        }

        public string Brand { get; set; }
        public string Model { get; set; }
        public double Weight { get; set; }

        public override string ToString()
        {
            string truckStr = $"{this.Brand}: {this.Model} - {this.Weight}kg";
            return truckStr;
        }
    }
}
