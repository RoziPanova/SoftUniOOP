using System;
using System.Collections.Generic;
using System.Text;

namespace WildFarm
{
    internal abstract class Animal
    {
        string type;
        string name;
        double weight;
        int foodEaten;
        public string Type { get; set; }
        public string Name { get; set; }
        public double Weight { get; set; }
        public int FoodEaten { get; set; }
        public Animal(string type, string name, double weight)
        {
            Type = type;
            Name = name;
            Weight = weight;
        }
        public abstract void Feed(string foodType, int quantity);
    }
}
