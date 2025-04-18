using System;
using System.Collections.Generic;
using System.Text;

namespace WildAnimals
{
    internal class Tiger : Feline
    {
        public Tiger(string type, string name, double weight, string livingRegion, string breed) : base(type, name, weight, livingRegion, breed)
        {
            Type = type;
            Name = name;
            Weight = weight;
            LivingRegion = livingRegion;
            Breed = breed;
        }
        public override void Feed(string foodType, int quantity)
        {
            Console.WriteLine("ROAR!!!");
            if (foodType != "Meat")
            {
                Console.WriteLine($"Tiger does not eat {foodType}!");
                return;
            }
            FoodEaten += quantity;
            Weight += 1.0 * quantity;
        }
    }
}
