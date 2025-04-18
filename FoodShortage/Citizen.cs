using FoodShortage;
using System;
using System.Collections.Generic;
using System.Text;

namespace BirthdayCelebrations
{
    public class Citizen : IBuyer
    {
        int age;
        string id;
        string birthdate;
        public string Name { get; set; }
        public int Age { get => age; set => age = value; }
        public string ID { get => id; set => id = value; }
        public string Birthdate { get => birthdate; set => birthdate = value; }
        public int Food { get; set; }
        public Citizen(string name, int age, string id, string birthdate)
        {
            Name = name;
            Age = age;
            ID = id;
            Birthdate = birthdate;
            Food = 0;
        }
        public void BuyFood()
        {
            Food += 10;
        }
    }
}
