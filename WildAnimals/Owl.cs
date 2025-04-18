using System;
using System.Collections.Generic;
using System.Text;

namespace WildAnimals
{
    internal class Owl : Bird
    {
        public Owl(string type, string name, double weight, double wingSize) : base(type, name, weight, wingSize)
        {
            Type = type;
            Name = name;
            Weight = weight;
            WingSize = wingSize;
        }
        public override void Feed(string foodType, int quantity)
        {
            Console.WriteLine("Hoot Hoot");
            if (foodType != "Meat")
            {
                Console.WriteLine($"Owl does not eat {foodType}!");
                return;
            }
            FoodEaten += quantity;
            Weight += 0.25 * quantity;
        }
    }
}
