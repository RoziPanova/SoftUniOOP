using System;

namespace VehiclesExtended
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            var car = new Car(input[0], double.Parse(input[1]), double.Parse(input[2]), double.Parse(input[3]));
            input = Console.ReadLine().Split(" ");
            var truck = new Truck(input[0], double.Parse(input[1]), double.Parse(input[2]), double.Parse(input[3]));
            input = Console.ReadLine().Split(" ");
            var bus = new Bus(input[0], double.Parse(input[1]), double.Parse(input[2]), double.Parse(input[3]));
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                input = Console.ReadLine().Split(" ");
                if (input[0] == "Drive" && input[1] == "Car")
                {
                    car.Drive(double.Parse(input[2]));
                }
                else if (input[0] == "Drive" && input[1] == "Truck")
                {
                    truck.Drive(double.Parse(input[2]));
                }
                else if (input[0] == "DriveEmpty" && input[1] == "Bus")
                {
                    bus.Drive(double.Parse(input[2]));
                }
                else if (input[0] == "Drive" && input[1] == "Bus")
                {
                    bus.FuelConsumption += 1.4;
                    bus.Drive(double.Parse(input[2]));
                    bus.FuelConsumption -= 1.4;
                }
                else if (input[0] == "Refuel" && input[1] == "Car")
                {
                    car.Refule(double.Parse(input[2]));
                }
                else if (input[0] == "Refuel" && input[1] == "Truck")
                {
                    truck.Refule(double.Parse(input[2]));
                }
                else if (input[0] == "Refuel" && input[1] == "Bus")
                {
                    bus.Refule(double.Parse(input[2]));
                }
            }
            Console.WriteLine($"Car: {car.FuelQuantity:f2}");
            Console.WriteLine($"Truck: {truck.FuelQuantity:f2}");
            Console.WriteLine($"Bus: {bus.FuelQuantity:f2}");
        }
    }
}
/*
Car 30 0,04 70
Truck 100 0,5 300
Bus 40 0,3 150
8
Refuel Car -10
Refuel Truck 0
Refuel Car 10
Refuel Car 300
Drive Bus 10
Refuel Bus 1000
DriveEmpty Bus 100
Refuel Truck 1000
 */
