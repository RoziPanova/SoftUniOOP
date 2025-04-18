using System;
using System.Collections.Generic;
using System.Text;

namespace VehiclesExtended
{
    public class Truck : Vehicle
    {
        public Truck(string type, double fuelQuantity, double fuelConsumption, double tankCapacity)
        {
            Type = type;
            FuelQuantity = Check(fuelQuantity, tankCapacity);
            FuelConsumption = fuelConsumption + 1.6;
            TankCapacity = tankCapacity;
        }
        public override void Refule(double fuel)
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
            FuelQuantity += (fuel - (fuel * 0.05));
        }
    }
}
