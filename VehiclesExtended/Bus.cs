using System;
using System.Collections.Generic;
using System.Text;

namespace VehiclesExtended
{
    internal class Bus : Vehicle
    {
        public Bus(string type, double fuelQuantity, double fuelConsumption, double tankCapacity)
        {
            Type = type;
            FuelQuantity = Check(fuelQuantity, tankCapacity);
            FuelConsumption = fuelConsumption;
            TankCapacity = tankCapacity;
        }
    }
}
