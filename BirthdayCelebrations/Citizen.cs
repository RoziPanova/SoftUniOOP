using System;
using System.Collections.Generic;
using System.Text;

namespace BirthdayCelebrations
{
    public class Citizen : BaseEntity
    {
        string name;
        int age;
        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }
        public Citizen(string name, int age, string id, string birthdate)
        {
            Name = name;
            Age = age;
            Birthdate = birthdate;
            ID = id;
        }

    }
}
