using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PizzaCalories
{
    public class Topping
    {
        private const int calPerGram = 2;
        private string toppingType;
        private int toppingGrams;
        public Topping(string toppingType, int toppingGrams)
        {
            ToppingType = toppingType;
            ToppingGrams = toppingGrams;
        }
        public string ToppingType
        {
            get => toppingType;
            set
            {
                if (value != "meat" && value != "veggies" && value != "cheese" && value != "sauce")
                {
                    throw new Exception($"Cannot place {value.First().ToString().ToUpper() + value.Substring(1)} on top of your pizza.");
                }
                toppingType = value;
            }
        }
        public int ToppingGrams
        {
            get => toppingGrams;
            set
            {
                if (value <= 0 || value > 50)
                {
                    throw new Exception($"{ToppingType.First().ToString().ToUpper() + ToppingType.Substring(1)} weight should be in the range [1..50].");
                }
                toppingGrams = value;
            }
        }
        public double GetToppingsCalories()
        {
            double toppingMod = 0;
            switch (ToppingType)
            {
                case "meat":
                    toppingMod = 1.2;
                    break;
                case "veggies":
                    toppingMod = 0.8;
                    break;
                case "cheese":
                    toppingMod = 1.1;
                    break;
                case "sauce":
                    toppingMod = 0.9;
                    break;
                default:
                    break;
            }
            return calPerGram * toppingMod * ToppingGrams;
        }
    }
}
