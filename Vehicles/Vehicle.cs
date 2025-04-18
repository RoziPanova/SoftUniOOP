using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Vehicles
{
    public abstract class Vehicle
    {
        string type;
        double fuelQuantity;
        double fuelConsumption;
        public string Type { get; set; }
        public double FuelConsumption { get; set; }
        public double FuelQuantity { get; set; }
        public void Drive(double km)
        {
            if (FuelQuantity - (km * FuelConsumption) < 0)
            {
                Console.WriteLine($"{Type} needs refueling");
                return;
            }
            FuelQuantity -= km * FuelConsumption;
            Console.WriteLine($"{Type} travelled {km} km");
        }

        public virtual void Refule(double fuel)
        {
           FuelQuantity+= fuel;
        }
    }
}
