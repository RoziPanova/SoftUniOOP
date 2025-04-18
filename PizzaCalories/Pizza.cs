using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace PizzaCalories
{
    internal class Pizza
    {
        string name;
        Dough dough;
        List<Topping> toppings;

        public Pizza(string name, Dough dough, List<Topping> toppings)
        {
            Name = name;
            Dough = dough;
            Toppings = toppings;
        }
        public string Name
        {
            get => name;
            set
            {
                if (string.IsNullOrEmpty(value)||value.Length > 15)
                {
                    throw new Exception("Pizza name should be between 1 and 15 symbols.");
                }
                name = value;
            }
        }
        public Dough Dough { get; set; }
        public List<Topping> Toppings
        {
            get => toppings;
            set
            {
                toppings = value;
            }
        }
        public void AddTopping(Topping topping)
        {
            Toppings.Add(topping);
            if (Toppings.Count > 10)
            {
                throw new Exception("Number of toppings should be in range [0..10].");
            }

        }
        public string Print()
        {
            double totalCals = Dough.GetDoughCalories();
            foreach (var item in Toppings)
            {
                totalCals += item.GetToppingsCalories();
            }
            return $"{Name} - {totalCals:f2} Calories.";
        }
    }
}
