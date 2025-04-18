using System;
using System.Collections.Generic;
using System.Text;

namespace WildAnimals
{
    internal abstract class Bird : Animal
    {
        double wingSize;
        public double WingSize { get; set; }
        public Bird(string type, string name, double weight, double wingSize)
        {
            Type = type;
            Name = name;
            Weight = weight;
            WingSize = wingSize;
        }
        public override string ToString()
        {
            return $"{Type} [{Name}, {WingSize}, {Weight}, {FoodEaten}] ";
        }
    }
}
