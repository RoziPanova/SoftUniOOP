using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace VehiclesExtended
{
    public abstract class Vehicle
    {
        string type;
        double fuelQuantity;
        double fuelConsumption;
        double tankCapacity;
        public double TankCapacity { get; set; }
        public string Type { get; set; }
        public double FuelConsumption { get; set; }
        public double FuelQuantity { get; set; }
        public double Check(double fuelQuantity, double tankCapacity)
        {
            if (fuelQuantity > tankCapacity)
            {
                return 0;
            }
            return fuelQuantity;
        }
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
            if (fuel <= 0)
            {
                Console.WriteLine("Fuel must be a positive number");
                return;
            }
            if (FuelQuantity + fuel > TankCapacity)
            {
                Console.WriteLine($"Cannot fit {fuel} fuel in the tank");
                return;
            }
            FuelQuantity += fuel;
        }
    }
}
