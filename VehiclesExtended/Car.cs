using System;
using System.Collections.Generic;
using System.Text;

namespace VehiclesExtended
{
    public class Car : Vehicle
    {
        public Car(string type, double fuelQuantity, double fuelConsumption, double tankCapacity)
        {
            Type = type;
            FuelConsumption = fuelConsumption + 0.9;
            TankCapacity = tankCapacity;
            FuelQuantity = Check(fuelQuantity, tankCapacity);
        }
    }
}
