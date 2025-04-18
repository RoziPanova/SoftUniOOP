using System;
using System.Collections.Generic;
using System.Linq;

namespace ShoppingSpree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] people = Console.ReadLine().Split(";", StringSplitOptions.RemoveEmptyEntries);
            string[] products = Console.ReadLine().Split(";", StringSplitOptions.RemoveEmptyEntries);
            List<Person> peopleList = new List<Person>();
            List<Product> productsList = new List<Product>();
            try
            {
                foreach (string p in people)
                {
                    string[] personMoney = p.Split("=");

                    peopleList.Add(new Person(personMoney[0], double.Parse(personMoney[1]), new List<string>()));


                }
                foreach (string p in products)
                {
                    string[] productsCost = p.Split("=");

                    productsList.Add(new Product(productsCost[0], double.Parse(productsCost[1])));
                }
                string input;
                while ((input = Console.ReadLine()) != "END")
                {
                    string[] line = input.Split(" ");
                    var currentPerson = peopleList.FirstOrDefault(x => x.Name == line[0]);
                    var currentProduct = productsList.FirstOrDefault(x => x.Name == line[1]);
                    if (currentPerson.CanBuy(currentPerson, currentProduct))
                    {
                        currentPerson.BagOfProdcuts.Add(currentProduct.Name);
                        Console.WriteLine($"{currentPerson.Name} bought {currentProduct.Name}");
                    }
                    else
                    {
                        Console.WriteLine($"{currentPerson.Name} can't afford {currentProduct.Name}");
                    }
                }
                foreach (var p in peopleList)
                {
                    if (p.BagOfProdcuts.Count == 0)
                    {
                        Console.WriteLine($"{p.Name} - Nothing bought");
                    }
                    else
                    {
                        Console.WriteLine($"{p.Name} - {string.Join(", ", p.BagOfProdcuts)}");
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
