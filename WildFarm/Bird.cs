using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm
{
    internal class Bird : Animal
    {
        double wingSize;
        public double WingSize { get; set; }
        public Bird(string type, string name, double weight, double wingSize) : base(type, name, weight)
        {
            Type = type;
            Name = name;
            Weight = weight;
            WingSize = wingSize;
        }
        public override void Feed(string foodType, int quantity)
        {
            switch (Type)
            {
                case "Owl":
                    Console.WriteLine("Hoot Hoot");
                    if (foodType != "Meat")
                        Console.WriteLine(); break;
                    Weight += 0.25 * quantity;
                    break;
                case "Hen":
                    Console.WriteLine("Cluck"); 
                    Weight += 0.35 * quantity;
                    break;
                default:
                    break;
            }
        }
        public override string ToString()
        {
            return $"{Type} [{Name}, {WingSize}, {Weight}, {FoodEaten}]";
        }
    }
}
