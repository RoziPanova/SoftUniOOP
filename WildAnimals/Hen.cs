using System;
using System.Collections.Generic;
using System.Text;

namespace WildAnimals
{
    internal class Hen : Bird
    {
        public Hen(string type, string name, double weight, double wingSize) : base(type, name, weight, wingSize)
        {
            Type = type;
            Name = name;
            Weight = weight;
            WingSize = wingSize;
        }
        public override void Feed(string foodType, int quantity)
        {
            Console.WriteLine("Cluck");
            FoodEaten += quantity;
            Weight += 0.35 * quantity;
        }
    }
}
