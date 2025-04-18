using System;
using System.Collections.Generic;
using System.Text;

namespace BirthdayCelebrations
{
    public class Pet : BaseEntity
    {
        string name;
        string birthdate;
        public string Name { get => name; set => name = value; }
        public Pet(string name, string birthdate)
        {
            Name = name;
            Birthdate = birthdate;
        }

    }
}
