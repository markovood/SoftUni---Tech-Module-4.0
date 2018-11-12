﻿using System;
using System.Collections.Generic;
using System.Text;

namespace _08._Vehicle_Catalogue
{
    public class Car
    {
        public Car(string brand, string model, int horsePower)
        {
            this.Brand = brand;
            this.Model = model;
            this.HorsePower = horsePower;
        }

        public string Brand { get; set; }
        public string Model { get; set; }
        public int HorsePower { get;  set; }

        public override string ToString()
        {
            string carStr = $"{this.Brand}: {this.Model} - {this.HorsePower}hp";
            return carStr;
        }
    }
}
