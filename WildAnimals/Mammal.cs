using System;
using System.Collections.Generic;
using System.Text;

namespace WildAnimals
{
    internal abstract class Mammal : Animal
    {
        public Mammal(string type, string name, double weight, string livingRegion)
        {
            Type = type;
            Name = name;
            Weight = weight;
            LivingRegion = livingRegion;
        }

        string livingRegion;
        public string LivingRegion { get; set; }
        public override string ToString()
        {
            return $"{Type} [{Name}, {Weight}, {LivingRegion}, {FoodEaten}]";
        }
    }
}
