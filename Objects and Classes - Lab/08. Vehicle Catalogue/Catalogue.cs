using System;
using System.Collections.Generic;
using System.Text;

namespace _08._Vehicle_Catalogue
{
    public class Catalogue
    {
        public Catalogue()
        {
            this.Cars = new List<Car>();
            this.Trucks = new List<Truck>();
        }

        public List<Car> Cars { get; set; }
        public List<Truck> Trucks { get; set; }
        public override string ToString()
        {
            StringBuilder catalogueStr = new StringBuilder();

            if (this.Cars.Count > 0)
            {
                catalogueStr.AppendLine("Cars:");
                foreach (var car in this.Cars)
                {
                    catalogueStr.AppendLine(car.ToString());
                } 
            }

            if (this.Trucks.Count > 0)
            {
                catalogueStr.AppendLine("Trucks:");
                foreach (var truck in this.Trucks)
                {
                    catalogueStr.AppendLine(truck.ToString());
                } 
            }

            return catalogueStr.ToString().Trim();
        }
    }
}
