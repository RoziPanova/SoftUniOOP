using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm
{
    internal class Feline : Animal
    {
        string breed;
        string livingRegion;
        public string LivingRegion { get; set; }
        public string Breed { get; set; }
        public Feline(string type, string name, double weight, string livingRegion, string breed) : base(type, name, weight)
        {
            Type = type;
            Name = name;
            Weight = weight;
            LivingRegion = livingRegion;
            Breed = breed;
        }
        public override void Feed(string foodType,int quantity)
        {
            switch (Type)
            {
                case "Cat":
                    Console.WriteLine("Meow");
                    if (foodType != "Vegetables" || foodType != "Meat")
                        break;
                    Weight += 0.3 * quantity;
                    break;
                case "Tiger":
                    Console.WriteLine("ROAR!!!");
                    if (foodType != "Meat")
                        break;
                    Weight += 1.0 * quantity;
                    break;
                default:
                    break;
            }
        }
        public override string ToString()
        {
            return $"{Type} [{Name}, {Breed}, {Weight}, {LivingRegion}, {FoodEaten}]";
        }
    }
}
