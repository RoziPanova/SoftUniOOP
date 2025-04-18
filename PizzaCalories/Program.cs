using System;
using System.Collections.Generic;

namespace PizzaCalories
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string[] pizza = Console.ReadLine().Split(' ');
                string[] dough = Console.ReadLine().Split(' ');
                Dough dough1 = new Dough(dough[1].ToLower(), dough[2].ToLower(), double.Parse(dough[3]));
                Pizza pizza1 = new Pizza(pizza[1], dough1, new List<Topping>());
                string input;
                while ((input = Console.ReadLine()) != "END")
                {
                    string[] toppings = input.Split(" ");
                    pizza1.AddTopping(new Topping(toppings[1].ToLower(), int.Parse(toppings[2])));
                }
                Console.WriteLine(pizza1.Print());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
/*
Pizza Bulgarian
Dough White Chewy 100
Topping Sirene 50
Topping Cheese 50
Topping Krenvirsh 20
Topping Meat 10
END
 */
