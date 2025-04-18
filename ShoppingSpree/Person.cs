using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Text;

namespace ShoppingSpree
{
    internal class Person
    {
        private string name;
        private double money;
        private List<string> bagOfProdcuts;
        public Person(string name, double money, List<string> products)
        {
            Name = name;
            Money = money;
            BagOfProdcuts = products;
        }
        public string Name
        {
            get => name;
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name cannot be empty");
                }
                name = value;
            }
        }
        public double Money
        {
            get => money;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Money cannot be negative");
                }
                money = value;
            }
        }
        public List<string> BagOfProdcuts { get; set; }
        public bool CanBuy(Person person, Product product)
        {
            if (person.Money - product.Cost >= 0)
            {
                person.Money -= product.Cost;
                return true;
            }
            return false;
        }
    }
}
