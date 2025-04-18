using System;
using System.Collections.Generic;
using System.Text;

namespace Vehicles
{
    public class Car : Vehicle
    {
        public Car(string type,double fuelQuantity, double fuelConsumption)
        {
            Type=type;
            FuelQuantity = fuelQuantity;
            FuelConsumption = fuelConsumption + 0.9;
        }
    }
}
