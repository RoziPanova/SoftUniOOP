using System;
using System.Collections.Generic;
using System.Text;

namespace WildAnimals
{
    internal abstract class Animal
    {
        string name;
        double weight;
        int foodEaten;
        public string Name { get => name; set => name = value; }
        public double Weight { get => weight; set => weight = value; }
        public int FoodEaten { get => foodEaten; set => foodEaten = value; }
        string type;
        public string Type { get; set; }
        public abstract void Feed(string foodType,int quantity);
    }
}
