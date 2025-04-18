using System;

namespace Vehicles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            var car = new Car(input[0], double.Parse(input[1]), double.Parse(input[2]));
            input = Console.ReadLine().Split(" ");
            var truck = new Truck(input[0], double.Parse(input[1]), double.Parse(input[2]));
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
                else if (input[0] == "Refuel" && input[1] == "Car")
                {
                    car.Refule(double.Parse(input[2]));
                }
                else if (input[0] == "Refuel" && input[1] == "Truck")
                {
                    truck.Refule(double.Parse(input[2]));
                }
            }
            Console.WriteLine($"Car: {car.FuelQuantity:f2}");
            Console.WriteLine($"Truck: {truck.FuelQuantity:f2}");
        }
    }
}
