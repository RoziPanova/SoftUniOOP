using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm
{
    internal class Mammal : Animal
    {
        string livingRegion;
        public string LivingRegion { get; set; }
        public Mammal(string type, string name, double weight, string livingRegion) : base(type, name, weight)
        {
            Type = type;
            Name = name;
            Weight = weight;
            LivingRegion = livingRegion;
        }
        public override void Feed(string foodType,int quantity)
        {
            switch (Type)
            {
                case "Dog":
                    Console.WriteLine("Woof!");
                    if (foodType != "Meat")
                        break;
                    Weight += 0.4 * quantity;
                    break;
                case "Mouse":
                    Console.WriteLine("Squeak");
                    if (foodType != "Vegetables" || foodType != "Fruit")
                        break;
                    Weight += 0.1 * quantity;
                    break;
                default:
                    break;
            }
        }
        public override string ToString()
        {
            return $"{Type} [{Name}, {Weight}, {LivingRegion}, {FoodEaten}]";
        }
    }
}
