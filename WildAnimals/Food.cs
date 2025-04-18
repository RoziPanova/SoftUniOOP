using System;
using System.Collections.Generic;
using System.Text;

namespace WildAnimals
{
    internal abstract class Food
    {
        string foodType;
        int quantity;
        public int Quantity { get; set; }
        public string FoodType { get; set; }
        public Food() { }
        public Food(string foodType, int quantity)
        {
            Quantity = quantity;
            FoodType = foodType;
        }
    }
}
