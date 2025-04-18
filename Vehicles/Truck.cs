using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    public class Truck : Vehicle
    {
        public Truck(string type, double fuelQuantity, double fuelConsumption)
        {
            Type = type;
            FuelQuantity = fuelQuantity;
            FuelConsumption = fuelConsumption + 1.6;
        }
        public override void Refule(double fuel)
        {
            FuelQuantity += (fuel - (fuel * 0.05));
        }
    }
}
