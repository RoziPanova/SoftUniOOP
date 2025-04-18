using System;
using System.Collections.Generic;
using System.Text;

namespace WildAnimals
{
    internal class Dog : Mammal
    {
        public Dog(string type, string name, double weight, string livingRegion) : base(type, name, weight, livingRegion)
        {
            Type = type;
            Name = name;
            Weight = weight;
            LivingRegion = livingRegion;
        }
        public override void Feed(string foodType, int quantity)
        {
            Console.WriteLine("Woof!");
            if (foodType != "Meat")
            {
                Console.WriteLine($"Dog does not eat {foodType}!");
                return;
            }
            FoodEaten += quantity;
            Weight += 0.4 * quantity;
        }
    }
}
