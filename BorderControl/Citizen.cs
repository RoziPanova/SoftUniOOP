using System;
using System.Collections.Generic;
using System.Text;

namespace BorderControl
{
    public class Citizen:BaseEntity
    {
        string name;
        int age;
        public string Name { get; set; }
        public int Age { get; set; }
        public Citizen(string name,int age,string id)
        {
            Name = name;
            Age = age;
            ID = id;
        }
    }
}
