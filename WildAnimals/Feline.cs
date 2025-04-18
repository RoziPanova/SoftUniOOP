using System;
using System.Collections.Generic;
using System.Text;

namespace WildAnimals
{
    internal abstract class Feline : Mammal
    {

        public Feline(string type, string name, double weight, string livingRegion, string breed) : base(type, name, weight, livingRegion)
        {
            Type = type;
            Name = name;
            Weight = weight;
            LivingRegion = livingRegion;
            Breed = breed;
        }
        string breed;
        public string Breed { get; set; }
        public override string ToString()
        {
            return $"{Type} [{Name}, {Breed}, {Weight}, {LivingRegion}, {FoodEaten}]";
        }
    }
}
