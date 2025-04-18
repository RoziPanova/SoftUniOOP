using System;
using System.Collections.Generic;
using System.Text;

namespace WildAnimals
{
    internal class Cat : Feline
    {
        public Cat(string type, string name, double weight, string livingRegion, string breed) : base(type, name, weight, livingRegion, breed)
        {
            Type = type;
            Name = name;
            Weight = weight;
            LivingRegion = livingRegion;
            Breed = breed;
        }
        public override void Feed(string foodType, int quantity)
        {
            Console.WriteLine("Meow");
            if (foodType != "Vegetable" && foodType != "Meat")
            {
                Console.WriteLine($"Cat does not eat {foodType}!");
                return;
            }
            FoodEaten += quantity;
            Weight += 0.3 * quantity;
        }
    }
}
