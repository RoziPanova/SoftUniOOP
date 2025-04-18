using System;
using System.Collections.Generic;
using System.Text;

namespace WildAnimals
{
    internal class Mouse : Mammal
    {
        public Mouse(string type, string name, double weight, string livingRegion) : base(type, name, weight, livingRegion)
        {
            Type = type;
            Name = name;
            Weight = weight;
            LivingRegion = livingRegion;
        }
        public override void Feed(string foodType, int quantity)
        {
            Console.WriteLine("Squeak");
            if (foodType != "Vegetable" && foodType != "Fruit")
            {
                Console.WriteLine($"Mouse does not eat {foodType}!");
                return;
            }
            FoodEaten += quantity;
            Weight += 0.1 * quantity;
        }
    }
}
